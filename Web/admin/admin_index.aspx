<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin_index.aspx.cs" Inherits="Web.admin.admin_index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>网站后台管理系统--寒潭CMS</title>
    <link rel="stylesheet" type="text/css" href="images/style.css" />
    <script type="text/javascript" src="../js/jquery-1.3.2.min.js"></script>
    <script type="text/javascript" src="js/function.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <table border="0" cellpadding="0" cellspacing="0" height="100%" width="100%" style="background: #EBF5FC;">
        <tbody>
            <tr>
                <td height="70" colspan="3" style="background: url(images/head_bg.gif);">
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                            <td width="24%" height="70">
                                <img src="images/head_logo.png" width="233" height="50">
                            </td>
                            <td width="76%" valign="bottom">
                                <!--导航菜单,与下面的相关联,修改时注意参数-->
                                <div id="tabs">
                                    <ul>
                                        <asp:Repeater ID="RepeaterMainMenu" runat="server">
                                            <ItemTemplate>
                                                <li onclick="tabs(<%# Eval("ID") %>);"><a href="<%# Eval("mod_URL") %>" target="sysMain">
                                                    <span>
                                                        <%# Eval("mod_name")%></span></a></li>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </ul>
                                </div>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td height="30" colspan="3" style="padding: 0px 10px; font-size: 12px; background: url(images/navsub_bg.gif) repeat-x;">
                    <div style="float: right; line-height: 20px;">
                        <a href="admin_center.aspx" target="sysMain">管理中心</a> | <a target="_blank" href="../">
                            预览网站</a> |
                        <asp:LinkButton ID="lbtnExit" runat="server" OnClick="lbtnExit_Click">安全退出</asp:LinkButton>
                    </div>
                    <div style="padding-left: 20px; line-height: 20px; background: url(images/siteico.gif) 0px 0px no-repeat;">
                        当前登录用户：<font color="#FF0000"><asp:Label ID="lblAdminName" runat="server" Text="Label"></asp:Label></font>您好，欢迎光临。</div>
                </td>
            </tr>
            <tr>
                <td align="middle" id="mainLeft" valign="top" style="background: #FFF;">
                    <div style="text-align: left; width: 185px; height: 100%; font-size: 12px;">
                        <!--导航顶部-->
                        <div style="padding-left: 10px; height: 29px; line-height: 29px; background: url(images/menu_bg.gif) no-repeat;">
                            <span style="padding-left: 15px; font-weight: bold; color: #039; background: url(images/menu_dot.gif) no-repeat;">
                                功能导航</span>
                        </div>
                        <!--导航菜单,修改时注意顺序-->
                        <div class="left_menu">
                            <ul>
                                <asp:Repeater ID="RepeaterMainMenu1" runat="server">
                                    <ItemTemplate>
                                        <li onclick="tabs(<%# Eval("ID") %>);"><a href="<%# Eval("mod_URL") %>" target="sysMain">
                                            <%# Eval("mod_name")%></a></li>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </ul>
                        </div>
                        <!--子菜单-->
                        <div class="left_menu" id="left_menuchild">
                            <asp:Repeater ID="RepeaterChild" runat="server">
                                <ItemTemplate>
                                    <ul class="<%# Eval("mod_parentid") %>">
                                        <li><a href="<%# Eval("mod_URL") %>" target="sysMain">
                                            <%# Eval("mod_name")%></a></li>
                                    </ul>
                                </ItemTemplate>
                            </asp:Repeater>
                        </div>
                    </div>
                </td>
                <td valign="middle" style="width: 8px; background: url(images/main_cen_bg.gif) repeat-x;">
                    <div id="sysBar" style="cursor: pointer;">
                        <img id="barImg" src="images/butClose.gif" alt="关闭/打开左栏" /></div>
                </td>
                <td style="width: 100%" valign="top">
                    <iframe frameborder="0" id="sysMain" name="sysMain" scrolling="yes" src="Admin_Center.aspx"
                        style="height: 100%; visibility: inherit; width: 100%; z-index: 1;"></iframe>
                </td>
            </tr>
            <tr>
                <td height="28" colspan="3" bgcolor="#EBF5FC" style="padding: 0px 10px; font-size: 10px;
                    color: #2C89AD; background: url(images/foot_bg.gif) repeat-x;">
                    版权所有：
                </td>
            </tr>
        </tbody>
    </table>
    </form>
</body>
</html>
