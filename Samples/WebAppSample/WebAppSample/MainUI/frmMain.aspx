<%@ Page Title="" Language="C#" MasterPageFile="~/Root.master" AutoEventWireup="true" CodeBehind="frmMain.aspx.cs" Inherits="BMOD.frmMain" %>

<%@ Register Assembly="DevExpress.Web.ASPxTreeList.v20.2, Version=20.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxTreeList" TagPrefix="dx" %>

<%@ Register Src="~/UserControls/EquipmentDetailsControl.ascx" TagPrefix="uc" TagName="EquipmentDetails" %>
<%@ Register Src="~/UserControls/WorkDetailsControl.ascx" TagPrefix="uc" TagName="WorkDetails" %>
<%@ Register Src="~/UserControls/DebrisDisposalDetailsControl.ascx" TagPrefix="uc" TagName="DebrisDisposalDetails" %>
<%@ Register Src="~/UserControls/NeedToReturnControl.ascx" TagPrefix="uc" TagName="NeedToReturn" %>
<%@ Register Src="~/UserControls/StockUsedControl.ascx" TagPrefix="uc" TagName="StockUsed" %>
<%@ Register Src="~/UserControls/ReceiptsControl.ascx" TagPrefix="uc" TagName="Receipts" %>
<%@ Register Src="~/UserControls/WrapUpControl.ascx" TagPrefix="uc" TagName="WrapUp" %>
<%@ Register Src="~/UserControls/ComplexAttributes.ascx" TagPrefix="uc" TagName="ComplexAttributes" %>

<%@ Register Assembly="DevExpress.Web.v20.2, Version=20.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">

    <link rel="stylesheet" type="text/css" href='<%# ResolveUrl("~/Content/FRMMain.css") %>' />
    <script type="text/javascript" src='<%# ResolveUrl("~/Content/GridView.js") %>'></script>

    <script type="text/javascript">
        function OnInit(s, e) {
            var tab = mainTabPage.GetActiveTab();
            var item = navigationNavBar.GetItemByName(tab.name);
            navigationNavBar.SetSelectedItem(item);

        }
        function OnNavigationNavBarClick(s, e) {


            //mainTabPage.SetActiveTab(mainTabPage.GetTab(0));
            //var tabName = (mainTabPage.GetActiveTab()).name;

            //if (e.item.name !== tabName) {
            //    if (ASPxClientEdit.ValidateGroup('group' + tabName)) {
            //        mainTabPage.SetActiveTab(e.item.name);
            //    }
            //    else {
            //        e.processOnServer = false;

            //    }
            //}
            //else {
            //    e.processOnServer = false;
            //}
        }
        //      document.addEventListener('DOMContentLoaded', function (evt) {
        //                    if (leftPanel.IsExpandable() && !leftPanel.IsExpanded())
        //              leftPanel.Toggle();
        ////console.log('loaded via ' + evt.type);
        //      }, false);


        function OnTabChanging(s, e) {
            //debugger;
            var tabName = (mainTabPage.GetActiveTab()).name;
            var validationResult = ASPxClientEdit.ValidateGroup('group' + tabName);
            // Get the name of the Grid Control
            if (validationResult) {
                var gridName = 'grd' + tabName;
                var grid = ASPxClientControl.GetControlCollection().GetByName(gridName);
                if (grid != undefined && grid.IsEditing()) {
                    if (confirm("Changes were not saved.  Is it OK to discard changes?")) {
                        grid.CancelEdit();
                        //grid.EndEdit;                 
                    } else {
                        validationResult = false;
                    }
                }
            }
            e.reloadContentOnCallback = true;
            e.cancel = !validationResult;
        }


        function OnBackClick(s, e) {
            // debugger earbut
            var indexTab = (mainTabPage.GetActiveTab()).index;
            //mainTabPage.SetActiveTab(mainTabPage.GetTab(indexTab + 1));
            switch (indexTab) {
                case 0:
                    // mainTabPage.SetActiveTab(mainTabPage.GetTab(6));
                    break;
                case 1:
                    mainTabPage.SetActiveTabIndex(0);
                    break;
                case 2:
                    mainTabPage.SetActiveTabIndex(1);
                    break;
                case 3:
                    mainTabPage.SetActiveTabIndex(2);
                    break;
                case 4:
                    mainTabPage.SetActiveTabIndex(3);
                    break;
                case 5:
                    mainTabPage.SetActiveTabIndex(4);
                    break;
                case 6:
                    mainTabPage.SetActiveTabIndex(5);
                    break;
                case 7:
                    mainTabPage.SetActiveTabIndex(6);
                    break;

            }
        }
        function OnNextClick(s, e) {
            //debugger;
            var indexTab = (mainTabPage.GetActiveTab()).index;
            //mainTabPage.SetActiveTab(mainTabPage.GetTab(indexTab + 1));
            switch (indexTab) {
                case 0:
                    mainTabPage.SetActiveTabIndex(1);
                    break;
                case 1:
                    mainTabPage.SetActiveTabIndex(2);
                    break;
                case 2:
                    mainTabPage.SetActiveTabIndex(3);
                    break;
                case 3:
                    mainTabPage.SetActiveTabIndex(4);
                    break;
                case 4:
                    mainTabPage.SetActiveTabIndex(5);
                    break;
                case 5:
                    mainTabPage.SetActiveTabIndex(6);
                    break;
                case 6:
                    mainTabPage.SetActiveTabIndex(7);
                    break;
            }
        }
        function OnNTRNoClick(s, e) {
            e.processOnServer = false;

            NTRASPxCheckBox.SetChecked(true);
            mainTabPage.SetActiveTabIndex(1);
            //WorkPerformed Tab
        }
        function OnReceiptYesClick(s, e) {
            e.processOnServer = false;
            chkReceiptsWiz.SetChecked(false);
            grdReceipts.enabled = true;
            grdReceipts.CancelEdit()
            grdReceipts.AddNewRow()
        }
        function OnReceiptNoClick(s, e) {
            e.processOnServer = false;

            chkReceiptsWiz.SetChecked(true);
            mainTabPage.SetActiveTabIndex(3);
            //WorkPerformed Tab
        }
        function OnNTRYesClick(s, e) {
            e.processOnServer = false;
            NTRASPxCheckBox.SetChecked(false);
            //grdNTR.enabled = true;
            //grdNTR.CancelEdit()
            //grdNTR.AddNewRow()
        }
        function OnNTRNoClick(s, e) {
            e.processOnServer = false;

            NTRASPxCheckBox.SetChecked(true);
            mainTabPage.SetActiveTabIndex(1);
            //WorkPerformed Tab
        }
        function OnEquipUsedNoClick(s, e) {
            e.processOnServer = false;

            EquipUsedWizASPxCheckBox.SetChecked(true);
            mainTabPage.SetActiveTabIndex(5);
            //Receipts Tab
        }
        function OnEquipUsedYesClick(s, e) {
            e.processOnServer = false;
            EquipUsedWizASPxCheckBox.SetChecked(false);
            grdEquipmentUsed.enabled = true;
            grdEquipmentUsed.CancelEdit()
            grdEquipmentUsed.AddNewRow()
        }
        function OnStockUsedNoClick(s, e) {
            e.processOnServer = false;

            chkStockUsed.SetChecked(true);
            mainTabPage.SetActiveTabIndex(2);
            //Receipts Tab
        }
        function OnStockUsedYesClick(s, e) {
            e.processOnServer = false;
            chkStockUsed.SetChecked(false);
            grdStockUsed.enabled = true;
            grdStockUsed.CancelEdit();
            grdStockUsed.AddNewRow();
        }

        //OnDebrisUsedYesClick
        function OnDebrisUsedNoClick(s, e) {
            e.processOnServer = false;

            chkDebrisDisposal.SetChecked(true);
            mainTabPage.SetActiveTabIndex(4);
            //Receipts Tab
        }
        function OnDebrisUsedYesClick(s, e) {
            e.processOnServer = false;
            chkDebrisDisposal.SetChecked(false);
            grdDebrisDisposal.enabled = true;
            grdDebrisDisposal.CancelEdit()
            grdDebrisDisposal.AddNewRow()
        }



        function OnWrapUPNoClick(s, e) {
            e.processOnServer = false;
            chkWOSubmit.SetChecked(false);
            mainTabPage.SetActiveTabIndex(6);
            //StockUsed Tab
        }
        function OnWrapUPYesClick(s, e) {
            e.processOnServer = false;
            chkWOSubmit.SetChecked(true);
            mainTabPage.SetActiveTabIndex(0);
            //Main Tab
        }
        function chkWOSubmit_CheckedChanged(s, e) {
            //alert(s.GetChecked());
        }

        function OnQtrHrValidation(s, e) {
            //debugger;
            e.isValid = e.value.getMinutes() % 15 == 0;
            // e.isValid = true;
            e.errorText = "Time must be in 15 minute increments (00,15,30,45)";
        }
        function OnDecimalHrValidation(s, e) {
            //debugger;
            var timeOff = 0;
            var timeOffNumber = parseFloat(e.value);
            if (isNaN(timeOffNumber)) {
                timeOff = 0;
            } else {
                timeOff = timeOffNumber;
            }


            e.isValid = timeOff % .25 == 0;
            // e.isValid = true;
            e.errorText = "Time must be in 1/4 hour increments (00,25,50,75)";
        }


        function onCheckBoxValidation(s, e) {
            //debugger;
            e.isValid = e.value;
            e.errorText = "'Confirmation' is required";
        }


        function WorkTimeInValueChanged(s, e) {
            setTotTime();

        }
        function WorkTimeOutValueChanged(s, e) {
            setTotTime();
        }

        function setTotTime() {
            var timeIn = grdWorkPerformed.GetEditValue("WKTIME_IN");
            var timeOut = grdWorkPerformed.GetEditValue("WKTIME_OUT");
            var timeOff = grdWorkPerformed.GetEditValue("TIMEOFF");
            var timeOffNumber = parseFloat(timeOff);
            if (isNaN(timeOffNumber)) {
                timeOff = 0;
            } else {
                timeOff = timeOffNumber;
            }
            var myTot = ((timeOut - timeIn) / 60000 / 60).toPrecision(2) - timeOff;
            grdWorkPerformed.SetEditValue("TOTTIME", myTot);

        }

        function OnTimeEditorInit(s, e) {
            ASPxClientTimeEdit.prototype.ProcessInternalButtonClick = function (buttonIndex) { }
        }
        function OnTimeButtonClick(s, e) {
            if (e.buttonIndex == -2) //increment button  
            {
                var date = s.GetDate();
                var minutes = date.getMinutes();

                if (minutes % 15 == 0) {
                    date.setMinutes((minutes) + 15);  //interval = 30 min  ((15%15)+1)*15 + 15

                } else {
                    date.setMinutes((minutes) + 15 - (minutes % 15));
                }

                s.SetValue(date);
            }
            if (e.buttonIndex == -3) //decrement button  
            {
                var date = s.GetDate();
                var minutes = date.getMinutes();
                if (minutes % 15 == 0) {
                    date.setMinutes((minutes) - 15);  //interval = 30 min  ((15%15)+1)*15 + 15

                } else if (15 + (minutes % 15) > 15) {
                    date.setMinutes(minutes - (minutes % 15));
                } else {
                    date.setMinutes(minutes - (15 + (minutes % 15)));
                }

                //date.setMinutes(minutes - 15);  //interval = 30 min  
                s.SetValue(date);
            }
            setTotTime();
        }
        function EquipmentSetFocus(s, e) {
            debugger;
            if (s.IsEditing()) {
                var form = s.GetPopupEditForm();
                form.PopUp.AddHandler(function (s, e) {
                    var editor = grdEquipmentUsed.GetEditor('EquipID');
                    editor.Focus();
                });
            }
        }

        //CopyQuickWP
        function CopyQuickWP(s, e) {
            //var QWPNodes = QWPTree.GetSelectedNodeValues(['NodeID', 'ParentID', 'LVL1DESCRIPTION'], OnProcess);
            var QWPNodes = QWPTree.GetSelectedNodeValues(['LVL1DESCRIPTION'], OnProcess);


        }
        function CloseQuickWP(s, e) {
            //var QWPNodes = QWPTree.GetSelectedNodeValues(['NodeID', 'ParentID', 'LVL1DESCRIPTION'], OnProcess);
            //var QWPNodes = QWPTree.GetSelectedNodeValues(['LVL1DESCRIPTION'], OnProcess);
        }

        function OnProcess(value) {
            var currentContent = grdWorkPerformed.GetEditValue('DIDWHAT');
            if (currentContent != undefined &&
                currentContent != null) {
                currentContent = currentContent + "\n" + value.join(' ');
            } else {
                currentContent = value.join(' ');
            }

            grdWorkPerformed.SetEditValue('DIDWHAT', currentContent);
        }

        //ClearQuickWP
        function CollapseQuickWP(s, e) {
            QWPTree.CollapseAll();
        }
        function ClearQuickWP(s, e) {
            QWPTree.PerformCallback('UnselectAll', OnSelectAllCallBack);
        }
        function OnSelectAllCallBack() {

        }
        function onCheckedChange(s, e) {
            if (cbCallback.InCallback())
                return;
            debugger;
            var tabName = (mainTabPage.GetActiveTab()).name;
            var parameters = "TabName:" + tabName;            

            if (tabName == "WorkPerformed") {
                parameters = parameters + ",BeforePictures:" + BeforePicturesASPxCheckBox.GetChecked();
                parameters = parameters + ",AfterPictures:" + AfterPicturesASPxCheckBox.GetChecked();
                parameters = parameters + ",SiteCleaned:" + SiteCleanedWPASPxCheckBox.GetChecked();
                parameters = parameters + ",WorkPerformed:" + WorkPerformedWPASPxCheckBox.GetChecked();
            }
            else if (tabName == "NTR") {
                parameters = parameters + ",NTR:" + NTRASPxCheckBox.GetChecked();
            }
            else if (tabName == "StockUsed") {
                parameters = parameters + ",StockUsed:" + chkStockUsed.GetChecked();
            }
            else if (tabName == "Receipts") {
                parameters = parameters + ",Receipts:" + chkReceiptsWiz.GetChecked();
            }
            else if (tabName == "DebrisDisposal") {
                parameters = parameters + ",DebrisDisposal:" + chkDebrisDisposal.GetChecked();
            }
            else if (tabName == "EquipmentUsed") {
                parameters = parameters + ",EquipmentUsed:" + EquipUsedWizASPxCheckBox.GetChecked();
            }

            cbCallback.PerformCallback(parameters);
        }
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="LeftPanelContent" runat="server">
    <h3 class="leftpanel-section section-caption">Navigation</h3>
    <dx:ASPxComboBox ID="WOSelected" ClientInstanceName="WOSelected" runat="server" DataSourceID="SqlDataSource3"
        ValueType="System.String" Caption="Work Order" ValueField="WORKORDER" TextFormatString="{0}" OnItemTextCellPrepared="WOSelected_ItemTextCellPrepared"
        AutoPostBack="True" OnInit="WOComboBox1_Init" OnSelectedIndexChanged="WOComboBox1_SelectedIndexChanged">
        <Columns>
            <dx:ListBoxColumn Name="WORKORDER" FieldName="WORKORDER">
            </dx:ListBoxColumn>
            <dx:ListBoxColumn Name="ApptDate" FieldName="ApptDate">
                <CellTemplate>
                    <dx:ASPxLabel ID="Datelabel" runat="server" OnInit="ApptDateLabel_Init"></dx:ASPxLabel>
                </CellTemplate>

            </dx:ListBoxColumn>
            <dx:ListBoxColumn Name="ApptTime" FieldName="ApptTime">
                <CellTemplate>
                    <dx:ASPxLabel ID="Timelabel" runat="server" OnInit="ApptTimeLabel_Init"></dx:ASPxLabel>
                </CellTemplate>

            </dx:ListBoxColumn>
        </Columns>
    </dx:ASPxComboBox>

    <dx:ASPxNavBar runat="server" ID="NavigationNavBar" ClientInstanceName="navigationNavBar"
        AllowSelectItem="True" ShowGroupHeaders="False"
        Width="100%" CssClass="filters-navbar" EnableClientSideAPI="True">
        <ClientSideEvents Init="OnInit"
            ItemClick="OnNavigationNavBarClick" />
        <ItemStyle CssClass="item" />
        <Groups>
            <dx:NavBarGroup>
                <Items>
                    <dx:NavBarItem Text="Home" Selected="true" Name="Home" NavigateUrl="frmMain.aspx" />
                    <dx:NavBarItem Text="Work Performed" Name="WorkPerformed" NavigateUrl="frmMain.aspx?tab=1" />
                    <dx:NavBarItem Text="Need To Return" Name="NTR" NavigateUrl="frmMain.aspx?tab=2" />
                    <dx:NavBarItem Text="Stock Used" Name="StockUsed" NavigateUrl="frmMain.aspx?tab=3" />
                    <dx:NavBarItem Text="Receipts" Name="Receipts" NavigateUrl="frmMain.aspx?tab=4" />
                    <dx:NavBarItem Text="Debris Disposal" Name="DebrisDisposal" NavigateUrl="frmMain.aspx?tab=5" />
                    <dx:NavBarItem Text="Equipment Used" Name="EquipmentUsed" NavigateUrl="frmMain.aspx?tab=6" />
                    <dx:NavBarItem Text="Wrap Up" Name="WrapUp" NavigateUrl="frmMain.aspx?tab=7" />
                </Items>
            </dx:NavBarGroup>
        </Groups>
    </dx:ASPxNavBar>
    <asp:SqlDataSource runat="server" ID="SqlDataSource3" ConnectionString='<%$ ConnectionStrings: DefaultConnection %>'
        SelectCommand="  SELECT tm.WorkOrder, tm.EmpNum, wo.WORKORDER, wo.[DATELOGGED], js.ApptDate as ApptDateTime, js.ScopeDate,js.scopeCompleted, convert(varchar(10), js.apptdate,103) as ApptDate, CONVERT(varchar,js.ApptDate,8) as ApptTime   FROM  Team as tm left join [WORKORDR] as wo  on tm.WorkOrder = wo.WORKORDER    left join JobScope as JS on tm.WORKORDER=js.WorkOrder   WHERE (tm.EmpNum = @EmpNum) and tm.EmpNum = js.EmployeeCode and (js.ScopeCompleted = 0  or isnull(js.ScopeCompleted,0) = 0  )  ORDER BY wo.WORKORDER">
        <%--        //ToDo: Put in the Employee Select.  Revise the Select command to take the appropriate number of parameters--%>

        <SelectParameters>
            <%--            <asp:ControlParameter Name="WORKORDER" ControlID="ctl00$LeftPanel$LeftPanelContent$WOSelected" DefaultValue="-1" PropertyName="Value" Type="STRING"></asp:ControlParameter>--%>
            <asp:Parameter Name="EmpNum" Type="String"></asp:Parameter>
            <%--        <asp:Parameter Name="EquipDate" Type="DATETIME"></asp:Parameter>
        <asp:Parameter Name="EmpNum" Type="STRING"></asp:Parameter>
        <asp:Parameter Name="recorddate" Type="DATETIME"></asp:Parameter>
        <asp:Parameter Name="updatedate" Type="DATETIME"></asp:Parameter>
        <asp:Parameter Name="updateby" Type="STRING"></asp:Parameter>
        <asp:Parameter Name="EUID" Type="Int32"></asp:Parameter>--%>
        </SelectParameters>


    </asp:SqlDataSource>

</asp:Content>


<asp:Content ID="Content3" ContentPlaceHolderID="RightPanelContent" runat="server">
    <dx:ASPxTreeList ID="QWPTree" ClientInstanceName="QWPTree" runat="server" OnCustomCallback="QWPTree_CustomCallback"
        DataSourceID="TreeViewDS" AutoGenerateColumns="False" KeyFieldName="NodeID" ParentFieldName="ParentID">

        <Columns>
            <dx:TreeListTextColumn FieldName="LVL1DESCRIPTION" Caption="QWP" AutoFilterCondition="Default" ShowInFilterControl="Default" VisibleIndex="1"></dx:TreeListTextColumn>
        </Columns>
        <SettingsBehavior ExpandCollapseAction="NodeDblClick" />

        <SettingsSelection Enabled="true" />
    </dx:ASPxTreeList>
    <asp:SqlDataSource runat="server" ID="TreeViewDS" ConnectionString='<%$ ConnectionStrings:DefaultConnection %>'
        DeleteCommand="DELETE FROM [EMPLWORKLVL1] WHERE [EMPLWORKLVL1id] = @EMPLWORKLVL1id"
        InsertCommand="INSERT INTO [EMPLWORKLVL1] ([NodeID], [LVL1DESCRIPTION], [ParentID], [SeqNo]) VALUES (@NodeID, @LVL1DESCRIPTION, @ParentID, @SeqNo)"
        SelectCommand="SELECT [EMPLWORKLVL1id], [NodeID], [LVL1DESCRIPTION], [ParentID], [SeqNo] FROM [EMPLWORKLVL1]"
        UpdateCommand="UPDATE [EMPLWORKLVL1] SET [NodeID] = @NodeID, [LVL1DESCRIPTION] = @LVL1DESCRIPTION, [ParentID] = @ParentID, [SeqNo] = @SeqNo WHERE [EMPLWORKLVL1id] = @EMPLWORKLVL1id">
        <DeleteParameters>
            <asp:Parameter Name="EMPLWORKLVL1id" Type="Int64"></asp:Parameter>
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="NodeID" Type="Int32"></asp:Parameter>
            <asp:Parameter Name="LVL1DESCRIPTION" Type="String"></asp:Parameter>
            <asp:Parameter Name="ParentID" Type="Int32"></asp:Parameter>
            <asp:Parameter Name="SeqNo" Type="Int32"></asp:Parameter>
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="NodeID" Type="Int32"></asp:Parameter>
            <asp:Parameter Name="LVL1DESCRIPTION" Type="String"></asp:Parameter>
            <asp:Parameter Name="ParentID" Type="Int32"></asp:Parameter>
            <asp:Parameter Name="SeqNo" Type="Int32"></asp:Parameter>
            <asp:Parameter Name="EMPLWORKLVL1id" Type="Int64"></asp:Parameter>
        </UpdateParameters>
    </asp:SqlDataSource>

    <dx:ASPxFormLayout ID="QWPButtonLayout" runat="server">
        <Items>
            <dx:LayoutItem ShowCaption="False" HorizontalAlign="Left" VerticalAlign="Middle" Paddings-PaddingTop="20px" CssClass="lastItem">

                <Paddings PaddingTop="20px"></Paddings>
                <SpanRules>
                    <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="S"></dx:SpanRule>
                    <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="M"></dx:SpanRule>
                </SpanRules>
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer>
                        <dx:ASPxButton ID="btnQuickWPOK" runat="server" Text="Add" AutoPostBack="false">
                            <ClientSideEvents Click="CopyQuickWP" />
                        </dx:ASPxButton>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
            <dx:LayoutItem ShowCaption="False" HorizontalAlign="Left" VerticalAlign="Middle" Paddings-PaddingTop="20px" CssClass="lastItem">

                <Paddings PaddingTop="20px"></Paddings>
                <SpanRules>
                    <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="S"></dx:SpanRule>
                    <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="M"></dx:SpanRule>
                </SpanRules>
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer>

                        <dx:ASPxButton ID="btnQWPCancel" runat="server" Text="Cancel" AutoPostBack="false">
                            <ClientSideEvents Click="CloseQuickWP" />

                        </dx:ASPxButton>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
            <dx:LayoutItem ShowCaption="False" HorizontalAlign="Left" VerticalAlign="Middle" Paddings-PaddingTop="20px" CssClass="lastItem">

                <Paddings PaddingTop="20px"></Paddings>
                <SpanRules>
                    <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="S"></dx:SpanRule>
                    <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="M"></dx:SpanRule>
                </SpanRules>
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer>
                        <dx:ASPxButton ID="btnQWPClearAll" runat="server" Text="Clear All" AutoPostBack="false">
                            <ClientSideEvents Click="ClearQuickWP" />
                        </dx:ASPxButton>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
            <dx:LayoutItem ShowCaption="False" HorizontalAlign="Left" VerticalAlign="Middle" Paddings-PaddingTop="20px" CssClass="lastItem">

                <Paddings PaddingTop="20px"></Paddings>
                <SpanRules>
                    <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="S"></dx:SpanRule>
                    <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="M"></dx:SpanRule>
                </SpanRules>
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer>
                        <dx:ASPxButton ID="btnQWPCollapseAll" runat="server" Text="Collapse All" AutoPostBack="false">
                            <ClientSideEvents Click="CollapseQuickWP" />
                        </dx:ASPxButton>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
        </Items>

    </dx:ASPxFormLayout>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="PageToolbar" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="PageContent" runat="server">

    <%-- Callback to handle the logging of the Checkbox Clicks --%>

    <dx:ASPxCallback ID="cbCallback" ClientInstanceName="cbCallback" runat="server"
        OnCallback="chkBoxCallback_Callback">
        <ClientSideEvents CallbackComplete="function(s, e) {
     
                                                               }" />
    </dx:ASPxCallback>

    <dx:ASPxPageControl ID="mainTabPage" ClientInstanceName="mainTabPage" Width="100%" runat="server" ActiveTabIndex="0"
        EnableTabScrolling="True" AutoPostBack="True" TabIndex="0" EnableCallBacks="True" EnableHierarchyRecreation="true">
        <ClientSideEvents ActiveTabChanging="OnTabChanging" TabClick="OnTabChanging" />
        <TabPages>
            <dx:TabPage Text="Home" Name="Home">
                <ContentCollection>
                    <dx:ContentControl ID="ContentControl1" runat="server">
                        <div class="frmMain">
                            <dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server" Width="100%" AlignItemCaptionsInAllGroups="True"
                                UseDefaultPaddings="false" CssClass="formLayout1" DataSourceID="SqlDataSource2">
                                <Styles>
                                    <LayoutGroup Cell-Paddings-PaddingTop="0" Cell-Paddings-PaddingBottom="0">
                                        <Cell>
                                            <Paddings PaddingTop="0px" PaddingBottom="0px"></Paddings>
                                        </Cell>
                                    </LayoutGroup>
                                    <LayoutItem Paddings-PaddingTop="0" Paddings-PaddingBottom="0">

                                        <Paddings PaddingTop="0px" PaddingBottom="0px"></Paddings>
                                    </LayoutItem>

                                </Styles>
                                <Items>
                                    <dx:LayoutGroup Caption="Contact" ColumnCount="3" ColSpan="1" Width="100%">
                                        <GridSettings StretchLastItem="true" WrapCaptionAtWidth="660">
                                            <Breakpoints>
                                                <dx:LayoutBreakpoint MaxWidth="500" ColumnCount="1" Name="S" />
                                                <dx:LayoutBreakpoint MaxWidth="800" ColumnCount="2" Name="M" />
                                            </Breakpoints>
                                        </GridSettings>
                                        <Items>
                                            <dx:LayoutItem Caption="Owner" FieldName="CUSTOMER" ColSpan="2" VerticalAlign="Middle">
                                                <SpanRules>
                                                    <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="S"></dx:SpanRule>
                                                    <dx:SpanRule ColumnSpan="2" RowSpan="1" BreakpointName="M"></dx:SpanRule>
                                                </SpanRules>
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                        <dx:ASPxLabel runat="server" Width="100%" ID="OwnerTextBox" ReadOnly="True"></dx:ASPxLabel>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                            <dx:LayoutItem FieldName="FullName" Caption="Tenant" ColSpan="2">
                                                <SpanRules>
                                                    <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="S"></dx:SpanRule>
                                                    <dx:SpanRule ColumnSpan="2" RowSpan="1" BreakpointName="M"></dx:SpanRule>
                                                </SpanRules>
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                        <dx:ASPxLabel runat="server" Width="100%" ID="TenantFirstNameTextBox" ReadOnly="True"></dx:ASPxLabel>

                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                        </Items>
                                    </dx:LayoutGroup>
                                    <dx:LayoutGroup Caption="Address" ColCount="3" ColumnCount="3" ColSpan="1">
                                        <GridSettings StretchLastItem="true" WrapCaptionAtWidth="660">
                                            <Breakpoints>
                                                <dx:LayoutBreakpoint MaxWidth="500" ColumnCount="1" Name="S" />
                                                <dx:LayoutBreakpoint MaxWidth="800" ColumnCount="2" Name="M" />
                                            </Breakpoints>
                                        </GridSettings>
                                        <Items>
                                            <dx:LayoutItem Caption="Complex" FieldName="Complex" ColSpan="2">
                                                <SpanRules>
                                                    <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="S"></dx:SpanRule>
                                                    <dx:SpanRule ColumnSpan="2" RowSpan="1" BreakpointName="M"></dx:SpanRule>
                                                </SpanRules>

                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                        <dx:ASPxLabel runat="server" ID="ComplexASPxTextBox" Width="100%" ReadOnly="True"></dx:ASPxLabel>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>

                                            <dx:LayoutItem Caption="Address 1" FieldName="Address1" ColSpan="3">
                                                <SpanRules>
                                                    <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="S"></dx:SpanRule>
                                                    <dx:SpanRule ColumnSpan="2" RowSpan="1" BreakpointName="M"></dx:SpanRule>
                                                </SpanRules>

                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                        <dx:ASPxLabel runat="server" ID="txtAddress1" Width="100%" ReadOnly="True"></dx:ASPxLabel>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                            <dx:LayoutItem Caption="City" FieldName="City" ColSpan="1">
                                                <SpanRules>
                                                    <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="S"></dx:SpanRule>
                                                    <dx:SpanRule ColumnSpan="2" RowSpan="1" BreakpointName="M"></dx:SpanRule>
                                                </SpanRules>
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                        <dx:ASPxLabel runat="server" ID="CityTextBox" Width="100%" ReadOnly="True"></dx:ASPxLabel>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                            <dx:LayoutItem Caption="State" FieldName="State" ColSpan="1">
                                                <SpanRules>
                                                    <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="S"></dx:SpanRule>
                                                    <dx:SpanRule ColumnSpan="2" RowSpan="1" BreakpointName="M"></dx:SpanRule>
                                                </SpanRules>
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                        <dx:ASPxLabel runat="server" ID="StateTextBox" Width="100%" ReadOnly="True"></dx:ASPxLabel>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                            <dx:LayoutItem Caption="Zip" FieldName="ZipCode" ColSpan="1">
                                                <SpanRules>
                                                    <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="S"></dx:SpanRule>
                                                    <dx:SpanRule ColumnSpan="2" RowSpan="1" BreakpointName="M"></dx:SpanRule>
                                                </SpanRules>

                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                        <dx:ASPxLabel runat="server" ID="ZipCodeTextBox" Width="100%" ReadOnly="True"></dx:ASPxLabel>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                            <dx:LayoutItem ShowCaption="False" HorizontalAlign="Left" VerticalAlign="Middle" Paddings-PaddingTop="20px" CssClass="lastItem">

                                                <Paddings PaddingTop="20px"></Paddings>
                                                <SpanRules>
                                                    <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="S"></dx:SpanRule>
                                                    <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="M"></dx:SpanRule>
                                                </SpanRules>
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer>
                                                        <dx:ASPxButton runat="server" ID="WAZEButton" Text="Launch WAZE" OnClick="WAZEButton_Click">
                                                        </dx:ASPxButton>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                        </Items>
                                    </dx:LayoutGroup>
                                    <dx:LayoutGroup Caption="Notes" ColumnCount="3" ColSpan="1" Width="100%">
                                        <GridSettings StretchLastItem="true" WrapCaptionAtWidth="660">
                                            <Breakpoints>
                                                <dx:LayoutBreakpoint MaxWidth="500" ColumnCount="1" Name="S" />
                                                <dx:LayoutBreakpoint MaxWidth="800" ColumnCount="2" Name="M" />
                                            </Breakpoints>
                                        </GridSettings>
                                        <Items>
                                            <dx:LayoutItem Caption="Work Description" FieldName="WODESCRIP" ColSpan="3" RowSpan="5"
                                                VerticalAlign="Middle" Paddings-PaddingBottom="20px">

                                                <Paddings PaddingBottom="20px"></Paddings>
                                                <SpanRules>
                                                    <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="S"></dx:SpanRule>
                                                    <dx:SpanRule ColumnSpan="2" RowSpan="5" BreakpointName="M"></dx:SpanRule>
                                                </SpanRules>
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                        <dx:ASPxMemo runat="server" Width="100%" ID="WODescriptionMemo" ReadOnly="True" Rows="5" ToolTip="Work Order Description Notes. Not editable in the field"></dx:ASPxMemo>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                            <dx:LayoutItem Caption="Inspected - Found" FieldName="FOUNDWHAT" ColSpan="3">
                                                <SpanRules>
                                                    <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="S"></dx:SpanRule>
                                                    <dx:SpanRule ColumnSpan="2" RowSpan="3" BreakpointName="M"></dx:SpanRule>
                                                </SpanRules>
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                        <dx:ASPxMemo runat="server" Width="100%" ID="FOUNDWHATMemo" Rows="5" ToolTip="Inspection Notes. Editable in the field until accepted by the Office"
                                                            AutoResizeWithContainer="True">
                                                            <ValidationSettings SetFocusOnError="True" ValidationGroup="groupHome" ErrorTextPosition="Bottom">
                                                                <RequiredField IsRequired="True" ErrorText="Inspection - Found information is required" />
                                                            </ValidationSettings>
                                                        </dx:ASPxMemo>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>

                                            <dx:LayoutItem ShowCaption="False" HorizontalAlign="Left" VerticalAlign="Middle" Paddings-PaddingTop="20px" CssClass="lastItem">
                                                <Paddings PaddingTop="20px"></Paddings>
                                                <SpanRules>
                                                    <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="S"></dx:SpanRule>
                                                    <dx:SpanRule ColumnSpan="2" RowSpan="1" BreakpointName="M"></dx:SpanRule>
                                                </SpanRules>
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer>
                                                        <dx:ASPxButton runat="server" ID="SubmitASPxButton" Text="Update Inspection" AutoPostBack="false" OnClick="SubmitButton_Click" />
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                        </Items>
                                    </dx:LayoutGroup>
                                    <dx:LayoutGroup Caption="" GroupBoxDecoration="None" ColumnCount="3" ColSpan="1" Width="100%">
                                        <GridSettings StretchLastItem="true" WrapCaptionAtWidth="660">
                                            <Breakpoints>
                                                <dx:LayoutBreakpoint MaxWidth="500" ColumnCount="1" Name="S" />
                                                <dx:LayoutBreakpoint MaxWidth="800" ColumnCount="2" Name="M" />
                                            </Breakpoints>
                                        </GridSettings>
                                        <Items>
                                            <dx:LayoutItem ShowCaption="false"  ColSpan="3">
                                                <SpanRules>
                                                    <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="S"></dx:SpanRule>
                                                    <dx:SpanRule ColumnSpan="2" RowSpan="1" BreakpointName="M"></dx:SpanRule>
                                                </SpanRules>
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer>



                                                        <dx:ASPxFormLayout ID="chkBoxASPxFormLayout" runat="server" Width="100%" AlignItemCaptionsInAllGroups="True"
                                                            UseDefaultPaddings="false" DataSourceID="chkBoxDS">

                                                            <Styles>
                                                                <LayoutGroup Cell-Paddings-PaddingTop="0" Cell-Paddings-PaddingBottom="0">
                                                                    <Cell>
                                                                        <Paddings PaddingTop="0px" PaddingBottom="0px"></Paddings>
                                                                    </Cell>
                                                                </LayoutGroup>
                                                                <LayoutItem Paddings-PaddingTop="0" Paddings-PaddingBottom="0">

                                                                    <Paddings PaddingTop="0px" PaddingBottom="0px"></Paddings>
                                                                </LayoutItem>

                                                            </Styles>
                                                            <Items>
                                                                <dx:LayoutGroup Caption="" ColumnCount="3" ColSpan="1" Width="100%">
                                                                    <GridSettings StretchLastItem="true" WrapCaptionAtWidth="660">
                                                                        <Breakpoints>
                                                                            <dx:LayoutBreakpoint MaxWidth="500" ColumnCount="1" Name="S" />
                                                                            <dx:LayoutBreakpoint MaxWidth="800" ColumnCount="2" Name="M" />
                                                                        </Breakpoints>
                                                                    </GridSettings>
                                                                    <Items>
                                                                        <dx:LayoutItem ShowCaption="true" Caption="WO Started"
                                                                            FieldName="WOStarted"
                                                                            VerticalAlign="Middle">
                                                                            <SpanRules>
                                                                                <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="S"></dx:SpanRule>
                                                                                <dx:SpanRule ColumnSpan="2" RowSpan="1" BreakpointName="M"></dx:SpanRule>
                                                                            </SpanRules>
                                                                            <LayoutItemNestedControlCollection>
                                                                                <dx:LayoutItemNestedControlContainer>
                                                                                    <dx:ASPxCheckBox runat="server" ID="chkWOStarted" ClientInstanceName="chkWOStarted" AutoPostBack="false" Checked="true">
                                                                                        <ValidationSettings SetFocusOnError="True" ValidationGroup="groupHome">
                                                                                            <RequiredField IsRequired="True" ErrorText="Work Order Started is required" />
                                                                                        </ValidationSettings>
                                                                                        <ClientSideEvents Validation="onCheckBoxValidation" ValueChanged="onCheckedChange" />
                                                                                    </dx:ASPxCheckBox>
                                                                                </dx:LayoutItemNestedControlContainer>
                                                                            </LayoutItemNestedControlCollection>
                                                                        </dx:LayoutItem>
                                                                        <dx:LayoutItem ShowCaption="True" FieldName="APTaken" Caption="Address Picture Taken" VerticalAlign="Middle">
                                                                            <SpanRules>
                                                                                <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="S"></dx:SpanRule>
                                                                                <dx:SpanRule ColumnSpan="2" RowSpan="1" BreakpointName="M"></dx:SpanRule>
                                                                            </SpanRules>
                                                                            <LayoutItemNestedControlCollection>
                                                                                <dx:LayoutItemNestedControlContainer>
                                                                                    <dx:ASPxCheckBox runat="server" ValidationSettings-RequiredField-IsRequired="true" ID="chkAddressPicture"
                                                                                        ClientInstanceName="chkAddressPicture" AutoPostBack="false" >
                                                                                        <ValidationSettings SetFocusOnError="True" ValidationGroup="groupHome">
                                                                                            <RequiredField IsRequired="True" ErrorText="Picture of Work Address is required" />
                                                                                        </ValidationSettings>
                                                                                        <ClientSideEvents Validation="onCheckBoxValidation"  ValueChanged="onCheckedChange" />
                                                                                    </dx:ASPxCheckBox>
                                                                                </dx:LayoutItemNestedControlContainer>
                                                                            </LayoutItemNestedControlCollection>
                                                                        </dx:LayoutItem>
                                                                        <dx:LayoutItem ShowCaption="True" FieldName="Inspected" Caption="Complete Inspected - Found" VerticalAlign="Middle">
                                                                            <SpanRules>
                                                                                <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="S"></dx:SpanRule>
                                                                                <dx:SpanRule ColumnSpan="2" RowSpan="1" BreakpointName="M"></dx:SpanRule>
                                                                            </SpanRules>
                                                                            <LayoutItemNestedControlCollection>
                                                                                <dx:LayoutItemNestedControlContainer>
                                                                                    <dx:ASPxCheckBox runat="server" ValidationSettings-RequiredField-IsRequired="true" ID="chkInspected"
                                                                                        ClientInstanceName="chkInspected" AutoPostBack="false" >
                                                                                        <ValidationSettings SetFocusOnError="True" ValidationGroup="groupHome">
                                                                                            <RequiredField IsRequired="True" ErrorText="Complete Inspection before Repair is started" />
                                                                                        </ValidationSettings>
                                                                                        <ClientSideEvents Validation="onCheckBoxValidation"  ValueChanged="onCheckedChange" />
                                                                                    </dx:ASPxCheckBox>
                                                                                </dx:LayoutItemNestedControlContainer>
                                                                            </LayoutItemNestedControlCollection>
                                                                        </dx:LayoutItem>
                                                                    </Items>
                                                                </dx:LayoutGroup>
                                                            </Items>
                                                        </dx:ASPxFormLayout>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                        </Items>
                                    </dx:LayoutGroup>
                                    <dx:LayoutGroup Caption="" ColumnCount="3" ColSpan="1" Width="100%" GroupBoxDecoration="None" ShowCaption="False">
                                        <GridSettings StretchLastItem="true" WrapCaptionAtWidth="660">
                                            <Breakpoints>
                                                <dx:LayoutBreakpoint MaxWidth="500" ColumnCount="1" Name="S" />
                                                <dx:LayoutBreakpoint MaxWidth="800" ColumnCount="2" Name="M" />
                                            </Breakpoints>
                                        </GridSettings>
                                        <Items>
                                            <dx:LayoutItem CssClass="lastItem" ShowCaption="False" ColSpan="1" VerticalAlign="Middle" HorizontalAlign="Left">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                        <dx:ASPxButton runat="server" AutoPostBack="False" ClientInstanceName="btnNextHome" Text="Next Page" ValidationGroup="groupHome" ID="btnNextHome">
                                                            <ClientSideEvents Click="OnNextClick"></ClientSideEvents>
                                                        </dx:ASPxButton>

                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>

                                                <Paddings PaddingTop="20px"></Paddings>
                                                <SpanRules>
                                                    <dx:SpanRule BreakpointName="s" ColumnSpan="1" RowSpan="1"></dx:SpanRule>
                                                    <dx:SpanRule BreakpointName="m" ColumnSpan="2" RowSpan="1"></dx:SpanRule>
                                                </SpanRules>
                                            </dx:LayoutItem>
                                        </Items>
                                        <Items>
                                        </Items>
                                    </dx:LayoutGroup>
                                </Items>
                                <SettingsItems Width="100%"></SettingsItems>
                            </dx:ASPxFormLayout>
                        </div>
                        
                        <asp:SqlDataSource runat="server" ID="SqlDataSource2" ConnectionString='<%$ ConnectionStrings: DefaultConnection %>'
                        SelectCommand="SELECT wo.WORKORDER, wo.DATELOGGED, wo.CALLINNAME, wo.JOBSITENO, wo.WODESCRIP, wo.CUSTOMER, wo.COMMENT, wo.TenantLastName, wo.FOUNDWHAT, wo.TenantFirstName, js.City, wo.TenantLastName + ', ' + wo.TenantFirstName as FullName, js.Address1, js.Address2, js.State, js.ZipCode, js.Code, com.Complex FROM WORKORDR AS wo LEFT OUTER JOIN JobSite AS js ON wo.JOBSITENO = js.JobSiteNo inner join Complex as com on com.Code = js.Code WHERE [WorkOrder]= @WORKORDER ORDER BY wo.WORKORDER"
                            UpdateCommand="UPDATE [WorkOrdr] SET [FOUNDWHAT] = @FOUNDWHAT where [WorkOrder] = @WORKORDER">
                            <SelectParameters>
                                <asp:ControlParameter Name="WORKORDER" ControlID="ctl00$LeftPanel$LeftPanelContent$WOSelected" DefaultValue="-1" PropertyName="Value" Type="STRING"></asp:ControlParameter>
                            </SelectParameters>
                            <UpdateParameters>
                                <asp:ControlParameter Name="WORKORDER" ControlID="ctl00$LeftPanel$LeftPanelContent$WOSelected" DefaultValue="-1" PropertyName="Value" Type="STRING"></asp:ControlParameter>
                                <asp:ControlParameter Name="FOUNDWHAT" ControlID="ASPxFormLayout1$FOUNDWHATMemo" Type="String"></asp:ControlParameter>
                            </UpdateParameters>
                        </asp:SqlDataSource>

                        <asp:SqlDataSource runat="server" ID="chkBoxDS" ConnectionString='<%$ ConnectionStrings: DefaultConnection %>'
                            SelectCommand="Select * from BMODWiz where WorkOrder=@WORKORDER">
<%--                            UpdateCommand="UPDATE [dbo].[BMODWiz]    SET [WorkOrder] = @WorkOrder ,[WOStarted] = @WOStarted,[WoStartedRecordDate] = @WoStartedRecordDate,[woStartedUpdateDate] = @woStartedUpdateDate,[woStartedUpdateBy] = @woStartedUpdateBy,[APTaken] = @APTaken,[APRecordDate] = @APRecordDate,[APUpdateDate] = @APUpdateDate,[APUpdateBy] = @APUpdateBy,[Inspected] = @Inspected,[InspectedRecordDate] = @InspectedRecordDate,[InspectedUpdateDate] = @InspectedUpdateDate,[InspectedUpdateBy] = @InspectedUpdateBy WHERE ChkID = @ChkID">--%>
                            <SelectParameters>
                                <asp:ControlParameter Name="WORKORDER" ControlID="ctl00$LeftPanel$LeftPanelContent$WOSelected" DefaultValue="-1" PropertyName="Value" Type="STRING"></asp:ControlParameter>
                            </SelectParameters>
                            <UpdateParameters>
                                <asp:ControlParameter Name="WORKORDER" ControlID="ctl00$LeftPanel$LeftPanelContent$WOSelected" DefaultValue="-1" PropertyName="Value" Type="STRING"></asp:ControlParameter>
                                <asp:ControlParameter Name="WOStarted" ControlID="chkBoxASPxFormLayout$chkWOStarted" Type="String"></asp:ControlParameter>
                                <asp:Parameter Name="WoStartedRecordDate" Type="DateTime"></asp:Parameter>
                                <asp:Parameter Name="woStartedUpdateDate" Type="DateTime"></asp:Parameter>
                                <asp:Parameter Name="woStartedUpdateBy" Type="String"></asp:Parameter>
                                <asp:ControlParameter Name="APTaken" ControlID="chkBoxASPxFormLayout$chkAddressPicture" Type="String"></asp:ControlParameter>
                                <asp:Parameter Name="APRecordDate" Type="DateTime"></asp:Parameter>
                                <asp:Parameter Name="APUpdateDate" Type="DateTime"></asp:Parameter>
                                <asp:Parameter Name="APUpdateBy" Type="String"></asp:Parameter>
                                <asp:ControlParameter Name="Inspected" ControlID="chkBoxASPxFormLayout$chkInspected" Type="String"></asp:ControlParameter>
                                <asp:Parameter Name="InspectedRecordDate" Type="DateTime"></asp:Parameter>
                                <asp:Parameter Name="InspectedUpdateDate" Type="DateTime"></asp:Parameter>
                                <asp:Parameter Name="InspectedUpdateBy" Type="String"></asp:Parameter>

                            </UpdateParameters>

                            <InsertParameters>
                                <asp:ControlParameter Name="WORKORDER" ControlID="ctl00$LeftPanel$LeftPanelContent$WOSelected" DefaultValue="-1" PropertyName="Value" Type="STRING"></asp:ControlParameter>
                                <asp:ControlParameter Name="WOStarted" ControlID="chkBoxASPxFormLayout$chkWOStarted" Type="String"></asp:ControlParameter>
                                <asp:Parameter Name="WoStartedRecordDate" Type="DateTime"></asp:Parameter>
                                <asp:Parameter Name="woStartedUpdateDate" Type="DateTime"></asp:Parameter>
                                <asp:Parameter Name="woStartedUpdateBy" Type="String"></asp:Parameter>
                                <asp:ControlParameter Name="APTaken" ControlID="chkBoxASPxFormLayout$chkAddressPicture" Type="String"></asp:ControlParameter>
                                <asp:Parameter Name="APRecordDate" Type="DateTime"></asp:Parameter>
                                <asp:Parameter Name="APUpdateDate" Type="DateTime"></asp:Parameter>
                                <asp:Parameter Name="APUpdateBy" Type="String"></asp:Parameter>
                                <asp:ControlParameter Name="Inspected" ControlID="chkBoxASPxFormLayout$chkInspected" Type="String"></asp:ControlParameter>
                                <asp:Parameter Name="InspectedRecordDate" Type="DateTime"></asp:Parameter>
                                <asp:Parameter Name="InspectedUpdateDate" Type="DateTime"></asp:Parameter>
                                <asp:Parameter Name="InspectedUpdateBy" Type="String"></asp:Parameter>
                            </InsertParameters>
                        </asp:SqlDataSource>



                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
            <%--    Work Performed Tab--%>
            <dx:TabPage Text="Work Performed" Name="WorkPerformed">
                <ContentCollection>
                    <dx:ContentControl ID="ContentControl2" runat="server">
                        <%--<div class="tabpage-content-area">--%>
                        <uc:WorkDetails ID="ucWorkDeatils" runat="server"></uc:WorkDetails>
                        <%--</div>--%>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>

            <%--    Need To Return Tab--%>
            <dx:TabPage Text="Need To Return" Name="NTR">
                <ContentCollection>
                    <dx:ContentControl ID="ContentControl9" runat="server">
                        <div class="tabpage-content-area">
                            <uc:NeedToReturn ID="ucNeedToReturn" runat="server"></uc:NeedToReturn>
                        </div>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>

            <%--   Stock Used Tab--%>
            <dx:TabPage Text="Stock Used" Name="StockUsed">
                <ContentCollection>
                    <dx:ContentControl ID="ContentControl3" runat="server">
                        <uc:StockUsed ID="ucStockUsed" runat="server"></uc:StockUsed>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>

            <%--      Receipts Tab--%>
            <dx:TabPage Text="Receipts" Name="Receipts">
                <ContentCollection>
                    <dx:ContentControl ID="ContentControl7" runat="server">
                        <uc:Receipts ID="ucReceipts" runat="server"></uc:Receipts>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>

            <%--      Debris Disposal Tab--%>
            <dx:TabPage Text="Debris Disposal" Name="DebrisDisposal">
                <ContentCollection>
                    <dx:ContentControl ID="ContentControl8" runat="server">
                        <uc:DebrisDisposalDetails ID="ucDisposalDetails" runat="server"></uc:DebrisDisposalDetails>
                    </dx:ContentControl>

                </ContentCollection>
            </dx:TabPage>

            <%--      Equipment Used Tab--%>
            <dx:TabPage Text="Equipment Used" Name="EquipmentUsed">
                <ContentCollection>
                    <dx:ContentControl ID="ContentControl77">
                        <uc:EquipmentDetails ID="ucEquipmentDetails" runat="server"></uc:EquipmentDetails>

                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>

            <%--      Wrap Up Tab--%>
            <dx:TabPage Text="Wrap Up" Name="WrapUp">
                <ContentCollection>
                    <dx:ContentControl ID="ContentControl4" runat="server">
                        <uc:WrapUp ID="WrapUp" runat="server" />
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
            <dx:TabPage Text="Attributes" Name="Attributes">
                <ContentCollection>
                    <dx:ContentControl ID="ContentControl5" runat="server">
                        <uc:ComplexAttributes ID="ucComplexAttributes" runat="server" />
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>

        </TabPages>
    </dx:ASPxPageControl>
</asp:Content>
