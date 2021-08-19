using BMOD.Data.Entities;

using DevExpress.Web;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebAppSample.Model;

namespace BMOD.UserControls
{
    public partial class StockUsedControl : System.Web.UI.UserControl
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
            ControlParameter SelectParameter = (ControlParameter)StockUsedDS.SelectParameters["WorkOrder"];
            SelectParameter.ControlID = selectionControlID;
            ControlParameter UpdateParameter = (ControlParameter)StockUsedDS.UpdateParameters["WorkOrder"];
            UpdateParameter.ControlID = selectionControlID;
            ControlParameter WorkPerformInsertParameter = (ControlParameter)StockUsedDS.InsertParameters["WorkOrder"];
            WorkPerformInsertParameter.ControlID = selectionControlID;
        }

            #endregion

            #region "Private Methods"
            void BindGridView(string workOrder)
        {
            //StockUsedDS.SelectParameters["WORKORDER"].DefaultValue = workOrder;
            grdStockUsed.DataBind();
            StockUsedWizASPxFormLayout.DataBind();
        }
        #endregion

        protected void StockUsedGrid_InitNewRow(object sender, DevExpress.Web.Data.ASPxDataInitNewRowEventArgs e)
        {
            e.NewValues["Date"] = DateTime.Today;
            e.NewValues["EmpNum"] = AuthHelper.GetLoggedInUserInfo()?.EmployeeID;
            ;

        }


        protected void StockUsedGrid_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            IDictionaryEnumerator enumerator = e.NewValues.GetEnumerator();
            enumerator.Reset();
            while (enumerator.MoveNext())
            {
                string parameterName = enumerator.Key.ToString();
                if (parameterName != "Count")
                {
                    string parameterValue = Convert.ToString(enumerator.Value);

                    StockUsedDS.InsertParameters[parameterName].DefaultValue = parameterValue;
                }
            }
            string currentTime = DateTime.Now.ToString();
            StockUsedDS.InsertParameters["DATE"].DefaultValue = DateTime.Today.ToShortDateString();

            StockUsedDS.InsertParameters["recorddate"].DefaultValue = currentTime;
            StockUsedDS.InsertParameters["EmpNum"].DefaultValue = AuthHelper.GetLoggedInUserInfo()?.EmployeeID;
            StockUsedDS.InsertParameters["updatedate"].DefaultValue = currentTime;
            StockUsedDS.InsertParameters["updateby"].DefaultValue = AuthHelper.GetLoggedInUserInfo()?.EmployeeID;

            StockUsedDS.Insert();
            StockUsedDS.DataBind();
            e.Cancel = true;
            grdStockUsed.CancelEdit();




        }

        protected void StockUsedGrid_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {


            IDictionaryEnumerator enumerator = e.NewValues.GetEnumerator();
            enumerator.Reset();
            while (enumerator.MoveNext())
            {
                string parameterName = enumerator.Key.ToString();
                if (parameterName != "Count")
                {
                    string parameterValue = Convert.ToString(enumerator.Value);

                    StockUsedDS.UpdateParameters[parameterName].DefaultValue = parameterValue;
                }
            }
            string currentTime = DateTime.Now.ToString();
            //StockUsedDS.UpdateParameters["DATE"].DefaultValue = DateTime.Today.ToShortDateString();

            StockUsedDS.UpdateParameters["EmpNum"].DefaultValue = AuthHelper.GetLoggedInUserInfo()?.EmployeeID;
            StockUsedDS.UpdateParameters["updatedate"].DefaultValue = currentTime;
            StockUsedDS.UpdateParameters["updateby"].DefaultValue = AuthHelper.GetLoggedInUserInfo()?.EmployeeID;

            StockUsedDS.Update();
            StockUsedDS.DataBind();
            e.Cancel = true;
            grdStockUsed.CancelEdit();





            StockUsedDS.UpdateParameters["EmpNum"].DefaultValue = AuthHelper.GetLoggedInUserInfo()?.EmployeeID;

            StockUsedDS.InsertParameters["updatedate"].DefaultValue = DateTime.Now.ToString(); 

            StockUsedDS.UpdateParameters["updateby"].DefaultValue = AuthHelper.GetLoggedInUserInfo()?.EmployeeID;

            grdStockUsed.DataBind();
            e.Cancel = true;
            grdStockUsed.CancelEdit();

        }






        protected void StockUsedGrid_CellEditorInitialize(object sender, ASPxGridViewEditorEventArgs e)
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
                if (entry.StockUsedRecordDate.HasValue == false)
                {
                    entry.StockUsedRecordDate = DateTime.Now;
                }


                entry.StockUsed = chkStockUsed.Checked;
                //entry.StockUsed = parameters.Last().Split(':').Last().Trim() == "true";
                entry.StockUsedUpdateDate = DateTime.Now;
                entry.StockUsedUpdateBy = AuthHelper.GetLoggedInUserInfo().EmployeeID;

                context.SaveChanges();
            }
        }



    }
}
