<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="StockUsedControl.ascx.cs" Inherits="BMOD.UserControls.StockUsedControl" %>
<%@ Register Assembly="DevExpress.Web.v20.2, Version=20.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>


<dx:ASPxGridView ID="grdStockUsed" ClientInstanceName="grdStockUsed" runat="server" AutoGenerateColumns="False"
    Width="100%"
    KeyFieldName="ID"
    OnInitNewRow="StockUsedGrid_InitNewRow"
    OnCellEditorInitialize="StockUsedGrid_CellEditorInitialize"
    OnRowInserting="StockUsedGrid_RowInserting"
    OnRowUpdating="StockUsedGrid_RowUpdating"
    DataSourceID="StockUsedDS">
    <Settings VerticalScrollableHeight="400" />
    <SettingsPager PageSize="4" Visible="true">
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


    <EditFormLayoutProperties AlignItemCaptionsInAllGroups="True" ColCount="2" ColumnCount="2">
        <Items>
            <dx:GridViewColumnLayoutItem ColumnName="Total" ColSpan="1"></dx:GridViewColumnLayoutItem>
            <dx:GridViewColumnLayoutItem ColumnName="Description" ColSpan="1"></dx:GridViewColumnLayoutItem>
            <dx:EditModeCommandLayoutItem ColSpan="2" ColumnSpan="2" HorizontalAlign="Right"></dx:EditModeCommandLayoutItem>
        </Items>

        <SettingsAdaptivity AdaptivityMode="SingleColumnWindowLimit" SwitchToSingleColumnAtWindowInnerWidth="700"></SettingsAdaptivity>
    </EditFormLayoutProperties>
    <Columns>
        <dx:GridViewCommandColumn ShowDeleteButton="True" VisibleIndex="0" ShowNewButtonInHeader="True" ShowEditButton="True" Width="170px"></dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn Name="ID" FieldName="ID" Caption="ID" Visible="false" VisibleIndex="1"></dx:GridViewDataTextColumn>
        <dx:GridViewDataDateColumn Name="Date" FieldName="Date" Caption="Date" Visible="true" VisibleIndex="2" Width="170px">
            <EditFormSettings Visible="false" />
        </dx:GridViewDataDateColumn>
        <dx:GridViewDataMemoColumn Name="Description" FieldName="Item" Caption="Description" VisibleIndex="3">
            <PropertiesMemoEdit Rows="20" Columns="2" />
        </dx:GridViewDataMemoColumn>
        <dx:GridViewDataTextColumn Name="Total" FieldName="Total" Caption="Stock Cost" VisibleIndex="4" Width="170px">
            <PropertiesTextEdit DisplayFormatString="c2">
                <MaskSettings Mask="$<0..9999999g>.<99>" PromptChar="0" IncludeLiterals="DecimalSymbol" />
            </PropertiesTextEdit>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn Name="EmpNum" FieldName="EmpNum" Caption="Employee" Visible="false" VisibleIndex="5"></dx:GridViewDataTextColumn>
    </Columns>

    <Styles>
        <AlternatingRow Enabled="true" />
    </Styles>

</dx:ASPxGridView>


<asp:SqlDataSource ID="StockUsedDS" runat="server" ConnectionString='<%$ ConnectionStrings:DefaultConnection %>'
    SelectCommand="Select ID, WorkOrder, Date, Item, Total,Vendor, EmpNum from Material where WorkOrder = @WorkOrder order by recordDate desc, WorkOrder desc"
    UpdateCommand="UPDATE Material    SET [WorkOrder] =  @WorkOrder, [Item] =  @Item ,[Total] =  @Total,[Vendor] =  'Stock',[EmpNum] =  @EmpNum,[updateby] =  @updateby, [updatedate] =  @updatedate where [ID] = @ID"
    InsertCommand="INSERT INTO [Material] (WorkOrder, Date, Item, Total,Vendor, EmpNum, CleanUp, [recorddate],[updatedate],[updateby]) VALUES (@WorkOrder, @Date, @Item,@Total, 'Stock', @EmpNum, '0', @recorddate, @updatedate, @updateby)"
    DeleteCommand="Delete from Material where ID = @ID">

    <SelectParameters>
        <asp:ControlParameter Name="WORKORDER" ControlID="ctl00$LeftPanel$LeftPanelContent$WOSelected" DefaultValue="-1" PropertyName="Value" Type="STRING"></asp:ControlParameter>
    </SelectParameters>

    <UpdateParameters>
        <asp:ControlParameter Name="WORKORDER" ControlID="ctl00$LeftPanel$LeftPanelContent$WOSelected" DefaultValue="-1" PropertyName="Value" Type="STRING"></asp:ControlParameter>
        <asp:Parameter Name="Date" Type="DATETIME"></asp:Parameter>
        <asp:Parameter Name="ID" Type="Int32"></asp:Parameter>
        <asp:Parameter Name="Item" Type="STRING"></asp:Parameter>
        <asp:Parameter Name="Total" Type="Double"></asp:Parameter>
        <asp:Parameter Name="EmpNum" Type="STRING"></asp:Parameter>
        <asp:Parameter Name="updatedate" Type="DATETIME"></asp:Parameter>
        <asp:Parameter Name="updateby" Type="STRING"></asp:Parameter>
    </UpdateParameters>

    <InsertParameters>
        <asp:ControlParameter Name="WORKORDER" ControlID="ctl00$LeftPanel$LeftPanelContent$WOSelected" DefaultValue="-1" PropertyName="Value" Type="STRING"></asp:ControlParameter>
        <asp:Parameter Name="Date" Type="DATETIME"></asp:Parameter>
        <asp:Parameter Name="Item" Type="STRING"></asp:Parameter>
        <asp:Parameter Name="Total" Type="Double"></asp:Parameter>
        <asp:Parameter Name="EmpNum" Type="STRING"></asp:Parameter>
        <asp:Parameter Name="recorddate" Type="DATETIME"></asp:Parameter>
        <asp:Parameter Name="updatedate" Type="DATETIME"></asp:Parameter>
        <asp:Parameter Name="updateby" Type="STRING"></asp:Parameter>
    </InsertParameters>

    <DeleteParameters>
        <asp:Parameter Name="ID" Type="Int32"></asp:Parameter>
    </DeleteParameters>


</asp:SqlDataSource>


<dx:ASPxFormLayout ID="StockUsedWizASPxFormLayout" runat="server" Width="100%" AlignItemCaptionsInAllGroups="True"
    UseDefaultPaddings="false" CssClass="formLayout1" DataSourceID="StockUsedChkBoxDS">
    <Items>
        <dx:LayoutGroup Caption="Check List" ColumnCount="3" ColSpan="1" Width="100%">
            <GridSettings StretchLastItem="true" WrapCaptionAtWidth="660">
                <Breakpoints>
                    <dx:LayoutBreakpoint MaxWidth="500" ColumnCount="1" Name="S" />
                    <dx:LayoutBreakpoint MaxWidth="800" ColumnCount="2" Name="M" />
                </Breakpoints>
            </GridSettings>
            <Items>
                <dx:LayoutItem ShowCaption="true" FieldName="StockUsed" Caption="Stock Used" VerticalAlign="Middle">
                    <SpanRules>
                        <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="S"></dx:SpanRule>
                        <dx:SpanRule ColumnSpan="2" RowSpan="1" BreakpointName="M"></dx:SpanRule>
                    </SpanRules>
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer>
                            <dx:ASPxCheckBox runat="server" ID="chkStockUsed" ClientInstanceName="chkStockUsed" AutoPostBack="false" 
                                FieldName="StockUsed">
                                <ValidationSettings SetFocusOnError="True" ValidationGroup="groupStockUsed" ErrorTextPosition="Right">
                                    <RequiredField IsRequired="True" ErrorText="Recording Stock Used is required" />
                                </ValidationSettings>
                                <ClientSideEvents Validation="onCheckBoxValidation" CheckedChanged="onCheckedChange" />
                            </dx:ASPxCheckBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>



                <dx:LayoutItem ShowCaption="False" HorizontalAlign="Left" VerticalAlign="Middle" CssClass="lastItem">
                    <SpanRules>
                        <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="S"></dx:SpanRule>
                        <dx:SpanRule ColumnSpan="2" RowSpan="1" BreakpointName="M"></dx:SpanRule>
                    </SpanRules>
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer>
                            <dx:ASPxButton runat="server" ID="StockUsedBackASPxButton" ClientInstanceName="btnPrevStockUsed" Text="Prev Page" AutoPostBack="false" ValidationGroup="groupStockUsed">
                                <ClientSideEvents Click="OnBackClick" />
                            </dx:ASPxButton>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem ShowCaption="False" HorizontalAlign="Left" VerticalAlign="Middle" CssClass="lastItem">
                    <%--<Paddings PaddingTop="20px"></Paddings>--%>
                    <SpanRules>
                        <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="S"></dx:SpanRule>
                        <dx:SpanRule ColumnSpan="2" RowSpan="1" BreakpointName="M"></dx:SpanRule>
                    </SpanRules>
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer>
                            <dx:ASPxButton runat="server" ID="StockUsedWizASPxButton" ClientInstanceName="btnNextStockUsed" Text="Next Page" AutoPostBack="false" ValidationGroup="groupStockUsed">
                                <ClientSideEvents Click="OnNextClick" />
                            </dx:ASPxButton>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
            </Items>
        </dx:LayoutGroup>
    </Items>

    <Paddings PaddingTop="20px"></Paddings>
</dx:ASPxFormLayout>

<asp:SqlDataSource runat="server" ID="StockUsedChkBoxDS" ConnectionString='<%$ ConnectionStrings: DefaultConnection %>'
    SelectCommand="Select * from BMODWiz where WorkOrder=@WORKORDER">
    <SelectParameters>
        <asp:ControlParameter Name="WORKORDER" ControlID="ctl00$LeftPanel$LeftPanelContent$WOSelected" DefaultValue="-1" PropertyName="Value" Type="STRING"></asp:ControlParameter>
    </SelectParameters>    
</asp:SqlDataSource>
