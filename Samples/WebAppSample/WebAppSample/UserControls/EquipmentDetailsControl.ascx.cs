using BMOD.Data.Entities;

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

    public partial class EquipmentDetailsControl : System.Web.UI.UserControl
    {
        string gblWorkOrder;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        #region "Public Methods"
        internal void BindData(string workOrder)
        {
            BindGridView(workOrder);
            gblWorkOrder = workOrder;

        }

        internal void SetDataBaseParametersControlID(string selectionControlID)
        {
            //ControlParameter SelectParameter = (ControlParameter)EquipmentDS.SelectParameters["WorkOrder"];
            //SelectParameter.ControlID = selectionControlID;
            //ControlParameter UpdateParameter = (ControlParameter)EquipmentDS.UpdateParameters["WorkOrder"];
            //UpdateParameter.ControlID = selectionControlID;
            //ControlParameter InsertParameter = (ControlParameter)EquipmentDS.UpdateParameters["WorkOrder"];
            //InsertParameter.ControlID = selectionControlID;

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
                if (entry.EquipmentUsedRecordDate.HasValue == false)
                {
                    entry.EquipmentUsedRecordDate = DateTime.Now;
                }

                // var chck = Page.FindControl(BeforePicturesASPxCheckBox.ID)as  ASPxCheckBox;
                // entry.BPTaken = false;
                entry.EquipmentUsed = EquipUsedWizASPxCheckBox.Checked;
                //entry.EquipmentUsed = parameters.Last().Split(':').Last().Trim() == "true";
                entry.EquipmentUsedUpdateDate = DateTime.Now;
                entry.EquipmentUsedUpdateBy = AuthHelper.GetLoggedInUserInfo().EmployeeID;
                context.SaveChanges();
            }
        }

        #endregion

        #region "Private Methods"
        void BindGridView(string workOrder)
        {
            // WorkPerformedDS.SelectParameters["WORKORDER"].DefaultValue = workOrder;
            //grdEquipmentUsed.DataBind();
            EquipUsedWizASPxFormLayout.DataBind();

        }
        #endregion

        #region "Control Events"
        protected void EquipmentDetails_InitNewRow(object sender, DevExpress.Web.Data.ASPxDataInitNewRowEventArgs e)
        {
            string currentEmpNumber = AuthHelper.GetLoggedInUserInfo()?.EmployeeID;
            e.NewValues["EquipDate"] = DateTime.Today;
            e.NewValues["EmpNum"] = currentEmpNumber;
            e.NewValues["recorddate"] = DateTime.Now;
            e.NewValues["updatedate"] = DateTime.Now;
            e.NewValues["updateby"] = currentEmpNumber;

        } 

        #endregion

        
    }
}