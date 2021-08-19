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
    public partial class WorkDeatilsControl : System.Web.UI.UserControl
    {

        #region "Page Events"
        protected void Page_Init(object sender, EventArgs e)
        {

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //SetCheckListParameterControls();
            }
        }

        #endregion

        #region "Control Events"
        protected void WorkPerformedASPxGridView_InitNewRow(object sender, DevExpress.Web.Data.ASPxDataInitNewRowEventArgs e)
        {
            DateTime customDate = new DateTime(1899, 12, 30);

            e.NewValues["WKTIME_OUT"] = customDate;
            e.NewValues["WKTIME_IN"] = customDate;
            e.NewValues["OWKTIME_OUT"] = customDate;
            e.NewValues["OWKTIME_IN"] = customDate;
            e.NewValues["DATE"] = DateTime.Today;
            e.NewValues["WHOWORKED"] = AuthHelper.GetLoggedInUserInfo()?.EmployeeID;

        }
        protected void WorkPerformedASPxGridView_CellEditorInitialize(object sender, ASPxGridViewEditorEventArgs e)
        {

            DateTime customDate = new DateTime(1899, 12, 30);
            if (e.Column.FieldName == "DATE")
            {
                (e.Editor as ASPxTimeEdit).DateTime = customDate;
            }
            customDate = new DateTime(1899, 12, 30, DateTime.Now.Hour, 45, 0);

            if (e.Column.FieldName == "WKTIME_OUT")
            {
                (e.Editor as ASPxTimeEdit).DateTime = customDate;
            }
            customDate = new DateTime(1899, 12, 30, DateTime.Now.Hour, 0, 0);

            if (e.Column.FieldName == "WKTIME_IN")
            {

                (e.Editor as ASPxTimeEdit).DateTime = customDate;
            }

            if (e.Column.FieldName == "OWKTIME_IN")
            {
                (e.Editor as ASPxTimeEdit).DateTime = customDate;
            }

            if (e.Column.FieldName == "OWKTIME_OUT")
            {
                (e.Editor as ASPxTimeEdit).DateTime = customDate;
            }

            if (e.Column.FieldName == "RWorkClass")
            {
                var wclassEditor = e.Editor as ASPxComboBox;

            }

        }

        protected void WorkPerformedASPxGridView_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {

        }

        protected void WorkPerformedASPxGridView_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            var ab = HttpContext.Current.User;
            IDictionaryEnumerator enumerator = e.NewValues.GetEnumerator();
            enumerator.Reset();
            while (enumerator.MoveNext())
            {
                string parmeterName = enumerator.Key.ToString();
                if (parmeterName != "Count")
                {
                    string parameterValue = Convert.ToString(enumerator.Value);

                    WorkPerformedDS.InsertParameters[parmeterName].DefaultValue = parameterValue;
                }
            }
            string currentTime = DateTime.Now.ToString();

            DateTime customDate = new DateTime(1899, 12, 30);
            DateTime OWorkTimeOut = customDate;
            DateTime OWorkTimeIn = customDate;
            WorkPerformedDS.InsertParameters["DATE"].DefaultValue = DateTime.Today.ToString();
            WorkPerformedDS.InsertParameters["DATEIN"].DefaultValue = currentTime;
            WorkPerformedDS.InsertParameters["WHOWORKED"].DefaultValue = AuthHelper.GetLoggedInUserInfo()?.EmployeeID;
            DateTime.TryParse(WorkPerformedDS.InsertParameters["WKTIME_OUT"].DefaultValue, out DateTime workTimeOut);
            DateTime.TryParse(WorkPerformedDS.InsertParameters["WKTIME_IN"].DefaultValue, out DateTime workTimeIn);
            WorkPerformedDS.InsertParameters["OWKTIME_OUT"].DefaultValue = OWorkTimeOut.ToString();
            WorkPerformedDS.InsertParameters["OWKTIME_IN"].DefaultValue = OWorkTimeIn.ToString();
            float.TryParse(WorkPerformedDS.InsertParameters["TIMEOFF"].DefaultValue, out float timeOff);
            float.TryParse(WorkPerformedDS.InsertParameters["OTOTTIME"].DefaultValue, out float OTOTTIME);

            WorkPerformedDS.InsertParameters["recorddate"].DefaultValue = currentTime;
            WorkPerformedDS.InsertParameters["updatedate"].DefaultValue = currentTime;
            WorkPerformedDS.InsertParameters["updateby"].DefaultValue = AuthHelper.GetLoggedInUserInfo()?.EmployeeID;

            WorkPerformedDS.Insert();
            WorkPerformedDS.DataBind();
            e.Cancel = true;
            grdWorkPerformed.CancelEdit();
        }



        protected void WorkPerformedASPxGridView_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {

        }

        protected void WorkPerformedASPxGridView_RowUpdated(object sender, DevExpress.Web.Data.ASPxDataUpdatedEventArgs e)
        {

        }

        protected void WorkPerformedASPxGridView_CustomUnboundColumnData(object sender, ASPxGridViewColumnDataEventArgs e)
        {

        }

        protected void WorkPerformedASPxGridView_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {
            //ASPxGridView grid = (ASPxGridView)sender;
            //ASPxTimeEdit workTimeInEditor = (ASPxTimeEdit)grid.FindEditRowCellTemplateControl(((GridViewDataColumn)grid.Columns["WKTIME_IN"]), "UnitPriceEditor");
            //ASPxTimeEdit workTimeOutEditor = (ASPxTimeEdit)grid.FindEditRowCellTemplateControl(((GridViewDataColumn)grid.Columns["WKTIME_OUT"]), "UnitsInStockEditor");
            //ASPxTextBox workTotalTimeEditor = (ASPxTextBox)grid.FindEditRowCellTemplateControl(((GridViewDataColumn)grid.Columns["Total"]), "TotalEditor");

            //totalEditor.Value = Convert.ToDecimal(unitPriceEditor.Value) * Convert.ToDecimal(unitsInStockEditor.Value);
        }
        #endregion

        #region "Public Methods"
        internal void BindData(string workOrder)
        {
            BindGridView(workOrder);

        }
        internal void SetDataBaseParametersControlID(string selectionControlID)
        {
            ControlParameter SelectParameter = (ControlParameter)WorkPerformedDS.SelectParameters["WorkOrder"];
            SelectParameter.ControlID = selectionControlID;
            ControlParameter UpdateParameter = (ControlParameter)WorkPerformedDS.UpdateParameters["WorkOrder"];
            UpdateParameter.ControlID = selectionControlID;
            ControlParameter WorkPerformInsertParameter = (ControlParameter)WorkPerformedDS.InsertParameters["WorkOrder"];
            WorkPerformInsertParameter.ControlID = selectionControlID;
            ControlParameter WorkPerformedChkBoxDSSelectParameter = (ControlParameter)WorkPerformedChkBoxDS.SelectParameters["WorkOrder"];
            WorkPerformedChkBoxDSSelectParameter.ControlID = selectionControlID;


        }

        #endregion

        #region "Private Methods"
        void BindGridView(string workOrder)
        {
            //  WorkPerformedDS.SelectParameters["WORKORDER"].DefaultValue = workOrder;
            grdWorkPerformed.DataBind();
            WorkPerformWizASPxFormLayout.DataBind();
            //SetCheckListParameterControls(workOrder);

        }
        private void SetCheckListParameterControls()
        {
            ControlParameter SelectParameter = (ControlParameter)WorkPerformedDS.SelectParameters["WorkOrder"];

            ASPxComboBox cbWorkOrder = Page.FindControl(SelectParameter.ControlID) as ASPxComboBox;
            string workOrder = string.Empty;
            if (cbWorkOrder != null && cbWorkOrder.Value != null)
            {
                workOrder = cbWorkOrder.Value.ToString();
            }
            SetCheckListParameterControls(workOrder);
        }
        private void SetCheckListParameterControls(string workOrder)
        {
            BMODWiz entry = null;
            using (BMODEntityModel context = new BMODEntityModel())
            {
                entry = context.BMODWizs.FirstOrDefault(b => b.WorkOrder == workOrder);
            }
            BeforePicturesASPxCheckBox.Checked = entry?.BPTaken ?? false;
            AfterPicturesASPxCheckBox.Checked = entry?.AfterPic ?? false;
            SiteCleanedWPASPxCheckBox.Checked = entry?.SiteCleaned ?? false;
            WorkPerformedWPASPxCheckBox.Checked = entry?.WorkPerformed ?? false;
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
                if (entry.BPTakenRecordDate.HasValue == false)
                {
                    entry.BPTakenRecordDate = DateTime.Now;
                    entry.AfterPicRecordDate = DateTime.Now;
                    entry.SiteCleanedRecordDate = DateTime.Now;
                    entry.WorkPerformedRecordDate = DateTime.Now;
                }

                // var chck = Page.FindControl(BeforePicturesASPxCheckBox.ID)as  ASPxCheckBox;
                // entry.BPTaken = false;
                //foreach (string param in parameters)
                //{
                //    string[] arrParam = param.Split(':');
                //    string paramName = arrParam[0].Trim();
                //    bool paramValue = (arrParam.Length > 1 ? arrParam[1].Trim() : "") == "true";
                //    switch (paramName)
                //    {
                //        case "BeforePictures":
                //            entry.BPTaken = paramValue;
                //            break;
                //        case "AfterPictures":
                //            entry.AfterPic = paramValue;
                //            break;
                //        case "SiteCleaned":
                //            entry.SiteCleaned = paramValue;
                //            break;
                //        case "WorkPerformed":
                //            entry.WorkPerformed = paramValue;
                //            break;
                //    }
                //}

                entry.BPTaken = BeforePicturesASPxCheckBox.Checked;
                entry.BPTakenUpdateDate = DateTime.Now;
                entry.BPTakenUpdateBy = AuthHelper.GetLoggedInUserInfo().EmployeeID;
                entry.AfterPic = AfterPicturesASPxCheckBox.Checked;
                entry.AfterPicUpdateDate = DateTime.Now;
                entry.AfterPicUpdateBy = AuthHelper.GetLoggedInUserInfo().EmployeeID;
                entry.SiteCleaned = SiteCleanedWPASPxCheckBox.Checked;
                entry.SiteCleanedUpdateDate = DateTime.Now;
                entry.SiteCleanedUpdateBy = AuthHelper.GetLoggedInUserInfo().EmployeeID;
                entry.WorkPerformed = WorkPerformedWPASPxCheckBox.Checked;
                entry.WorkPerformedUpdateDate = DateTime.Now;
                entry.WorkPerformedUpdateBy = AuthHelper.GetLoggedInUserInfo().EmployeeID;

                context.SaveChanges();
            }
        }

        #endregion

        protected void WorkPerformedASPxGridView_RowValidating(object sender, DevExpress.Web.Data.ASPxDataValidationEventArgs e)
        {
            // DateTimeHelper TimeValidation = new DateTimeHelper();

            /* Run the Time Overlap Detection from BMOD.Common project */
            //string workDate = DateTime.Today.ToString();
            DateTime workDate = DateTime.Today;
            DateTime.TryParse(e.NewValues["WKTIME_IN"].ToString(), out DateTime workTimeIn);
            DateTime.TryParse(e.NewValues["WKTIME_OUT"].ToString(), out DateTime workTimeOut);


            DateTime customDate = new DateTime(1899, 12, 30);
            DateTime OworkTimeIn = customDate;
            DateTime OworkTimeOut = customDate;


            //Call the Time Overlap Validation Procedure Here
            //
            //
            string employeeId = string.Empty;
            int currentWorkItemId = -1;
            //var currentUser = IdentityHelper.GetCurrentUser(HttpContext.Current.User?.Identity?.GetUserName());
            //currentUser.EmployeeID

            //
            // Code to detect if this Time Entry is in conflict with other Time Entries for this employee
            //
            employeeId = AuthHelper.GetLoggedInUserInfo()?.EmployeeID;

            List<EMPLWORK> employeeWorkItems = null;
            using (BMODEntityModel model = new BMODEntityModel())
            {
                employeeWorkItems = model.EMPLWORKs.Where(ew =>
                (ew.DATE ?? DateTime.Today) == workDate
                && ew.WHOWORKED == employeeId
                && (currentWorkItemId > 0 ? ew.ID != currentWorkItemId : true))
                 .OrderBy(ew => ew.WKTIME_IN).ToList();
            }

            //employeeWorkItems.Add(new EMPLWORK()
            //{
            //    ID = -1,
            //    WorkOrder = WorkPerformedDS.SelectParameters["WORKORDER"].DefaultValue,
            //    WKTIME_IN = workTimeIn,
            //    WKTIME_OUT = workTimeOut,
            //}); ;

            //
            // Test Conditions for Time Overlap
            //


            //employeeWorkItems = employeeWorkItems.OrderBy(ew => ew.WKTIME_IN).ToList();
            // New item totally contained between in and out
            // Existing In/ NewIn / New Out / Existing Out
            // Lower Boundary new_in is less than existing, but new_out is between  existing wkin/wk out
            // NewIn/ existingIn / New-End / Existing-End
            // Upper Boundary
            //Existing In / New In  /Existing Out  /New Out

            var overlappingWorkOrder = employeeWorkItems.FirstOrDefault(ew =>
           (workTimeIn >= ew.WKTIME_IN && workTimeIn < ew.WKTIME_OUT && workTimeOut <= ew.WKTIME_OUT) ||
           (ew.WKTIME_IN >= workTimeIn && ew.WKTIME_IN <= ew.WKTIME_OUT && ew.WKTIME_OUT <= workTimeOut) ||
           (workTimeIn >= ew.WKTIME_IN && workTimeIn < ew.WKTIME_OUT && workTimeOut >= ew.WKTIME_IN));

            if (overlappingWorkOrder != null)
            {
                string errorMessage = $"Time Overlap detected on Work Order {overlappingWorkOrder.WorkOrder}, work detail {overlappingWorkOrder.ID}";
                e.RowError = errorMessage;
            }




            //timeOK = TimeValidation.PrepareTimeSlot(string.Empty,
            // workTimeIn.ToString("HH:mm"),
            // workTimeOut.ToString("HH:mm"),
            //OworkTimeIn.ToString("HH:mm"),
            // OworkTimeOut.ToString("HH:mm"),
            // WorkPerformedDS.SelectParameters["WORKORDER"].DefaultValue,
            // workDate, GlobalVariables.EmployeeNumber);


            //string workDate = DateTime.Today.ToString();
            //if (DateTime.TryParse(e.NewValues["WKTIME_IN"].ToString(), out DateTime workTimeIn) &&
            //    DateTime.TryParse(e.NewValues["WKTIME_OUT"].ToString(), out DateTime workTimeOut) 
            //    )
            //{
            //    DateTime customDate = new DateTime(1899, 12, 30);
            //   DateTime OworkTimeIn = customDate;
            //    DateTime OworkTimeOut = customDate;

            //string ResponseString = TimeValidation.PrepareTimeSlot(string.Empty,
            // workTimeIn.ToString("HH:mm"), 
            // workTimeOut.ToString("HH:mm"),
            //OworkTimeIn.ToString("HH:mm"), 
            // OworkTimeOut.ToString("HH:mm"), 
            // WorkPerformedDS.SelectParameters["WORKORDER"].DefaultValue,
            // workDate, Common.GlobalVariables.EmployeeNumber);

            //if (!string.IsNullOrWhiteSpace(ResponseString))
            //{
            //    e.RowError = ResponseString;
            //}
            //}
            //else
            //{

            //}
            //PrepareTimeSlot(EmpWorkID As String, RegTimeIn As String, RegTimeOut As String, OverTimeIn As String, OverTimeOut As String, WO As String, WDDate As String, Employee As String) As String
        }


        protected void WorkPerformedASPxGridView_CommandButtonInitialize(object sender, DevExpress.Web.ASPxGridViewCommandButtonEventArgs e)
        {
            if (e.VisibleIndex == -1)
                return;
            if (grdWorkPerformed.GetRowValues(e.VisibleIndex, "DATE") == null)
                return;

            string linestatus = grdWorkPerformed.GetRowValues(e.VisibleIndex, "DATE").ToString();
            if (linestatus == DateTime.Today.ToString())
            {
                if (e.ButtonType == DevExpress.Web.ColumnCommandButtonType.Edit)
                {
                    e.Visible = true;
                }
                else if (e.ButtonType == DevExpress.Web.ColumnCommandButtonType.Delete)
                {
                    e.Visible = true;
                }


            }
            else
            if (e.ButtonType == DevExpress.Web.ColumnCommandButtonType.Edit)
            {
                e.Visible = false;
            }
            else if (e.ButtonType == DevExpress.Web.ColumnCommandButtonType.Delete)
            {
                e.Visible = false;
            }



        }

        protected void WorkPerformcbCallback_Callback(object source, CallbackEventArgs e)
        {
            ControlParameter SelectParameter = (ControlParameter)WorkPerformedDS.SelectParameters["WorkOrder"];

            ASPxComboBox cbWorkOrder = Page.FindControl(SelectParameter.ControlID) as ASPxComboBox;
            if (cbWorkOrder != null && cbWorkOrder.Value != null)
            {
                // SaveCheckListParameters(cbWorkOrder.Value.ToString());
            }
        }

        protected void workDetailsCallbackPanel_Callback(object sender, CallbackEventArgsBase e)
        {
            ControlParameter SelectParameter = (ControlParameter)WorkPerformedDS.SelectParameters["WorkOrder"];

            ASPxComboBox cbWorkOrder = Page.FindControl(SelectParameter.ControlID) as ASPxComboBox;
            if (cbWorkOrder != null && cbWorkOrder.Value != null)
            {
                //SaveCheckListParameters(cbWorkOrder.Value.ToString());
            }
        }
    }
}