<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="Web.Products" %>

<%@ Register Src="Control/Bottom.ascx" TagName="Bottom" TagPrefix="uc1" %>
<%@ Register Src="Control/Top.ascx" TagName="Top" TagPrefix="uc2" %>
<%@ Register Src="Control/PageNavigator.ascx" TagName="PageNavigator" TagPrefix="uc3" %>
<%@ Register src="Control/ProductClass.ascx" tagname="ProductClass" tagprefix="uc4" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="styles/css.css" rel="stylesheet" type="text/css" />

    <script type="text/javascript" language="javascript" src="js/menu.js"></script>

</head>
<body>
    <form id="form1" runat="server">
    <center>
        <!--头部-->
        <div id="Top">
            <uc2:Top ID="Top1" runat="server" />
        </div>
        <!--广告图片-->
        <div style="width: 1003">
            <img src="images/banner_Products.jpg" width="1003" height="181" alt="" /></div>
        <!--内容部分-->
        <div style="width: 1003">
            <table style="width: 100%" border="0" cellpadding="0" cellspacing="0">
                <tr>
                    <td style="width: 266" valign="top">
                        <table style="width: 100%" border="0" cellpadding="0" cellspacing="0">
                            <tr>
                                <td style="width: 28; height: 43">
                                    <img src="images/newdetail_03.jpg" width="28" height="43" alt="">
                                </td>
                                <td>
                                    <img src="images/newdetail_04.jpg" width="238" height="43" alt="">
                                </td>
                            </tr>
                            <tr>
                                <td>
                                </td>
                                <td style="height: 500; vertical-align:top;">
                                    <uc4:ProductClass ID="ProductClass1" runat="server" />
                                    </td>
                            </tr>
                            <tr>
                                <td>
                                </td>
                                <td>
                                    <img src="images/newdetail_19.jpg" width="238" height="43" alt="">
                                </td>
                            </tr>
                            <tr>
                                <td>
                                </td>
                                <td style="height: 230; vertical-align: top">
                                    <p>
                                        地址：广东省深圳市</p>
                                    <p>
                                        电话：0755-12345678</p>
                                    <p>
                                        传真：0755-12345678</p>
                                    <p>
                                        手机：13800138000</p>
                                    <p>
                                        QQ：12345678</p>
                                    <p>
                                        MSN：12345678@163.com</p>
                                    <p>
                                        Email：12345678@163.com</p>
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td style="width: 4; height: 603;" valign="top">
                        <img src="Images/about_03.jpg" />
                    </td>
                    <td valign="top">
                        <table style="width: 100%" border="0" cellpadding="0" cellspacing="0">
                            <tr>
                                <td style="height: 43">
                                    <img src="images/title_product.jpg" width="737" height="59" alt="">
                                </td>
                            </tr>
                        </table>
                        <table style="width: 100%; margin-left: 10px;" border="0" cellpadding="0" cellspacing="0">
                            <tr>
                                <td align="left">
                                    <hr />
                                    您现在所在的位置：首页>新闻中心
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <hr />
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 100%;">
                                    <div style="margin-top: 10px; width: 101%">
                                        <ul style="list-style-type: none; float: left; width: 100%">
                                            <asp:Repeater ID="Repeater1" runat="server">
                                                <ItemTemplate>
                                                    <li style="width: 30%; float: left; margin:10 10 10 10;">
                                                        <table style="width: 100%; padding-top: 2px; padding-right: 1px; padding-left: 1px;"
                                                            border="0" cellpadding="0" cellspacing="0">
                                                            <tr>
                                                                <td align="center">
                                                                    <a href='ProductView.aspx?id=<%# Eval("ID") %>' target="_blank">
                                                                        <img src='<%# Eval("CMS_ProductImg") %>' alt="" width="210" height="210" /></a>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td align="center">
                                                                    <a href='ProductView.aspx?id=<%# Eval("ID") %>' target="_blank">
                                                                        <%# Eval("CMS_ProductName")%></a>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </li>
                                                    
                                                </ItemTemplate>
                                            </asp:Repeater>
                                        </ul>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td align="center">
                                    <uc3:PageNavigator ID="PageNavigator1" runat="server" />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </div>
        <!--底部-->
        <div id="bottom">
            <uc1:Bottom ID="Bottom1" runat="server" />
        </div>
    </center>
    </form>
</body>
</html>
