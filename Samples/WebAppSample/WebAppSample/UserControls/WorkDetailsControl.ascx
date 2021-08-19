<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WorkDetailsControl.ascx.cs" Inherits="BMOD.UserControls.WorkDeatilsControl" %>
<%@ Register Assembly="DevExpress.Web.v20.2, Version=20.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<script>
    var postponedCallbackRequired = false;
    function WorkDetailOnCheckedChange(s, e) {
        if (workDetailsCallbackPanel.InCallback())
            postponedCallbackRequired = true;
        else
            workDetailsCallbackPanel.PerformCallback();
    }
    function OnWorkDetailsPanelEndCallback(s, e) {
        if (postponedCallbackRequired) {
            //workDetailsCallbackPanel.PerformCallback();
            postponedCallbackRequired = false;
        }
    }
</script>



<dx:ASPxGridView ID="grdWorkPerformed" runat="server" AutoGenerateColumns="False" KeyFieldName="ID"
    CssClass="grid-view"
    ClientInstanceName="grdWorkPerformed"
    OnInitNewRow="WorkPerformedASPxGridView_InitNewRow" OnCellEditorInitialize="WorkPerformedASPxGridView_CellEditorInitialize"
    OnRowUpdating="WorkPerformedASPxGridView_RowUpdating"
    OnRowUpdated="WorkPerformedASPxGridView_RowUpdated"
    OnRowInserting="WorkPerformedASPxGridView_RowInserting"
    OnRowDeleting="WorkPerformedASPxGridView_RowDeleting"
    OnRowValidating="WorkPerformedASPxGridView_RowValidating"
    OnCommandButtonInitialize="WorkPerformedASPxGridView_CommandButtonInitialize"
    DataSourceID="WorkPerformedDS"
    Width="100%" OnCustomUnboundColumnData="WorkPerformedASPxGridView_CustomUnboundColumnData" OnCustomCallback="WorkPerformedASPxGridView_CustomCallback">
    <Settings VerticalScrollableHeight="400" />
    <SettingsPager PageSize="2" Visible="true">
        <PageSizeItemSettings Visible="true" ShowAllItem="true" />
    </SettingsPager>
    <SettingsAdaptivity AdaptivityMode="HideDataCells" AllowOnlyOneAdaptiveDetailExpanded="true"
        AllowHideDataCellsByColumnMinWidth="true">
    </SettingsAdaptivity>
    <SettingsBehavior AllowEllipsisInText="true"
        ConfirmDelete="true" />
    <SettingsPopup>
        <FilterControl AutoUpdatePosition="False"></FilterControl>
    </SettingsPopup>
    <EditFormLayoutProperties ColCount="2" ColumnCount="2">
        <Paddings Padding="0" />
        <Items>
            <dx:GridViewLayoutGroup Caption="Work Performed">
                <Paddings Padding="0" />
                <ParentContainerStyle>
                    <Paddings Padding="0" />
                </ParentContainerStyle>

                <SpanRules>
                    <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="S"></dx:SpanRule>
                    <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="M"></dx:SpanRule>
                </SpanRules>
                <Items>
                    <dx:GridViewColumnLayoutItem ColumnName="DIDWHAT" Caption=""></dx:GridViewColumnLayoutItem>
                </Items>
            </dx:GridViewLayoutGroup>
            <dx:GridViewLayoutGroup Caption="Time">
                <Paddings Padding="0" />
                <ParentContainerStyle>
                    <Paddings Padding="0" />
                </ParentContainerStyle>
                <SpanRules>
                    <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="S"></dx:SpanRule>
                    <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="M"></dx:SpanRule>
                </SpanRules>
                <Items>
                    <dx:GridViewColumnLayoutItem ColumnName="RWorkClass" Caption="Classification"></dx:GridViewColumnLayoutItem>
                    <dx:GridViewColumnLayoutItem ColumnName="WKTIME_IN" Caption="Time In"></dx:GridViewColumnLayoutItem>
                    <dx:GridViewColumnLayoutItem ColumnName="Time Off"></dx:GridViewColumnLayoutItem>
                    <dx:GridViewColumnLayoutItem ColumnName="WKTIME_OUT" Caption="Time Out"></dx:GridViewColumnLayoutItem>
                    <dx:GridViewColumnLayoutItem ColumnName="TOTTIME"></dx:GridViewColumnLayoutItem>
                </Items>
            </dx:GridViewLayoutGroup>
            <dx:EditModeCommandLayoutItem HorizontalAlign="Right" ColumnSpan="2">
                <Paddings Padding="0" />
                <ParentContainerStyle>
                    <Paddings Padding="0" />
                </ParentContainerStyle>
                <SpanRules>
                    <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="S"></dx:SpanRule>
                    <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="M"></dx:SpanRule>
                </SpanRules>
            </dx:EditModeCommandLayoutItem>
        </Items>
        <SettingsAdaptivity AdaptivityMode="SingleColumnWindowLimit" SwitchToSingleColumnAtWindowInnerWidth="768">
            <GridSettings StretchLastItem="true" ChangeCaptionLocationAtWidth="660">
                <Breakpoints>
                    <dx:LayoutBreakpoint MaxWidth="500" ColumnCount="1" Name="S" />
                    <dx:LayoutBreakpoint MaxWidth="800" ColumnCount="1" Name="M" />
                </Breakpoints>
            </GridSettings>
        </SettingsAdaptivity>
    </EditFormLayoutProperties>
    <SettingsEditing Mode="EditForm"></SettingsEditing>
    <Columns>
        <dx:GridViewCommandColumn ShowDeleteButton="True" VisibleIndex="0" ShowNewButtonInHeader="True" ShowEditButton="True"
            MinWidth="115" MaxWidth="120" Width="20%" AdaptivePriority="0">
        </dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn FieldName="ID" ReadOnly="True" VisibleIndex="1" Visible="false">
            <EditFormSettings Visible="False"></EditFormSettings>
        </dx:GridViewDataTextColumn>
        <%--        <dx:GridViewDataDateColumn FieldName="DATE" VisibleIndex="2" Caption="Work Date" SortOrder="Descending" SortIndex="0"
             AdaptivePriority="0">--%>
        <dx:GridViewDataDateColumn FieldName="DATE" VisibleIndex="2" Caption="Work Date" SortOrder="Descending" SortIndex="0"
            MinWidth="90" MaxWidth="110" Width="20%" AdaptivePriority="0">
            <EditFormSettings Visible="False" />
        </dx:GridViewDataDateColumn>
        <dx:GridViewDataComboBoxColumn FieldName="WHOWORKED" VisibleIndex="3" Caption="EmpNum" Visible="false">
            <PropertiesComboBox DataSourceID="whoWorkedDS" ValueType="System.String" ValueField="EmpNum"
                TextField="FullName" />
            <EditFormSettings Visible="False" />
        </dx:GridViewDataComboBoxColumn>
        <dx:GridViewDataTextColumn FieldName="WorkOrder" VisibleIndex="4" Caption="Work Order" Visible="false">
            <EditFormSettings Visible="False" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataMemoColumn FieldName="DIDWHAT" Caption="Work Performed" VisibleIndex="6" Visible="True"
            AllowTextTruncationInAdaptiveMode="true" MinWidth="120" Width="60%" AdaptivePriority="1">
            <PropertiesMemoEdit Rows="20" />
        </dx:GridViewDataMemoColumn>
        <%--        <dx:GridViewDataMemoColumn FieldName="DIDWHAT" VisibleIndex="6"  Visible="True" 
            AllowTextTruncationInAdaptiveMode="true" MinWidth="100" Width="60%" AdaptivePriority="1">
            <PropertiesMemoEdit Rows="20" />
        </dx:GridViewDataMemoColumn>--%>
        <dx:GridViewDataTextColumn FieldName="LASTNAME" VisibleIndex="7" Caption="Last Name" Visible="False">
            <EditFormSettings Visible="False" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="FIRSTNAME" VisibleIndex="8" Caption="First Name" Visible="False">
            <EditFormSettings Visible="False" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTimeEditColumn FieldName="WKTIME_IN" VisibleIndex="9" Caption="WKTime In"
            PropertiesTimeEdit-ClientSideEvents-Validation="OnQtrHrValidation"
            PropertiesTimeEdit-ValidationSettings-EnableCustomValidation="true" Visible="False">
            <PropertiesTimeEdit ClientInstanceName="workTimeIn" Width="200">
                <%--<PropertiesTimeEdit Width="150px" ClientInstanceName="workTimeIn">--%>
                <ClientSideEvents Validation="OnQtrHrValidation"
                    ValueChanged="setTotTime" Init="OnTimeEditorInit" ButtonClick="OnTimeButtonClick"></ClientSideEvents>
                <ValidationSettings EnableCustomValidation="True" ErrorDisplayMode="ImageWithText" Display="Dynamic" ErrorTextPosition="Bottom">
                    <RequiredField IsRequired="true" ErrorText="Time must end in '00, 15, 30, 45' Minutes" />
                </ValidationSettings>
            </PropertiesTimeEdit>
            <EditFormSettings Visible="True"></EditFormSettings>
        </dx:GridViewDataTimeEditColumn>
        <dx:GridViewDataTextColumn FieldName="TIMEOFF" VisibleIndex="10" Caption="Time Off" Visible="False">
            <EditFormSettings Visible="True" />
            <PropertiesTextEdit Width="200">
                <ClientSideEvents Validation="OnDecimalHrValidation"
                    ValueChanged="setTotTime"></ClientSideEvents>
                <ValidationSettings EnableCustomValidation="True" ErrorDisplayMode="ImageWithText" Display="Dynamic" ErrorTextPosition="Bottom">
                    <RequiredField IsRequired="true" ErrorText="Time must end in '00, 25, 50, 75' Minutes" />
                </ValidationSettings>

                <MaskSettings Mask="<0..9999999g>.<99>" PromptChar="0" />
            </PropertiesTextEdit>
        </dx:GridViewDataTextColumn>

        <dx:GridViewDataTimeEditColumn FieldName="WKTIME_OUT" VisibleIndex="11" Caption="WKTIME OUT" Visible="False">
            <PropertiesTimeEdit ClientInstanceName="workTimeOut" Width="200">
                <ClientSideEvents Validation="OnQtrHrValidation" ValueChanged="setTotTime" Init="OnTimeEditorInit" ButtonClick="OnTimeButtonClick"></ClientSideEvents>
                <ValidationSettings EnableCustomValidation="True" ErrorDisplayMode="ImageWithText" Display="Dynamic" ErrorTextPosition="Bottom">
                    <RequiredField IsRequired="true" ErrorText="Time must end in '00, 15, 30, 45' Minutes" />
                </ValidationSettings>
            </PropertiesTimeEdit>
            <EditFormSettings Visible="True"></EditFormSettings>
        </dx:GridViewDataTimeEditColumn>

        <dx:GridViewDataTextColumn FieldName="TOTTIME" VisibleIndex="5" Caption="Hours"
            AdaptivePriority="0" MinWidth="80" MaxWidth="120" Width="20%">
            <PropertiesTextEdit ClientInstanceName="workTotalTime" Width="200"
                DisplayFormatString="g">
                <MaskSettings Mask="<0..9999999g>.<99>" PromptChar="0" />
                <ValidationSettings Display="Dynamic" ErrorTextPosition="Bottom"></ValidationSettings>
            </PropertiesTextEdit>
        </dx:GridViewDataTextColumn>

        <dx:GridViewDataTextColumn FieldName="AMOUNT" VisibleIndex="12" Caption="Amount" Visible="False">
            <EditFormSettings Visible="False" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataComboBoxColumn FieldName="WORKTYPE" VisibleIndex="13" Caption="Work Type" Visible="False">
            <PropertiesComboBox DataSourceID="workTypeDS" ValueType="System.String" ValueField="Abreviate"
                TextField="WORKTYPE" />
        </dx:GridViewDataComboBoxColumn>
        <dx:GridViewDataTimeEditColumn FieldName="OWKTIME_IN" VisibleIndex="14" Caption="OWKTIME_IN" Visible="False">
            <PropertiesTimeEdit Width="150px" ClientInstanceName="workOverTimeIn">
                <ClientSideEvents Validation="OnQtrHrValidation" ValueChanged="WorkOverTimeInValueChanged"></ClientSideEvents>
                <ValidationSettings EnableCustomValidation="True"></ValidationSettings>
            </PropertiesTimeEdit>
        </dx:GridViewDataTimeEditColumn>
        <dx:GridViewDataTimeEditColumn FieldName="OWKTIME_OUT" VisibleIndex="15" Caption="OWKTIME_OUT" Visible="False">
            <PropertiesTimeEdit Width="150px" ClientInstanceName="workOverTimeOut">
                <ClientSideEvents Validation="OnQtrHrValidation" ValueChanged="WorkOverTimeOutValueChanged"></ClientSideEvents>
                <ValidationSettings EnableCustomValidation="True" Display="Dynamic"></ValidationSettings>
            </PropertiesTimeEdit>
        </dx:GridViewDataTimeEditColumn>
        <dx:GridViewDataTextColumn FieldName="OTIMEOFF" VisibleIndex="16" Caption="OTIMEOFF" Visible="False">
            <PropertiesTextEdit>
                <MaskSettings Mask="<0..9999999g>.<99>" PromptChar="0" />
            </PropertiesTextEdit>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="OTOTTIME" VisibleIndex="17" Caption="OT Total Time" Visible="false"></dx:GridViewDataTextColumn>
        <dx:GridViewDataComboBoxColumn FieldName="RWorkClass" VisibleIndex="18" Caption="RWorkClass" Visible="False">
            <PropertiesComboBox DataSourceID="wdclassDS" ValueType="System.Int32" ValueField="WorkClassID"
                TextField="WorkClassDescription" />
            <EditFormSettings Visible="True"></EditFormSettings>
        </dx:GridViewDataComboBoxColumn>
        <dx:GridViewDataComboBoxColumn FieldName="OWorkClass" VisibleIndex="19" Caption="OWorkClass" Visible="False">
            <PropertiesComboBox DataSourceID="wdclassDS" ValueType="System.Int32" ValueField="WorkClassID"
                TextField="WorkClassDescription" />
        </dx:GridViewDataComboBoxColumn>
        <dx:GridViewDataCheckColumn FieldName="DOUBLETIME" VisibleIndex="20" Caption="DOUBLETIME" Visible="False">
        </dx:GridViewDataCheckColumn>
        <dx:GridViewDataDateColumn FieldName="DATEIN" VisibleIndex="21" Caption="DATEIN" Visible="False"></dx:GridViewDataDateColumn>
        <dx:GridViewDataDateColumn FieldName="PAYWEEK_DATE" VisibleIndex="22" Caption="PAYWEEK_DATE" Visible="False">
            <EditFormSettings Visible="False" />
        </dx:GridViewDataDateColumn>
        <dx:GridViewDataTextColumn FieldName="emp_rate" VisibleIndex="23" Caption="emp_rate" Visible="false">
            <EditFormSettings Visible="False" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="oamount" VisibleIndex="24" Caption="oamount" Visible="False">
            <EditFormSettings Visible="False" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ramount" VisibleIndex="25" Caption="ramount" Visible="False">
            <EditFormSettings Visible="False" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="EmployeeFactor" VisibleIndex="26" Caption="EmployeeFactor" Visible="False">
            <EditFormSettings Visible="False" />
        </dx:GridViewDataTextColumn>


        <dx:GridViewDataTextColumn Caption="Total Emp Hours" Name="colTotalEmpHours" Visible="false" ReadOnly="True" VisibleIndex="27">
        </dx:GridViewDataTextColumn>


    </Columns>
    <Settings ShowPreview="false" />
    <SettingsPopup>
        <EditForm Width="1200">
            <SettingsAdaptivity Mode="OnWindowInnerWidth" SwitchAtWindowInnerWidth="768" />
        </EditForm>

        <FilterControl AutoUpdatePosition="False"></FilterControl>
    </SettingsPopup>
</dx:ASPxGridView>

<%--<dx:ASPxCallbackPanel runat="server" ID="workDetailsCallbackPanel" ClientInstanceName="workDetailsCallbackPanel" RenderMode="Table"
    OnCallback="workDetailsCallbackPanel_Callback">
    <ClientSideEvents EndCallback="OnWorkDetailsPanelEndCallback"></ClientSideEvents>
    <PanelCollection>
        <dx:PanelContent ID="PanelContent3" runat="server">--%>
            <dx:ASPxFormLayout ID="WorkPerformWizASPxFormLayout" runat="server" Width="100%" AlignItemCaptionsInAllGroups="True"
               DataSourceID="WorkPerformedChkBoxDS" UseDefaultPaddings="false" CssClass="formLayout1" Paddings-PaddingTop="20px">
                <Items>
                    <dx:LayoutGroup Caption="Check List" ColumnCount="4" ColSpan="1" Width="100%">
                        <GridSettings StretchLastItem="true" WrapCaptionAtWidth="660">
                            <Breakpoints>
                                <dx:LayoutBreakpoint MaxWidth="500" ColumnCount="1" Name="S" />
                                <dx:LayoutBreakpoint MaxWidth="800" ColumnCount="2" Name="M" />
                            </Breakpoints>
                        </GridSettings>
                        <Items>

                            <dx:LayoutItem ShowCaption="True" Caption="Before Picture Taken" VerticalAlign="Middle" ColumnSpan="1"
                                FieldName="BPTaken">
                                <SpanRules>
                                    <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="S"></dx:SpanRule>
                                    <dx:SpanRule ColumnSpan="2" RowSpan="1" BreakpointName="M"></dx:SpanRule>
                                </SpanRules>
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer>
                                        <dx:ASPxCheckBox runat="server" ID="BeforePicturesASPxCheckBox" ClientInstanceName="BeforePicturesASPxCheckBox"
                                            AutoPostBack="false">
                                            <%--                                <ClientSideEvents Validation="onCheckBoxValidation" />--%>
                                            <ValidationSettings SetFocusOnError="True" ValidationGroup="groupWorkPerformed" ErrorTextPosition="Bottom">
                                                <RequiredField IsRequired="True" ErrorText="Before Pictures are required" />
                                            </ValidationSettings>
                                            <ClientSideEvents Validation="onCheckBoxValidation" CheckedChanged="onCheckedChange" />
                                        </dx:ASPxCheckBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:LayoutItem ShowCaption="true" FieldName="AfterPic" Caption="After Pictures" VerticalAlign="Middle" ColumnSpan="1">
                                <SpanRules>
                                    <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="S"></dx:SpanRule>
                                    <dx:SpanRule ColumnSpan="2" RowSpan="1" BreakpointName="M"></dx:SpanRule>
                                </SpanRules>
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer>
                                        <dx:ASPxCheckBox runat="server" ID="AfterPicturesASPxCheckBox" ClientInstanceName="AfterPicturesASPxCheckBox" AutoPostBack="false">
                                            <ClientSideEvents Validation="onCheckBoxValidation" CheckedChanged="onCheckedChange" />
                                            <ValidationSettings SetFocusOnError="True" ValidationGroup="groupWorkPerformed" ErrorTextPosition="Bottom">
                                                <RequiredField IsRequired="True" ErrorText="After Pictures are required" />
                                            </ValidationSettings>
                                        </dx:ASPxCheckBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:LayoutItem ShowCaption="True" FieldName="SiteCleaned" Caption="Site Cleaned Up" VerticalAlign="Middle" ColumnSpan="1">
                                <SpanRules>
                                    <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="S"></dx:SpanRule>
                                    <dx:SpanRule ColumnSpan="2" RowSpan="1" BreakpointName="M"></dx:SpanRule>
                                </SpanRules>
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer>
                                        <dx:ASPxCheckBox runat="server" ID="SiteCleanedWPASPxCheckBox" ClientInstanceName="SiteCleanedWPASPxCheckBox" AutoPostBack="false">
                                            <ClientSideEvents Validation="onCheckBoxValidation" CheckedChanged="onCheckedChange" />
                                            <ValidationSettings SetFocusOnError="True" ValidationGroup="groupWorkPerformed" ErrorTextPosition="Bottom">
                                                <RequiredField IsRequired="True" ErrorText="Site Cleanup confirmed" />
                                            </ValidationSettings>
                                        </dx:ASPxCheckBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:LayoutItem ShowCaption="True" FieldName="WorkPerformed" Caption="Work Performed Recorded" VerticalAlign="Middle" ColumnSpan="1">
                                <SpanRules>
                                    <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="S"></dx:SpanRule>
                                    <dx:SpanRule ColumnSpan="2" RowSpan="1" BreakpointName="M"></dx:SpanRule>
                                </SpanRules>
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer>
                                        <dx:ASPxCheckBox runat="server" ID="WorkPerformedWPASPxCheckBox" ClientInstanceName="WorkPerformedWPASPxCheckBox" AutoPostBack="false">
                                            <ClientSideEvents Validation="onCheckBoxValidation" CheckedChanged="onCheckedChange" />
                                            <ValidationSettings SetFocusOnError="True" ValidationGroup="groupWorkPerformed" ErrorTextPosition="Bottom">
                                                <RequiredField IsRequired="True" ErrorText="Recorded Work Performed?" />
                                            </ValidationSettings>
                                        </dx:ASPxCheckBox>
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
                                        <dx:ASPxButton runat="server" ID="btnPrevWorkPerformedASPxButton" ClientInstanceName="btnPrevWorkPerformed" Text="Prev Page" AutoPostBack="false" ValidationGroup="groupWorkPerformed">
                                            <ClientSideEvents Click="OnBackClick" />
                                        </dx:ASPxButton>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:EmptyLayoutItem>
                                <SpanRules>
                                    <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="S"></dx:SpanRule>
                                    <dx:SpanRule ColumnSpan="2" RowSpan="1" BreakpointName="M"></dx:SpanRule>
                                </SpanRules>
                            </dx:EmptyLayoutItem>
                            <dx:EmptyLayoutItem>
                                <SpanRules>
                                    <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="S"></dx:SpanRule>
                                    <dx:SpanRule ColumnSpan="2" RowSpan="1" BreakpointName="M"></dx:SpanRule>
                                </SpanRules>
                            </dx:EmptyLayoutItem>
                            <dx:LayoutItem ShowCaption="False" HorizontalAlign="Left" VerticalAlign="Middle" Paddings-PaddingTop="20px" CssClass="lastItem">
                                <Paddings PaddingTop="20px"></Paddings>
                                <SpanRules>
                                    <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="S"></dx:SpanRule>
                                    <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="M"></dx:SpanRule>
                                </SpanRules>
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer>
                                        <dx:ASPxButton runat="server" ID="WorkPerformedWPASPxButton" ClientInstanceName="btnNextWorkPerformed" Text="Next Page" AutoPostBack="false" ValidationGroup="groupWorkPerformed">
                                            <ClientSideEvents Click="OnNextClick" />
                                        </dx:ASPxButton>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                        </Items>
                    </dx:LayoutGroup>
                </Items>

                <SettingsItemHelpTexts Position="Bottom" />

                <Paddings PaddingTop="20px"></Paddings>
            </dx:ASPxFormLayout>
<%--        </dx:PanelContent>
    </PanelCollection>
</dx:ASPxCallbackPanel>--%>
<asp:SqlDataSource runat="server" ID="WorkPerformedDS" ConnectionString='<%$ ConnectionStrings:DefaultConnection %>'
    SelectCommand="uspGetWorkPerformed" SelectCommandType="StoredProcedure"
    UpdateCommand="uspUpDateWorkPerformed" UpdateCommandType="StoredProcedure"
    InsertCommand="uspInsertWorkPerformed" InsertCommandType="StoredProcedure"
    DeleteCommand="uspDeleteWorkPerformed" DeleteCommandType="StoredProcedure">

    <SelectParameters>
        <asp:ControlParameter ControlID="ctl00$LeftPanel$LeftPanelContent$WOSelected" PropertyName="Value" DefaultValue="-1" Name="WorkOrder" Type="String"></asp:ControlParameter>
    </SelectParameters>

    <UpdateParameters>
        <asp:ControlParameter ControlID="ctl00$LeftPanel$LeftPanelContent$WOSelected" PropertyName="Value" DefaultValue="-1" Name="WorkOrder" Type="String"></asp:ControlParameter>
    </UpdateParameters>

    <InsertParameters>
        <asp:Parameter Name="Date" Type="DateTime" />
        <asp:Parameter Name="DATEIN" Type="DateTime" />
        <asp:Parameter Name="WHOWORKED" Type="String" />
        <asp:ControlParameter ControlID="ctl00$LeftPanel$LeftPanelContent$WOSelected" PropertyName="Value" DefaultValue="-1" Name="WorkOrder" Type="String"></asp:ControlParameter>
        <asp:Parameter Name="WKTIME_IN" Type="DateTime" />
        <asp:Parameter Name="TIMEOFF" Type="Double" />
        <asp:Parameter Name="WKTIME_OUT" Type="DateTime" />
        <asp:Parameter Name="TOTTIME" Type="Double" />
        <asp:Parameter Name="AMOUNT" Type="Double" />
        <asp:Parameter Name="WORKTYPE" Type="String" />
        <asp:Parameter Name="DIDWHAT" Type="String" />
        <asp:Parameter Name="OWKTIME_IN" Type="DateTime" />
        <asp:Parameter Name="OWKTIME_OUT" Type="DateTime" />
        <asp:Parameter Name="OTIMEOFF" Type="Double" DefaultValue="0" />
        <asp:Parameter Name="OTOTTIME" Type="Double" DefaultValue="0" />
        <asp:Parameter Name="RWorkClass" Type="String" />
        <asp:Parameter Name="OWorkClass" Type="String" />
        <asp:Parameter Name="DOUBLETIME" Type="Boolean" />
        <asp:Parameter Name="PAYWEEK_DATE" Type="DateTime" />
        <asp:Parameter Name="emp_rate" Type="Double" />
        <asp:Parameter Name="oamount" Type="Double" />
        <asp:Parameter Name="ramount" Type="Double" />
        <asp:Parameter Name="EmployeeFactor" Type="Int32" />
        <asp:Parameter Name="recorddate" Type="DateTime" />
        <asp:Parameter Name="updatedate" Type="DateTime" />
        <asp:Parameter Name="updateby" Type="String" />
    </InsertParameters>

    <DeleteParameters>
        <asp:ControlParameter ControlID="ctl00$LeftPanel$LeftPanelContent$WOSelected" PropertyName="Value" DefaultValue="-1" Name="WorkOrder" Type="String"></asp:ControlParameter>
    </DeleteParameters>

</asp:SqlDataSource>
<asp:SqlDataSource runat="server" ID="wdclassDS" ConnectionString='<%$ ConnectionStrings:DefaultConnection %>'
    SelectCommand=" Select * from wdClass order by SeqNo" SelectCommandType="Text"></asp:SqlDataSource>

<asp:SqlDataSource runat="server" ID="workTypeDS" ConnectionString='<%$ ConnectionStrings:DefaultConnection %>'
    SelectCommand="Select ABREVIATE, WORKTYPE from WorkType where isActive = 1" SelectCommandType="Text"></asp:SqlDataSource>

<asp:SqlDataSource runat="server" ID="whoWorkedDS" ConnectionString='<%$ ConnectionStrings:DefaultConnection %>'
    SelectCommand="SELECT [EMPNUM] ,[LASTNAME]  +', ' +  [FIRSTNAME]  AS FULLNAME FROM [employee] where active = 1 order by LASTNAME, FIRSTNAME" SelectCommandType="Text"></asp:SqlDataSource>

<asp:SqlDataSource runat="server" ID="WorkPerformedChkBoxDS" ConnectionString='<%$ ConnectionStrings: DefaultConnection %>'
    SelectCommand="Select * from BMODWiz where WorkOrder=@WORKORDER">
    <SelectParameters>
        <asp:ControlParameter Name="WORKORDER" ControlID="ctl00$LeftPanel$LeftPanelContent$WOSelected" DefaultValue="-1" PropertyName="Value" Type="STRING"></asp:ControlParameter>
    </SelectParameters>    
</asp:SqlDataSource>

