<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EquipmentDetailsControl.ascx.cs" Inherits="BMOD.UserControls.EquipmentDetailsControl" %>
<%@ Register Assembly="DevExpress.Web.v20.2, Version=20.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<dx:ASPxFormLayout ID="EquipUsedWizASPxFormLayout" runat="server" Width="100%" AlignItemCaptionsInAllGroups="True"
    UseDefaultPaddings="False" CssClass="formLayout1" Paddings-PaddingTop="20px"
    DataSourceID="EquipmentUsedChkBoxDS">
    <Items>
        <dx:LayoutGroup Caption="Check List" ColumnCount="3" ColSpan="1" Width="100%">
            <GridSettings StretchLastItem="true" WrapCaptionAtWidth="660">
                <Breakpoints>
                    <dx:LayoutBreakpoint MaxWidth="500" ColumnCount="1" Name="S" />
                    <dx:LayoutBreakpoint MaxWidth="800" ColumnCount="2" Name="M" />
                </Breakpoints>
            </GridSettings>
            <Items>
                <dx:LayoutItem ShowCaption="True" Caption="Equipment Used" VerticalAlign="Middle" FieldName="EquipmentUsed">
                    <SpanRules>
                        <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="S"></dx:SpanRule>
                        <dx:SpanRule ColumnSpan="2" RowSpan="1" BreakpointName="M"></dx:SpanRule>
                    </SpanRules>
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer>
                            <dx:ASPxCheckBox runat="server" ID="EquipUsedWizASPxCheckBox" ClientInstanceName="EquipUsedWizASPxCheckBox" AutoPostBack="false">
                                <ValidationSettings SetFocusOnError="True" ValidationGroup="groupEquipmentUsed" ErrorTextPosition="Bottom">
                                    <RequiredField IsRequired="True" ErrorText="Recording Equipment Used is required" />
                                </ValidationSettings>
                                <ClientSideEvents Validation="onCheckBoxValidation" CheckedChanged="onCheckedChange"  />
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
                            <dx:ASPxButton runat="server" ID="btnWrapUpPrev" ClientInstanceName="btnWrapUpPrev" Text="Prev Page" AutoPostBack="false">
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
                            <dx:ASPxButton runat="server" ID="btnWrapUpNext" ClientInstanceName="btnWrapUpNext" Text="Next Page" AutoPostBack="false">
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
<asp:SqlDataSource runat="server" ID="EquipmentUsedChkBoxDS" ConnectionString='<%$ ConnectionStrings: DefaultConnection %>'
    SelectCommand="Select * from BMODWiz where WorkOrder=@WORKORDER">
    <SelectParameters>
        <asp:ControlParameter Name="WORKORDER" ControlID="ctl00$LeftPanel$LeftPanelContent$WOSelected" DefaultValue="-1" PropertyName="Value" Type="STRING"></asp:ControlParameter>
    </SelectParameters>
</asp:SqlDataSource>
