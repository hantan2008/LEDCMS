﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="News.aspx.cs" Inherits="Web.News" %>

<%@ Register Src="Control/Bottom.ascx" TagName="Bottom" TagPrefix="uc1" %>
<%@ Register Src="Control/Top.ascx" TagName="Top" TagPrefix="uc2" %>
<%@ Register Src="Control/PageNavigator.ascx" TagName="PageNavigator" TagPrefix="uc3" %>
<%@ Register src="Control/ProductClass.ascx" tagname="ProductClass" tagprefix="uc4" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title><%= SiteConfig.WebName %>-新闻资讯</title>
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
            <img src="images/banner_News.jpg" width="1003" height="181" alt="" /></div>
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
                                    <img src="images/title_new.jpg" width="737" height="59" alt="">
                                </td>
                            </tr>
                        </table>
                        <table style="width: 95%; margin-left: 20px;" border="0" cellpadding="0" cellspacing="0">
                            <tr>
                                <td align="left">
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
                                        <asp:DataList ID="datalistnews" runat="server" Width="100%">
                                            <HeaderTemplate>
                                                <table style="width: 100%;" border="0" cellpadding="0" cellspacing="0">
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <tr>
                                                    <td style="width: 15;">
                                                        <img src="Images/news_1.gif" alt="" />
                                                    </td>
                                                    <td><a href='newsdetail.aspx?id=<%#Eval("ID") %>' target="_blank">
                                                        <%# Eval("CMS_Title")%></a>
                                                    </td>
                                                    <td style="width: 100; text-align: center;">
                                                        <%# Eval("CMS_Time", "{0:yyyy-MM-dd}")%>
                                                    </td>
                                                </tr>
                                            </ItemTemplate>
                                            <FooterTemplate>
                                                </table></FooterTemplate>
                                        </asp:DataList>
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
