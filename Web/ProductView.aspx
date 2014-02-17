<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductView.aspx.cs" Inherits="Web.ProductView" %>

<%@ Register Src="Control/Bottom.ascx" TagName="Bottom" TagPrefix="uc1" %>
<%@ Register Src="Control/Top.ascx" TagName="Top" TagPrefix="uc2" %>
<%@ Register src="Control/ProductClass.ascx" tagname="ProductClass" tagprefix="uc3" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>产品详情</title>
    <link href="styles/css.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" language="javascript" src="js/menu.js"></script>
    <script src="js/FancyZoom.js" language="JavaScript" type="text/javascript"></script>
    <script src="js/FancyZoomHTML.js" language="JavaScript" type="text/javascript"></script>
</head>
<body onLoad="setupZoom();">
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
                                <td style="height: 500; vertical-align: top;">
                                    
                                    <uc3:ProductClass ID="ProductClass1" runat="server" />
                                    
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
                                    <div style="margin-top: 10px; margin-left: 20px; width: 100%">
                                        <table style="width: 100%" border="0" cellpadding="0" cellspacing="0">
                                            <tr>
                                                <td style="width: 50%">
                                                    <div class="photoblock-many">
                                                        <a href='<%=  model.CMS_ProductImg %>' title="<%=  model.CMS_ProductName %>">
                                                            <asp:Image ID="imgproduct" runat="server" Width="300" Height="300" class="photo" />
                                                        </a>
                                                    </div>
                                                    <br />
                                                    <span style="text-align: center; width: 100%">查看大图</span>
                                                </td>
                                                <td style="width: 50%;" valign="top">
                                                    <table style="width: 100%;" border="0" cellpadding="0" cellspacing="0">
                                                        <tr>
                                                            <td style="width: 25%">
                                                                产品名称:
                                                            </td>
                                                            <td>
                                                                <asp:Label ID="lblProductName" runat="server" Text=""></asp:Label>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                产品类型:
                                                            </td>
                                                            <td>
                                                                <asp:Label ID="lblProductClass" runat="server" Text=""></asp:Label>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                产品规格:
                                                            </td>
                                                            <td>
                                                                <asp:Label ID="lbl" runat="server" Text=""></asp:Label>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                产品概述:
                                                            </td>
                                                            <td>
                                                                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                        </table>
                                        <hr />
                                        <table style="width: 100%" border="0" cellpadding="0" cellspacing="0">
                                            <tr>
                                                <td>
                                                    产品描述:
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="lblContent" runat="server" Text=""></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
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
