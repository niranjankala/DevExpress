using BMOD.Data.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebAppSample.Model;

namespace BMOD.UserControls
{
    public partial class NeedToReturnControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region "Public Methods"
        internal void BindData(string workOrder)
        {
            BindGridView(workOrder);

        }
        internal void SetDataBaseParametersControlID(string selectionControlID)
        {
            //ControlParameter SelectParameter = (ControlParameter)DebrisDisposal.SelectParameters[0];
            //SelectParameter.ControlID = selectionControlID;
            //ControlParameter UpdateParameter = (ControlParameter)DebrisDisposal.UpdateParameters[0];
            //UpdateParameter.ControlID = selectionControlID;
            //ControlParameter WorkPerformInsertParameter = (ControlParameter)DebrisDisposal.InsertParameters[0];
            //WorkPerformInsertParameter.ControlID = selectionControlID;
        }


        #endregion

        #region "Private Methods"
        void BindGridView(string workOrder)
        {
            //DebrisDisposal.SelectParameters["WORKORDER"].DefaultValue = workOrder;
            // DebrisDisposal.InsertParameters["WORKORDER"].DefaultValue = workOrder;
            //NeedToReturnASPxFormLayout.DataBind();
        }
        #endregion

        protected void ASPxMemo3_TextChanged(object sender, EventArgs e)
        {

        }

        internal void SaveCheckListParameters(string[] parameters)
        {
            string workOrder = parameters[0];
            using (BMODEntityModel context = new BMODEntityModel())
            {
                BMODWiz entry = context.BMODWizs.FirstOrDefault(b => b.WorkOrder == workOrder);
                if (entry == null)
                {
                    entry = new BMODWiz
                    {
                        WorkOrder = workOrder
                    };
                    context.BMODWizs.Add(entry);
                }
                // Add the Create Dates
                if (entry.NTRRecordDate.HasValue == false)
                {
                    entry.NTRRecordDate = DateTime.Now;
                }
                entry.StockUsed = NTRASPxCheckBox.Checked;
                //entry.NTR = parameters.Last().Split(':').Last().Trim() == "true";
                entry.NTRUpdateDate = DateTime.Now;
                entry.NTRUpdateBy = AuthHelper.GetLoggedInUserInfo().EmployeeID;

                context.SaveChanges();
            }
        }
    }

}
