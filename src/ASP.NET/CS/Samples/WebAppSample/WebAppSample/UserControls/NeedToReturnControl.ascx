<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NeedToReturnControl.ascx.cs" Inherits="BMOD.UserControls.NeedToReturnControl" %>
<%@ Register Assembly="DevExpress.Web.v20.2, Version=20.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>



<div class="frmMain">
    <dx:aspxformlayout id="NTRWizASPxFormLayout" runat="server" width="100%" alignitemcaptionsinallgroups="True"
        usedefaultpaddings="false" cssclass="formLayout1" DataSourceID="NTRChkBoxDS">
        <Items>
            <dx:LayoutGroup Caption="Check List" ColumnCount="3" ColSpan="1" Width="100%">
                <GridSettings StretchLastItem="true" WrapCaptionAtWidth="660">
                    <Breakpoints>
                        <dx:LayoutBreakpoint MaxWidth="500" ColumnCount="1" Name="S" />
                        <dx:LayoutBreakpoint MaxWidth="800" ColumnCount="2" Name="M" />
                    </Breakpoints>
                </GridSettings>
                <Items>
                    <dx:LayoutItem ShowCaption="true" Caption="Need To Return" VerticalAlign="Middle" Paddings-PaddingTop="20px"
                        FieldName="NTR">
                        <Paddings PaddingTop="20px"></Paddings>
                        <SpanRules>
                            <dx:SpanRule ColumnSpan="1" RowSpan="1" BreakpointName="S"></dx:SpanRule>
                            <dx:SpanRule ColumnSpan="2" RowSpan="1" BreakpointName="M"></dx:SpanRule>
                        </SpanRules>
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxCheckBox runat="server" ID="NTRASPxCheckBox" ClientInstanceName="NTRASPxCheckBox" AutoPostBack="false">
                                    <ValidationSettings SetFocusOnError="True" ValidationGroup="groupNTR" ErrorTextPosition="Bottom">
                                        <RequiredField IsRequired="True" ErrorText="Need To Return Completion is required" />
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
                                <dx:ASPxButton runat="server" ID="btnPrevNTRASPxButton" ClientInstanceName="btnPrevNTR" Text="Prev Page" AutoPostBack="false" ValidationGroup="groupNTR">
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
                                <dx:ASPxButton runat="server" ID="NTRASPxButton" ClientInstanceName="btnNextNTR" Text="Next Page" AutoPostBack="false" ValidationGroup="groupNTR">
                                    <ClientSideEvents Click="OnNextClick" />
                                </dx:ASPxButton>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                </Items>
            </dx:LayoutGroup>
        </Items>
    </dx:aspxformlayout>

<asp:SqlDataSource runat="server" ID="NTRChkBoxDS" ConnectionString='<%$ ConnectionStrings: DefaultConnection %>'
    SelectCommand="Select * from BMODWiz where WorkOrder=@WORKORDER">
    <SelectParameters>
        <asp:ControlParameter Name="WORKORDER" ControlID="ctl00$LeftPanel$LeftPanelContent$WOSelected" DefaultValue="-1" PropertyName="Value" Type="STRING"></asp:ControlParameter>
    </SelectParameters>    
</asp:SqlDataSource>



</div>
