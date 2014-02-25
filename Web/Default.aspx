<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web._Default" %>

<%@ Register Src="Control/Bottom.ascx" TagName="Bottom" TagPrefix="uc1" %>
<%@ Register Src="Control/Top.ascx" TagName="Top" TagPrefix="uc2" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title><%= SiteConfig.WebName %>-网站首页</title>
    <%=AddMetaInfo(SiteConfig.WebKeywords, SiteConfig.WebDescription)%>
    <link href="styles/css.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" language="javascript" src="js/menu.js"></script>
    <script src="js/swfobject.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    <center>
        <!--头部-->
        <div id="Top">
            <uc2:Top ID="Top1" runat="server" />
        </div>
        <!--广告部分-->
        <div id="banner" style="width: 1003">
            <script type="text/javascript">
                var so = new SWFObject("swf/xixi.swf", "sotester", "1003", "282", "0", "#FFFFFF");
                so.write("banner");
            </script>
        </div>
        <!--内容部分-->
        <div id="content" style="width: 1003">
            <table width="1003" border="0" cellpadding="0" cellspacing="0">
                <tr>
                    <td width="19" height="37">
                    </td>
                    <td>
                        <img src="images/Content_02.jpg" width="217" height="37" alt="">
                    </td>
                    <td width="24" height="37">
                    </td>
                    <td width="431" height="37">
                        <img src="Images/Content_04.jpg" alt="" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        More..
                    </td>
                    <td>
                        <img src="images/Content_05.jpg" width="16" height="37" alt="">
                    </td>
                    <td>
                        <img src="images/Content_06.jpg" width="272" height="37" alt="">
                    </td>
                    <td width="24" height="37">
                    </td>
                </tr>
                <tr>
                    <td rowspan="3">
                        <img src="images/Content_08.jpg" width="19" height="157" alt="">
                    </td>
                    <td rowspan="3" valign="top">
                        <asp:Repeater ID="RepeaterProducts" runat="server">
                            <HeaderTemplate>
                                <table width="95%" border="0" cellspacing="0" cellpadding="0">
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr>
                                    <td align="left" style="padding: 8px 0 8px 0; border-bottom: #CCCCCC dotted 1px;"
                                        onmouseover="javascript:this.bgColor='#EFEFEF'" onmouseout="javascript:this.bgColor='#FFFFFF'">
                                        &nbsp;<img src="Images/protu.gif" alt="" />&nbsp;&nbsp;<a href='Products.aspx?class=<%# Eval("ID")%>'><%# Eval("CMS_ClassName")%></a></td>
                                </tr>
                            </ItemTemplate>
                            <FooterTemplate>
                                </table></FooterTemplate>
                        </asp:Repeater>
                    </td>
                    <td rowspan="3" valign="top">
                        <img src="images/Content_10.jpg" width="24" height="337" alt="">
                    </td>
                    <td width="431" height="157" valign="top">
                        <asp:Repeater ID="RepeaterNews" runat="server">
                            <HeaderTemplate>
                                <table>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr>
                                    <td style="width: 18px;">
                                        <img src="Images/newtip.jpg" />
                                    </td>
                                    <td style="width: 343">
                                        <a href='newsdetail.aspx?id=<%# Eval("ID") %>' target="_blank">
                                            <%# Eval("CMS_Title")%></a>
                                    </td>
                                    <td style="width: 70px">
                                        <%# Eval("CMS_Time", "{0:yyyy-MM-dd}")%>
                                    </td>
                                </tr>
                            </ItemTemplate>
                            <FooterTemplate>
                                </table></FooterTemplate>
                        </asp:Repeater>
                    </td>
                    <td rowspan="3" valign="top">
                        <img src="images/Content_12.jpg" width="16" height="278" alt="">
                    </td>
                    <td rowspan="2" valign="top">
                        <div align="center">
                            <script type="text/javascript">
                                var pic_width = 292; //图片宽度
                                var pic_height = 200; //图片高度
                                var button_pos = 4; //按扭位置 1左 2右 3上 4下
                                var stop_time = 3000; //图片停留时间(1000为1秒钟)
                                var show_text = 0; //是否显示文字标签 1显示 0不显示
                                var txtcolor = "000000"; //文字色
                                var bgcolor = "DDDDDD"; //背景色
                                var imag = new Array();
                                var link = new Array();
                                var text = new Array();
                                imag[1] = "images/01.jpg";
                                link[1] = "http://www.chinaz.com/";
                                text[1] = "标题 1";
                                imag[2] = "images/02.jpg";
                                link[2] = "http://www.chinaz.com/";
                                text[2] = "标题 2";
                                imag[3] = "images/03.jpg";
                                link[3] = "http://www.chinaz.com/";
                                text[3] = "标题 3";
                                imag[4] = "images/04.jpg";
                                link[4] = "http://www.chinaz.com/";
                                text[4] = "标题 4";
                                imag[5] = "images/05.jpg";
                                link[2] = "http://www.chinaz.com/";
                                text[5] = "标题 5";
                                //可编辑内容结束
                                var swf_height = show_text == 1 ? pic_height + 20 : pic_height;
                                var pics = "", links = "", texts = "";
                                for (var i = 1; i < imag.length; i++) {
                                    pics = pics + ("|" + imag[i]);
                                    links = links + ("|" + link[i]);
                                    texts = texts + ("|" + text[i]);
                                }
                                pics = pics.substring(1);
                                links = links.substring(1);
                                texts = texts.substring(1);
                                document.write('<object classid="clsid:d27cdb6e-ae6d-11cf-96b8-444553540000" codebase="http://fpdownload.macromedia.com/pub/shockwave/cabs/flash/swflash.cabversion=6,0,0,0" width="' + pic_width + '" height="' + swf_height + '">');
                                document.write('<param name="movie" value="flash/focus.swf">');
                                document.write('<param name="quality" value="high"><param name="wmode" value="opaque">');
                                document.write('<param name="FlashVars" value="pics=' + pics + '&links=' + links + '&texts=' + texts + '&pic_width=' + pic_width + '&pic_height=' + pic_height + '&show_text=' + show_text + '&txtcolor=' + txtcolor + '&bgcolor=' + bgcolor + '&button_pos=' + button_pos + '&stop_time=' + stop_time + '">');
                                document.write('<embed src="flash/focus.swf" FlashVars="pics=' + pics + '&links=' + links + '&texts=' + texts + '&pic_width=' + pic_width + '&pic_height=' + pic_height + '&show_text=' + show_text + '&txtcolor=' + txtcolor + '&bgcolor=' + bgcolor + '&button_pos=' + button_pos + '&stop_time=' + stop_time + '" quality="high" width="' + pic_width + '" height="' + swf_height + '" allowScriptAccess="sameDomain" type="application/x-shockwave-flash" pluginspage="http://www.macromedia.com/go/getflashplayer" />');
                                document.write('</object>');
                            </script>
                        </div>
                    </td>
                    <td rowspan="3" valign="top">
                        <img src="images/Content_14.jpg" width="24" height="157" alt="">
                    </td>
                </tr>
                <tr>
                    <td>
                        <img src="images/Content_18.jpg" width="431" height="41" alt="">
                    </td>
                </tr>
                <tr>
                    <td width="431" height="180" valign="top">
                        <asp:Label ID="lblAbout" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>
                        <img src="images/Content_27.jpg" width="272" height="180" alt="">
                    </td>
                </tr>
                <tr>
                    <td width="19" height="36">
                    </td>
                    <td>
                        <img src="images/Content_30.jpg" width="217" height="36" alt="">
                    </td>
                    <td width="24" height="36">
                        <img src="images/Content_31.jpg" alt="">
                    </td>
                    <td>
                        <img src="images/Content_32.jpg" width="431" height="36" alt="">
                    </td>
                    <td>
                        <img src="images/Content_33.jpg" width="16" height="36" alt="">
                    </td>
                    <td>
                        <img src="images/Content_34.jpg" width="272" height="36" alt="">
                    </td>
                    <td>
                        <img src="images/Content_35.jpg" width="24" height="36" alt="">
                    </td>
                </tr>
                <tr>
                    <td width="19" height="190">
                        <img src="images/Content_36.jpg" alt="">
                    </td>
                    <td>
                        <img src="images/Content_37.jpg" width="217" height="190" alt="">
                    </td>
                    <td>
                        <img src="images/Content_38.jpg" width="24" height="190" alt="">
                    </td>
                    <td colspan="4" style="width: 723; height: 190">
                        <div id="www_qpsh_com" style="overflow: hidden; height: 190px; width: 100%;">
                            <table style="width: 100%;" align="left" cellpadding="0" cellspacing="0" border="0">
                                <tr>
                                    <td id="www_qpsh_com1" valign="top">
                                        <asp:Literal ID="ltrIndexProductHTML" runat="server"></asp:Literal>
                                    </td>
                                    <td id="www_qpsh_com2" valign="top">
                                    </td>
                                </tr>
                            </table>
                        </div>
                        <script language="javascript" type="text/javascript">
                            var speed = 20//速度数值越大速度越慢
                            var www_qpsh_com = document.getElementById("www_qpsh_com");
                            var www_qpsh_com2 = document.getElementById("www_qpsh_com2");
                            var www_qpsh_com1 = document.getElementById("www_qpsh_com1");

                            www_qpsh_com2.innerHTML = www_qpsh_com1.innerHTML
                            function Marquee() {
                                if (www_qpsh_com2.offsetWidth - www_qpsh_com.scrollLeft <= 0)
                                    www_qpsh_com.scrollLeft -= www_qpsh_com1.offsetWidth
                                else {
                                    www_qpsh_com.scrollLeft++
                                }
                            }
                            var MyMar = setInterval(Marquee, speed)
                            www_qpsh_com.onmouseover = function () { clearInterval(MyMar) }
                            www_qpsh_com.onmouseout = function () { MyMar = setInterval(Marquee, speed) }
                        </script>
                    </td>
                </tr>
            </table>
        </div>
        <!--底部-->
        <div id="bottom" style="width: 1003">
            <uc1:Bottom ID="Bottom1" runat="server"  />
        </div>
    </center>
    </form>
</body>
</html>
