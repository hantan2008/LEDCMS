<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Web.admin._default" %>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CMS后台管理系统</title>
    <link href="styles/css.css" rel="stylesheet" type="text/css" />
</head>
<body style="background:#016ba9">
    <form id="form1" runat="server">
    <div id="login">
        <div id="loginerr">
            <asp:Label ID="lberr" runat="server" ForeColor="Red" ></asp:Label>
        </div>
        <div id="logintb">
            <ul>
                <li>用户名：<asp:TextBox ID="userloginname" runat="server" MaxLength="16" Text="admin"></asp:TextBox></li>
                <li>密&nbsp;&nbsp;码：
                    <asp:TextBox ID="userloginpwd" runat="server" MaxLength="16" 
                         Text="123456" TextMode="Password"></asp:TextBox></li>
                <li>验证码：<asp:TextBox ID="txtCheckCode" runat="server" class="vv" MaxLength="12"></asp:TextBox>
                    <img src="tools/checkcode.aspx" onclick="this.src='tools/checkcode.aspx?id=XX'" alt="点击刷新验证码"
                        id="vcodeimg" style="cursor: pointer;" />
                </li>
                <li>&nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                    <asp:ImageButton ID="Imblogin" ImageUrl="~/admin/images/dl.gif" Width="49" Height="18"
                        runat="server" OnClick="Imblogin_Click" /></li>
            </ul>
        </div>
    </div>
    </form>
    
</body>
</html>
