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
    public partial class DebrisDisposalDetailsControl : System.Web.UI.UserControl
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
            ControlParameter controlParameterDebrisDisposal = (ControlParameter)dsDebrisDisposal.SelectParameters[0];
            controlParameterDebrisDisposal.ControlID = selectionControlID;
            ControlParameter DebrisInsertParameter = (ControlParameter)dsDebrisDisposal.InsertParameters[0];
            DebrisInsertParameter.ControlID = selectionControlID;
            ControlParameter DebrisUpdateParameter = (ControlParameter)dsDebrisDisposal.UpdateParameters[0];
            DebrisUpdateParameter.ControlID = selectionControlID;
            ControlParameter DebrisCheckboxParameter = (ControlParameter)DebrisChkBoxDS.SelectParameters[0];
            DebrisCheckboxParameter.ControlID = selectionControlID;

        }

        #endregion

        #region "Private Methods"
        void BindGridView(string workOrder)
        {
            //Update the Parameter with correct workorder
            //DebrisDisposal.SelectParameters["WORKORDER"].DefaultValue = workOrder;
            //Call the Select Query using the New WorkOrder value passed from the Left Panel CBO on the main TabPage.
            //grdDebrisDisposal.DataBind();
            DebrisDisposalASPxFormLayout.DataBind();
        }
        #endregion

        protected void grdDisposalDetails_CellEditorInitialize(object sender, DevExpress.Web.ASPxGridViewEditorEventArgs e)
        {
            ASPxGridView gridView = sender as ASPxGridView;
            if (gridView.IsEditing)
            {
                if (e.Column.FieldName == "DebrisSelection")
                {
                    // Allow you to set the Amount field on the Edit form and set it's value on the basis of selection

                    //ASPxComboBox selectionControl = e.Editor as ASPxComboBox;
                    //selectionControl.Width = new Unit(100, UnitType.Percentage);
                    //selectionControl.CustomJSProperties += SelectionControl_CustomJSProperties;
                }
                else if (e.Column.FieldName == "DebrisAmount")
                {
                    //e.Editor.ReadOnly = true;
                }
                else if (e.Column.FieldName == "DebrisDescription")
                {
                    //e.Editor.ReadOnly = true;
                    e.Editor.Value = "Debris Disposal";
                }

            }
        }

        private void SelectionControl_CustomJSProperties(object sender, CustomJSPropertiesEventArgs e)
        {
            ASPxComboBox editor = sender as ASPxComboBox;
            ArrayList list = new ArrayList();
            foreach (ListEditItem item in editor.Items)
                list.Add(item.GetFieldValue("DebrisAmount"));
            e.Properties["cpHiddenColumnValues"] = list;
        }

        protected void debrisSelectionCallback_Callback(object source, CallbackEventArgs e)
        {
            // 
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
                if (entry.DebrisRecordDate.HasValue == false)
                {
                    entry.DebrisRecordDate = DateTime.Now;
                }

                // var chck = Page.FindControl(BeforePicturesASPxCheckBox.ID)as  ASPxCheckBox;
                // entry.BPTaken = false;
                entry.Debris = chkDebrisDisposal.Checked;
                //entry.Debris = parameters.Last().Split(':').Last().Trim() == "true";
                entry.DebrisUpdateDate = DateTime.Now;
                entry.DebrisUpdateBy = AuthHelper.GetLoggedInUserInfo().EmployeeID;
                context.SaveChanges();
            }
        }

    }
}