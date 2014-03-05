<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="about.aspx.cs" Inherits="Web.about" %>

<%@ Register Src="Control/Bottom.ascx" TagName="Bottom" TagPrefix="uc1" %>
<%@ Register Src="Control/Top.ascx" TagName="Top" TagPrefix="uc2" %>
<%@ Register src="Control/ProductClass.ascx" tagname="ProductClass" tagprefix="uc3" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title><%= SiteConfig.WebName %>-关于我们</title>
    <%=AddMetaInfo(SiteConfig.WebKeywords, SiteConfig.WebDescription)%>
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
            <img src="images/banner_About.jpg" width="1003" height="181" alt="" /></div>
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
                                <td style="height: 500;vertical-align: top;">
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
                                        地址：<%= baseset.CompanyAddress %></p>
                                    <p>
                                        电话：<%= baseset.CompanyTel %></p>
                                    <p>
                                        传真：<%= baseset.CompanyFax %></p>
                                    <p>
                                        QQ：<%= baseset.QQ%></p>
                                    <p>
                                        Email：<%= baseset.Email%></p>
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
                                    <img src="images/title_about.jpg" width="737" height="59" alt="">
                                </td>
                            </tr>
                        </table>
                        <table style="width: 95%; margin-left: 20px;" border="0" cellpadding="0" cellspacing="0">
                            <tr>
                                <td>
                                    <hr />
                                    您现在所在的位置：首页>新闻中心
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <hr>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <div style="margin-top: 10px">
                                        <asp:Label ID="lblContent" runat="server" Text=""></asp:Label>
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
