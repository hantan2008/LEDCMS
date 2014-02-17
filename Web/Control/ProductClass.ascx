<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ProductClass.ascx.cs"
    Inherits="Web.Control.ProductClass" %>
<asp:Repeater ID="RepeaterProducts" runat="server">
    <HeaderTemplate>
        <table width="95%" border="0" cellspacing="0" cellpadding="0">
    </HeaderTemplate>
    <ItemTemplate>
        <tr>
            <td align="left" style="padding: 8px 0 8px 0; border-bottom: #CCCCCC dotted 1px;"
                onmouseover="javascript:this.bgColor='#EFEFEF'" onmouseout="javascript:this.bgColor='#FFFFFF'">
                &nbsp;<img src="Images/protu.gif" alt="" />&nbsp;&nbsp;<a href='Products.aspx?class=<%# Eval("ID")%>'><%# Eval("CMS_ClassName")%></a>
            </td>
        </tr>
    </ItemTemplate>
    <FooterTemplate>
        </table></FooterTemplate>
</asp:Repeater>
