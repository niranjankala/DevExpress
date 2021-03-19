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
    public partial class ReceiptsControl : System.Web.UI.UserControl
    {
        string currentEmployeeNumber;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        #region "Public Methods"
        internal void BindData(string workOrder)
        {
            BindGridView(workOrder);

        }
        internal void SetCurrentEmployeeNumber(string empNumber)
        {
            currentEmployeeNumber = empNumber;

        }

        #endregion

        #region "Private Methods"
        void BindGridView(string workOrder)
        {
            //WorkPerformedDS.SelectParameters["WORKORDER"].DefaultValue = workOrder;
            ReceiptsWizASPxFormLayout.DataBind();
        }
        #endregion

        protected void ReceiptsASPxGridView_CellEditorInitialize(object sender, DevExpress.Web.ASPxGridViewEditorEventArgs e)
        {
            e.Editor.ReadOnly = false;
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
                if (entry.ReceiptsRecordDate.HasValue == false)
                {
                    entry.ReceiptsRecordDate = DateTime.Now;
                }


                entry.Receipts = chkReceiptsWiz.Checked;
                //entry.Receipts =parameters.Last().Split(':').Last().Trim() == "true";
                entry.ReceiptsUpdateDate = DateTime.Now;
                entry.ReceiptsUpdateBy = AuthHelper.GetLoggedInUserInfo().EmployeeID;

                context.SaveChanges();
                ReceiptsWizASPxFormLayout.DataBind();

            }
        }
    }
}