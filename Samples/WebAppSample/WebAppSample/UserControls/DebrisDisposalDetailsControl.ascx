<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DebrisDisposalDetailsControl.ascx.cs" Inherits="BMOD.UserControls.DebrisDisposalDetailsControl" %>
<%@ Register Assembly="DevExpress.Web.v20.2, Version=20.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<dx:ASPxFormLayout ID="DebrisDisposalASPxFormLayout" DataSourceID="DebrisChkBoxDS" runat="server" Width="100%" AlignItemCaptionsInAllGroups="True"
    UseDefaultPaddings="false" CssClass="formLayout1">
    <Items>
        <dx:LayoutGroup Caption="Check List" ColumnCount="3" ColSpan="1" Width="100%">
            <GridSettings StretchLastItem="true" WrapCaptionAtWidth="660">
                <Breakpoints>
                    <dx:LayoutBreakpoint MaxWidth="500" ColumnCount="1" Name="S" />
                    <dx:LayoutBreakpoint MaxWidth="800" ColumnCount="2" Name="M" />
                </Breakpoints>
            </GridSettings>
            <Items>
                <dx:LayoutItem ShowCaption="true" FieldName="StockUsed" Caption="Debris Disposal" VerticalAlign="Middle" Paddings-PaddingTop="20px">
                    <Paddings PaddingTop="20px"></Paddings>
                    <SpanRules>
                        <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="S"></dx:SpanRule>
                        <dx:SpanRule ColumnSpan="2" RowSpan="1" BreakpointName="M"></dx:SpanRule>
                    </SpanRules>
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer>
                            <dx:ASPxCheckBox runat="server" ID="chkDebrisDisposal" ClientInstanceName="chkDebrisDisposal" AutoPostBack="false">
                                <ValidationSettings SetFocusOnError="True" ValidationGroup="groupDebrisDisposal" ErrorTextPosition="Bottom">
                                    <RequiredField IsRequired="True" ErrorText="Recording Disposal Costs is required" />
                                </ValidationSettings>
                                <ClientSideEvents Validation="onCheckBoxValidation" CheckedChanged="onCheckedChange" />
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
                            <dx:ASPxButton runat="server" ID="btnPrevDebrisASPxButton" ClientInstanceName="btnPrevDebrisASPxButton" Text="Prev Page" AutoPostBack="false" ValidationGroup="groupDebrisDisposal">
                                <ClientSideEvents Click="OnBackClick" />
                            </dx:ASPxButton>
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
                            <dx:ASPxButton runat="server" ID="DebrisDisposalASPxButton" ClientInstanceName="btnNextDebrisDisposal" Text="Next Page" AutoPostBack="false" ValidationGroup="groupDebrisDisposal">
                                <ClientSideEvents Click="OnNextClick" />
                            </dx:ASPxButton>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
            </Items>
        </dx:LayoutGroup>
    </Items>
</dx:ASPxFormLayout>

<asp:SqlDataSource runat="server" ID="dsDebrisDisposal" ConnectionString='<%$ ConnectionStrings: DefaultConnection %>'
    DeleteCommand="DELETE FROM [DebrisDisposal] WHERE [DebrisID] = @DebrisID"
    InsertCommand="INSERT INTO [DebrisDisposal] ([WorkOrder], [DebrisDescription], [DebrisAmount], [DebrisSelection], [RecordDate], [UpdateDate], [UpdateBy]) VALUES (@WorkOrder, @DebrisDescription, @DebrisAmount, @DebrisSelection, GetDate(), GetDate(), @UpdateBy)"
    SelectCommand="SELECT * FROM [DebrisDisposal] where WorkOrder = @WorkOrder order by RecordDate desc"
    UpdateCommand="UPDATE [DebrisDisposal] SET [WorkOrder] = @WorkOrder, [DebrisDescription] = @DebrisDescription, [DebrisAmount] = @DebrisAmount, [DebrisSelection] = @DebrisSelection, [UpdateDate] = GetDate(), [UpdateBy] = @UpdateBy WHERE [DebrisID] = @DebrisID">
    <DeleteParameters>
        <asp:Parameter Name="DebrisID" Type="Int32"></asp:Parameter>
    </DeleteParameters>
    <SelectParameters>
        <asp:ControlParameter Name="WorkOrder" ControlID="ctl00$LeftPanel$LeftPanelContent$WOSelected" DefaultValue="-1" PropertyName="Value" Type="STRING"></asp:ControlParameter>
    </SelectParameters>

    <InsertParameters>
        <asp:ControlParameter Name="WorkOrder" ControlID="ctl00$LeftPanel$LeftPanelContent$WOSelected" DefaultValue="-1" PropertyName="Value" Type="STRING"></asp:ControlParameter>
        <asp:Parameter Name="DebrisDescription" Type="String"></asp:Parameter>
        <asp:Parameter Name="DebrisAmount" Type="Decimal"></asp:Parameter>
        <asp:Parameter Name="DebrisSelection" Type="String"></asp:Parameter>
        <asp:Parameter Name="RecordDate" Type="DateTime"></asp:Parameter>
        <asp:Parameter Name="UpdateDate" Type="DateTime"></asp:Parameter>
        <asp:Parameter Name="UpdateBy" Type="String"></asp:Parameter>
    </InsertParameters>
    <UpdateParameters>
        <asp:ControlParameter Name="WorkOrder" ControlID="ctl00$LeftPanel$LeftPanelContent$WOSelected" DefaultValue="-1" PropertyName="Value" Type="STRING"></asp:ControlParameter>
        <asp:Parameter Name="DebrisDescription" Type="String"></asp:Parameter>
        <asp:Parameter Name="DebrisAmount" Type="Decimal"></asp:Parameter>
        <asp:Parameter Name="DebrisSelection" Type="String"></asp:Parameter>
        <asp:Parameter Name="RecordDate" Type="DateTime"></asp:Parameter>
        <asp:Parameter Name="UpdateDate" Type="DateTime"></asp:Parameter>
        <asp:Parameter Name="UpdateBy" Type="String"></asp:Parameter>
        <asp:Parameter Name="DebrisID" Type="Int32"></asp:Parameter>
    </UpdateParameters>
</asp:SqlDataSource>

<asp:SqlDataSource runat="server" ID="DebrisChkBoxDS" ConnectionString='<%$ ConnectionStrings: DefaultConnection %>'
    SelectCommand="Select * from BMODWiz where WorkOrder=@WORKORDER">
    <SelectParameters>
        <asp:ControlParameter Name="WORKORDER" ControlID="ctl00$LeftPanel$LeftPanelContent$WOSelected" DefaultValue="-1" PropertyName="Value" Type="STRING"></asp:ControlParameter>
    </SelectParameters>
    <UpdateParameters>
        <asp:ControlParameter Name="WORKORDER" ControlID="ctl00$LeftPanel$LeftPanelContent$WOSelected" DefaultValue="-1" PropertyName="Value" Type="STRING"></asp:ControlParameter>
    </UpdateParameters>
</asp:SqlDataSource>
