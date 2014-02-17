<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuList.aspx.cs" Inherits="Web.admin.sysManage.MenuManage.MenuList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="../../Images/style.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="navigation">
        <span class="add"><a href="MenuAdd.aspx">发布顶级菜单</a></span><b>您当前的位置：首页 &gt; 系统管理
            &gt; 菜单管理 </b>
    </div>
    <fieldset>
        <legend style="background: url(../../images/icons/legendimg.jpg) no-repeat 6px 50%;
            font-weight: bold; line-height: 35px; padding-left: 60px;">菜单列表</legend>
        <table width="100%" border="0" cellspacing="0" cellpadding="0">
            <tr>
                <td>
                    <asp:Repeater ID="rptClassList" runat="server" 
            onitemcommand="rptClassList_ItemCommand" 
            onitemdatabound="rptClassList_ItemDataBound">
            <HeaderTemplate>
                <table width="100%" border="0" cellspacing="0" cellpadding="0" class="msgtable">
                    <tr>
                        <th width="7%">编号</th>
                        <th align="left">菜单名称</th>
                        <th width="90" align="left">菜单地址</th>
                        <th width="50" align="center">显示</th>
                        <th width="150">管理操作</th>
                    </tr>
            </HeaderTemplate>
            <ItemTemplate>
                    <tr>
                        <td align="center">
                          <asp:HiddenField ID="txtClassId" runat="server" Value='<%#Eval("Id") %>' />
                          <asp:HiddenField ID="txtClassLayer" runat="server" Value='<%#Eval("mod_level") %>' />
                          <%# Eval("ID") %>
                        </td>
                        <td>
                          <asp:Literal ID="LitFirst" runat="server"></asp:Literal>
                          <%# Eval("mod_name")%>
                        </td>
                        <td align="left"><%# Eval("mod_URL")%></td>
                        <td align="center"><%#Eval("mod_isvisible").ToString().Trim() == "True" ? "<img title=\"正常\" src=\"../../images/correct.gif\" />" : "<img title=\"禁用\" src=\"../../images/disable.gif\" />"%></td>
                        <td align="left">
                            <span><a href="MenuAdd.aspx?parentid=<%# Eval("Id") %>">添加子类</a></span>
                            <span><a href="MenuList.aspx">管理</a></span>
                            <span><a href="MenuEdit.aspx?id=<%# Eval("Id") %>">修改</a></span>
                            <span><asp:LinkButton ID="lbDel" CommandName="btndel" runat="server" OnClientClick="return confirm( '该操作会删除本类别和下属类别，确定要删除吗？ ');">删除</asp:LinkButton></span>
                        </td>
                    </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>
                </td>
            </tr>
        </table>
    </fieldset>
    </form>
</body>
</html>
