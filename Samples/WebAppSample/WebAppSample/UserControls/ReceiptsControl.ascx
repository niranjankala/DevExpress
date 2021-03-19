<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ReceiptsControl.ascx.cs" Inherits="BMOD.UserControls.ReceiptsControl" %>
<%@ Register Assembly="DevExpress.Web.v20.2, Version=20.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<dx:aspxformlayout id="ReceiptsWizASPxFormLayout" datasourceid="ReceiptsChkBoxDS" runat="server" width="100%" alignitemcaptionsinallgroups="True"
    usedefaultpaddings="false" cssclass="formLayout1" paddings-paddingtop="20px">
    <Items>
        <dx:LayoutGroup Caption="Check List" ColumnCount="3" ColSpan="1" Width="100%">
            <GridSettings StretchLastItem="true" WrapCaptionAtWidth="660">
                <Breakpoints>
                    <dx:LayoutBreakpoint MaxWidth="500" ColumnCount="1" Name="S" />
                    <dx:LayoutBreakpoint MaxWidth="800" ColumnCount="2" Name="M" />
                </Breakpoints>
            </GridSettings>
            <Items>
                <dx:LayoutItem ShowCaption="True" FieldName="Receipts" Caption="Receipts Picture Taken" VerticalAlign="Middle">
                    <SpanRules>
                        <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="S"></dx:SpanRule>
                        <dx:SpanRule ColumnSpan="2" RowSpan="1" BreakpointName="M"></dx:SpanRule>
                    </SpanRules>
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer>
                            <dx:ASPxCheckBox runat="server" ID="chkReceiptsWiz" ClientInstanceName="chkReceiptsWiz" AutoPostBack="false">
                                <ValidationSettings SetFocusOnError="True" ValidationGroup="groupReceipts" ErrorTextPosition="Bottom">
                                    <RequiredField IsRequired="True" ErrorText="Recording Receipts is required" />
                                </ValidationSettings>
                                <ClientSideEvents Validation="onCheckBoxValidation" CheckedChanged="onCheckedChange"  />
                            </dx:ASPxCheckBox>
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


                <dx:LayoutItem ShowCaption="False" HorizontalAlign="Left" VerticalAlign="Middle" 
                    Paddings-PaddingTop="20px" CssClass="lastItem">
                    <Paddings PaddingTop="20px"></Paddings>
                    <SpanRules>
                        <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="S"></dx:SpanRule>
                        <dx:SpanRule ColumnSpan="2" RowSpan="1" BreakpointName="M"></dx:SpanRule>
                    </SpanRules>
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer>
                            <dx:ASPxButton runat="server" ID="ReceiptsBasckASPxButton" ClientInstanceName="btnPrevReceipts" Text="Prev Page" AutoPostBack="false" ValidationGroup="groupReceipts">
                                <ClientSideEvents Click="OnBackClick" />
                            </dx:ASPxButton>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>




                <dx:LayoutItem ShowCaption="false" HorizontalAlign="Left" VerticalAlign="Middle" Paddings-PaddingTop="20px" CssClass="lastItem">
                    <Paddings PaddingTop="20px"></Paddings>
                    <SpanRules>
                        <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="S"></dx:SpanRule>
                        <dx:SpanRule ColumnSpan="2" RowSpan="1" BreakpointName="M"></dx:SpanRule>
                    </SpanRules>
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer>
                            <dx:ASPxButton runat="server" ID="ReceiptsWizASPxButton" ClientInstanceName="btnNextReceipts" Text="Next Page" AutoPostBack="false" ValidationGroup="groupReceipts">
                                <ClientSideEvents Click="OnNextClick" />
                            </dx:ASPxButton>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
            </Items>
        </dx:LayoutGroup>
    </Items>

    <Paddings PaddingTop="20px"></Paddings>
</dx:aspxformlayout>

<asp:SqlDataSource runat="server" ID="ReceiptsChkBoxDS" ConnectionString='<%$ ConnectionStrings: DefaultConnection %>'
    SelectCommand="Select * from BMODWiz where WorkOrder=@WORKORDER">
    <SelectParameters>
        <asp:ControlParameter Name="WORKORDER" ControlID="ctl00$LeftPanel$LeftPanelContent$WOSelected" DefaultValue="-1" PropertyName="Value" Type="STRING"></asp:ControlParameter>
    </SelectParameters>
</asp:SqlDataSource>

