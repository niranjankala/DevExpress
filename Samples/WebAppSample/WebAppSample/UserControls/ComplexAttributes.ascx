<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ComplexAttributes.ascx.cs" Inherits="BMOD.UserControls.ComplexAttributes" %>
<%@ Register Assembly="DevExpress.Web.v20.2, Version=20.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>


<dx:ASPxGridView ID="grdAttributes" runat="server" AutoGenerateColumns="False" DataSourceID="AttributesDS">

    <EditFormLayoutProperties ColCount="2" ColumnCount="2">
        <Items>
            <dx:GridViewColumnLayoutItem ColumnName="JOBSITENO" ColSpan="1" Visible="false"></dx:GridViewColumnLayoutItem>
            <dx:GridViewColumnLayoutItem ColumnName="ComplexAttribDesc" ColSpan="1"></dx:GridViewColumnLayoutItem>
            <dx:GridViewColumnLayoutItem ColumnName="ComplexAttrib" ColSpan="1"></dx:GridViewColumnLayoutItem>
            <dx:EditModeCommandLayoutItem ColSpan="2" ColumnSpan="2" HorizontalAlign="Right"></dx:EditModeCommandLayoutItem>
        </Items>
    </EditFormLayoutProperties>
    <Columns>
        <dx:GridViewDataTextColumn FieldName="JOBSITENO" Visible="false" VisibleIndex="0"></dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ComplexAttrib" Caption="Attribute" VisibleIndex="1">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ComplexAttribDesc" Caption="Description" VisibleIndex="2"></dx:GridViewDataTextColumn>
    </Columns>
</dx:ASPxGridView>
<asp:SqlDataSource runat="server" ID="AttributesDS" ConnectionString='<%$ ConnectionStrings:DefaultConnection %>'
    SelectCommand="select  wo.JOBSITENO, ca.ComplexAttribDesc, cs.ComplexAttrib   from WORKORDR as wo join JobSite as js on wo.JOBSITENO = js.JobSiteNo  join ComplexAttributes as ca on js.Code = ca.ComplexCode  join ComplexAttribSupport as cs on ca.ComplexAttribCode = cs.ComplexAttribSupportID   where WORKORDER = @WORKORDER">

    <SelectParameters>
        <asp:ControlParameter Name="WORKORDER" ControlID="ctl00$LeftPanel$LeftPanelContent$WOSelected" DefaultValue="-1" PropertyName="Value" Type="STRING"></asp:ControlParameter>
    </SelectParameters>

</asp:SqlDataSource>
