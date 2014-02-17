<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_Center.aspx.cs" Inherits="Web.admin.Admin_Center" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="Images/style.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="navigation">
        <span class="add"><a href="../global/global_baseset.aspx">修改配置信息</a></span><b>您当前的位置：首页
            &gt; 管理中心 &gt; 管理中心首页</b></div>
    <div class="spClear">
    </div>
    <fieldset>
        <legend style="background: url(../images/icons/icon43.jpg) no-repeat 6px 50%;
            font-weight: bold; line-height: 45px; padding-left: 60px;">系统基本信息</legend>
        <table width="100%" border="0" cellspacing="0" cellpadding="0" class="msgtable">
            <tr>
                <td width="20%" align="right">
                    网站名称：
                </td>
                <td width="80%">
                    <asp:Label ID="lblWebSiteName" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="right">
                    网站域名：
                </td>
                <td>
                    <asp:Label ID="lblDDNS" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="right">
                    安装目录：
                </td>
                <td>
                    <asp:Label ID="lblPath" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="right">
                    后台目录：
                </td>
                <td>
                <asp:Label ID="lblAdminPath" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="right">
                    联系电话：
                </td>
                <td>
                <asp:Label ID="lblTel" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="right">
                    传真号码：
                </td>
                <td>
                <asp:Label ID="lblfax" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="right">
                    电子邮箱：
                </td>
                <td>
                <asp:Label ID="lblEmail" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>
    </fieldset>
    <fieldset>
        <legend style="background: url(../images/icons/icon61.jpg) no-repeat 6px 50%;
            font-weight: bold; line-height: 45px; padding-left: 60px;">服务器信息</legend>
        <table width="100%" border="0" cellspacing="0" cellpadding="0" class="msgtable">
            <tr>
                <td width="20%" align="right">
                    服务器名称：
                </td>
                <td width="80%">
                    <%=Server.MachineName%>
                </td>
            </tr>
            <tr>
                <td align="right">
                    服务器IP：
                </td>
                <td>
                    <%=Request.ServerVariables["LOCAL_ADDR"] %>
                </td>
            </tr>
            <tr>
                <td align="right">
                    NET框架版本：
                </td>
                <td>
                    <%=Environment.Version.ToString()%>
                </td>
            </tr>
            <tr>
                <td align="right">
                    操作系统：
                </td>
                <td>
                    <%=Environment.OSVersion.ToString()%>
                </td>
            </tr>
            <tr>
                <td align="right">
                    IIS环境：
                </td>
                <td>
                    <%=Request.ServerVariables["SERVER_SOFTWARE"]%>
                </td>
            </tr>
            <tr>
                <td align="right">
                    服务器端口：
                </td>
                <td>
                    <%=Request.ServerVariables["SERVER_PORT"]%>
                </td>
            </tr>
            <tr>
                <td align="right">
                    虚拟目录绝对路径：
                </td>
                <td>
                    <%=Request.ServerVariables["APPL_PHYSICAL_PATH"]%>
                </td>
            </tr>
            <tr>
                <td align="right">
                    HTTPS支持：
                </td>
                <td>
                    <%=Request.ServerVariables["HTTPS"]%>
                </td>
            </tr>
            <tr>
                <td align="right">
                    seesion总数：
                </td>
                <td>
                    <%=Session.Keys.Count.ToString()%>
                </td>
            </tr>
        </table>
    </fieldset>
    <fieldset>
        <legend style="background: url(../images/icons/icon35.jpg) no-repeat 6px 50%;
            font-weight: bold; line-height: 45px; padding-left: 60px;">团队信息</legend>
        <table width="100%" border="0" cellspacing="0" cellpadding="0" class="msgtable">
            <tr>
                <td width="20%" align="right">
                    版权申明：
                </td>
                <td width="80%">
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
