using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using DevExpress.Web;
using System.Collections;
using System.Configuration;

using BMOD.Data.Entities;
using WebAppSample.Model;

namespace BMOD
{

    public partial class frmMain : System.Web.UI.Page
    {
        string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        protected void Page_Init(object sender, EventArgs e)
        {
            //Sign in user
            if (AuthHelper.GetLoggedInUserInfo() == null)
                AuthHelper.SignIn("JBell", "");

            // Get the Employee Number code in comment and then assign to Select Parameter

            //string currentEmpNumber = AuthHelper.GetLoggedInUserInfo()?.EmployeeID;
            SqlDataSource3.SelectParameters["EmpNum"].DefaultValue = AuthHelper.GetLoggedInUserInfo()?.EmployeeID;

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                Int32.TryParse(Request.QueryString["tab"], out int selectedTabID);
                //if (HttpContext.Current.Session["CurrentTabIndex"] != null 
                //    && int.TryParse(HttpContext.Current.Session["CurrentTabIndex"].ToString(),out int previousTabIndex) )
                //{  
                //   if(! ASPxEdit.ValidateEditorsInContainer(mainTabPage, $"group{ mainTabPage.TabPages[previousTabIndex].Name}", true)))
                //    {
                //        mainTabPage.ActiveTabIndex = previousTabIndex;
                //    }
                //   else
                //    {
                //        mainTabPage.ActiveTabIndex = selectedTabID;
                //    }
                //}
                //else
                //{
                //    mainTabPage.ActiveTabIndex = selectedTabID;
                //}

                if (HttpContext.Current.Session["CurrentWorkOrder"] != null)
                {
                    WOSelected.Value = HttpContext.Current.Session["currentWorkOrder"].ToString();
                }
                HttpContext.Current.Session["CurrentTabIndex"] = selectedTabID;
                mainTabPage.ActiveTabIndex = selectedTabID;


            }
            else
            {
                string workOrder = Convert.ToString(WOSelected.Value);
                ucEquipmentDetails.BindData("");
                ucWorkDeatils.BindData("");
                ucReceipts.BindData("");
                ucStockUsed.BindData("");
                ucDisposalDetails.BindData("");
                ucComplexAttributes.BindData("");
            }
        }
        protected void WOComboBox1_Init(object sender, EventArgs e)
        {
            var cb = (ASPxComboBox)sender;
            ControlParameter controlParameter = (ControlParameter)SqlDataSource2.SelectParameters[0];
            controlParameter.ControlID = cb.UniqueID;
            ucDisposalDetails.SetDataBaseParametersControlID(cb.UniqueID);
            ucWorkDeatils.SetDataBaseParametersControlID(cb.UniqueID);

            ucEquipmentDetails.SetDataBaseParametersControlID(cb.UniqueID);
            ucNeedToReturn.SetDataBaseParametersControlID(cb.UniqueID);
            ucStockUsed.SetDataBaseParametersControlID(cb.UniqueID);
            ucComplexAttributes.SetDataBaseParametersControlID(cb.UniqueID);

            //ucNeedToReturn.SetDataBaseParametersControlID(cb.UniqueID);

            //if (!String.IsNullOrEmpty(WOSelected.Value.ToString()))
            //{
            //SqlDataSource4.SelectParameters["WORKORDER"].DefaultValue =  WOSelected.Value.ToString();

            //}           

        }

        protected void ApptDateLabel_Init(object sender, EventArgs e)
        {
            // Code to turn the Date and Time Labels in the Work Order Combobox
            // into a blank string for readability reasons
            //


            ASPxLabel lbl = sender as ASPxLabel;
            ListBoxColumnCellTemplateContainer container = lbl.NamingContainer as ListBoxColumnCellTemplateContainer;
            DateTime.TryParse(container.Item.GetFieldValue("ApptDate").ToString(), out DateTime date);
            if (date == DateTime.MinValue || date == new DateTime(1900, 01, 01))
                lbl.Text = "";
            else
                lbl.Text = container.Item.GetFieldValue("ApptDate").ToString();
        }

        protected void ApptTimeLabel_Init(object sender, EventArgs e)
        {
            // Code to turn the Date and Time Labels in the Work Order Combobox
            // into a blank string for readability reasons
            //


            ASPxLabel lbl = sender as ASPxLabel;
            ListBoxColumnCellTemplateContainer container = lbl.NamingContainer as ListBoxColumnCellTemplateContainer;
            DateTime.TryParse(container.Item.GetFieldValue("ApptTime").ToString(), out DateTime date);
            if (date == DateTime.MinValue || date == new DateTime(1900, 01, 01) || date.ToShortTimeString() == "12:00 AM")
                lbl.Text = "";
            else
                //lbl.Text = container.Item.GetFieldValue("ApptTime").ToString();
                lbl.Text = date.ToShortTimeString();
        }



        protected void WAZEButton_Click(object sender, EventArgs eventArgs)
        {
            //Response.Write("<script language= 'javascript'> alert('If Installed the WAZE Applicaiton will start using current Address1, City, and ZipCode');</script>");
            string url;
            string urlEncoded;
            url = txtAddress1.Text + "," + ZipCodeTextBox.Text + " &navigate = yes & zoom = 17";
            urlEncoded = HttpUtility.UrlEncode(url);
            Response.Redirect("https://waze.com/ul?q=" + urlEncoded);
        }
        protected void WOComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataSource2.SelectParameters["WORKORDER"].DefaultValue = WOSelected.Value.ToString();
            HttpContext.Current.Session["CurrentWorkOrder"] = WOSelected.Value.ToString();

            //Refresh the data on the Grid and the Checkboxes
            //
            ASPxFormLayout1.DataBind();
            chkBoxASPxFormLayout.DataBind();
            //ToDo: Add Datasource for Materials
            //ToDo: Add Bind to datasource like below:

            ucWorkDeatils.BindData(WOSelected.Value.ToString());
            ucEquipmentDetails.BindData(WOSelected.Value.ToString());
            ucDisposalDetails.BindData(WOSelected.Value.ToString());
            ucNeedToReturn.BindData(WOSelected.Value.ToString());
            ucStockUsed.BindData(WOSelected.Value.ToString());
            ucComplexAttributes.BindData(WOSelected.Value.ToString());
            ucReceipts.BindData(WOSelected.Value.ToString());
            ResetChecklistControls();
        }

        private void ResetChecklistControls()
        {
            chkInspected.Checked = false;
            chkWOStarted.Checked = false;
            chkAddressPicture.Checked = false;
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(WOSelected.Text))
            {
                Response.Write("<script language= 'javascript'> alert('Select a Work Order from the Left Panel combobox first');</script>");


            }
            else
            {

                SqlDataSource2.UpdateParameters["WORKORDER"].DefaultValue = WOSelected.Value.ToString();
                SqlDataSource2.Update();

            }
        }
        protected void GridView_InitNewRow(object sender, DevExpress.Web.Data.ASPxDataInitNewRowEventArgs e)
        {
            e.NewValues["EquipDate"] = DateTime.Today;
        }



        protected void ASPxGridView6_CellEditorInitialize(object sender, ASPxGridViewEditorEventArgs e)
        {
            e.Editor.ReadOnly = false;
        }

        protected void ASPxGridView3_CellEditorInitialize(object sender, ASPxGridViewEditorEventArgs e)
        {
            e.Editor.ReadOnly = false;
        }

        protected void WOStartASPxCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Response.Write("<script language= 'javascript'> alert('Start Checkbox Changed'" + ");</script>");

            // ASPxPageControl pageControl2 = mainTabPage.TabPages(0).FindControl("WorkPerformed") as ASPxPageControl;
        }

        protected void WOSelected_ItemTextCellPrepared(object sender, ListBoxItemTextCellPreparedEventArgs e)
        {
            if (e.Column.FieldName == "ApptDate")
            {
                DateTime.TryParse(Convert.ToString(e.Item.GetFieldValue("ApptDate")), out DateTime apptDate);

                if ((apptDate) == new DateTime(1900, 01, 01))
                {
                    e.TextCell.Text = "";
                    e.Item.SetFieldValue("ApptDate", null);

                }


            }

        }

        protected void QWPTree_CustomCallback(object sender, DevExpress.Web.ASPxTreeList.TreeListCustomCallbackEventArgs e)
        {
            QWPTree.UnselectAll();
        }

        protected void chkBoxCallback_Callback(object source, CallbackEventArgs e)
        {
            if (WOSelected.Value != null && !string.IsNullOrWhiteSpace(e.Parameter))
            {
                string[] parameters = e.Parameter.Split(',');
                string tabName = parameters[0].Split(':')[1];
                //Replace first value with workorder 
                parameters[0] = WOSelected.Value.ToString();
                if (tabName == mainTabPage.TabPages[0].Name)
                {
                    using (BMODEntityModel context = new BMODEntityModel())
                    {
                        BMODWiz entry = context.BMODWizs.FirstOrDefault(b => b.WorkOrder == WOSelected.Value.ToString());
                        if (entry == null)
                        {
                            entry = new BMODWiz
                            {
                                WorkOrder = WOSelected.Value.ToString()
                            };
                            context.BMODWizs.Add(entry);

                        }
                        if (entry.WoStartedRecordDate.HasValue == false)
                        {
                            entry.WoStartedRecordDate = DateTime.Now;
                            entry.APRecordDate = DateTime.Now;
                            entry.InspectedRecordDate = DateTime.Now;
                        }
                        entry.WOStarted = chkWOStarted.Checked;
                        entry.woStartedUpdateDate = DateTime.Now;
                        entry.woStartedUpdateBy = AuthHelper.GetLoggedInUserInfo().EmployeeID;
                        entry.APTaken = chkAddressPicture.Checked;
                        entry.APUpdateDate = DateTime.Now;
                        entry.APUpdateBy = AuthHelper.GetLoggedInUserInfo().EmployeeID;
                        entry.Inspected = chkInspected.Checked;
                        entry.InspectedUpdateDate = DateTime.Now;
                        entry.InspectedUpdateBy = AuthHelper.GetLoggedInUserInfo().EmployeeID;

                        context.SaveChanges();
                    }
                }
                else if (tabName == mainTabPage.TabPages[1].Name)
                {

                    ucWorkDeatils.SaveCheckListParameters(parameters);
                }
                else if (tabName == mainTabPage.TabPages[2].Name)
                {
                    ucNeedToReturn.SaveCheckListParameters(parameters);
                }
                else if (tabName == mainTabPage.TabPages[3].Name)
                {//Stock Used Checkbox
                    ucStockUsed.SaveCheckListParameters(parameters);
                }
                else if (tabName == mainTabPage.TabPages[4].Name)
                {//Receipts Checkbox
                    ucReceipts.SaveCheckListParameters(parameters);
                }
                else if (tabName == mainTabPage.TabPages[5].Name)
                {//Debris Disposal Checkbox
                    ucDisposalDetails.SaveCheckListParameters(parameters);
                }
                else if (tabName == mainTabPage.TabPages[6].Name)
                {//Debris Disposal Checkbox
                    ucEquipmentDetails.SaveCheckListParameters(parameters);
                }
            }
        }

    }
}