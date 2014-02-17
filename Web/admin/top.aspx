<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="top.aspx.cs" Inherits="Web.admin.top" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="styles/css.css" rel="stylesheet" type="text/css">
</head>
<body>
    <form id="form1" runat="server">
    <table width="100%" border="0" cellspacing="0" cellpadding="0">
        <tr>
            <td height="70" background="images/main_05.gif">
                <table width="100%" border="0" cellspacing="0" cellpadding="0">
                    <tr>
                        <td height="24">
                            <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td width="270" height="24" background="images/main_03.gif">
                                        &nbsp;
                                    </td>
                                    <td width="505" background="images/main_04.gif">
                                        &nbsp;
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                    <td width="21">
                                        <img src="images/main_07.gif" width="21" height="24">
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td height="38">
                            <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td width="230" height="38" background="images/main_09.gif">
                                        &nbsp;
                                    </td>
                                    <td>
                                        <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                            <tr>
                                                <td width="77%" height="25" valign="bottom">
                                                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                                        <tr>
                                                            <td width="50" height="19">
                                                                <img src="images/main_12.gif" width="49" height="19" border="0">
                                                            </td>
                                                            <td width="50">
                                                                <img src="images/main_14.gif" width="48" height="19">
                                                            </td>
                                                            <td width="50">
                                                                <img src="images/main_16.gif" width="48" height="19">
                                                            </td>
                                                            <td width="50">
                                                                <img src="images/main_18.gif" width="48" height="19">
                                                            </td>
                                                            <td width="50">
                                                                <asp:ImageButton ID="ibtnexit" runat="server" Height="19px" ImageUrl="images/main_20.gif"
                                                                    OnClick="ibtnexit_Click" Width="48px" />
                                                            </td>
                                                            <td width="26">
                                                                <img src="images/main_21.gif" width="26" height="19">
                                                            </td>
                                                            <td width="100">
                                                                <img src="images/main_22.gif" width="98" height="19" style="border: 0">
                                                            </td>
                                                            <td>
                                                                <a href="../index.aspx" target="_blank">
                                                                    <img src="images/main_24.gif" width="98" height="19" style="border: 0"></a>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                                <td width="250" valign="bottom" nowrap="nowrap">
                                                    <span class="STYLE1">
                                                        <div class="time">
                                                            今天是<strong>:</strong>

                                                            <script language="javascript">
                                                                function www_helpor_net() {
                                                                    var Digital = new Date();
                                                                    var hours = Digital.getHours();
                                                                    var minutes = Digital.getMinutes();
                                                                    var seconds = Digital.getSeconds();
                                                                    if (minutes <= 9)
                                                                        minutes = "0" + minutes;
                                                                    if (seconds <= 9)
                                                                        seconds = "0" + seconds;
                                                                    myclock = hours + ":" + minutes + ":" + seconds;
                                                                    if (document.layers) {
                                                                        document.layers.liveclock.document.write(myclock);
                                                                        document.layers.liveclock.document.close();
                                                                    }
                                                                    else
                                                                        if (document.all)
                                                                        liveclock.innerHTML = myclock;
                                                                    setTimeout("www_helpor_net()", 1000);
                                                                }
                                                                var enabled = 0; today = new Date();
                                                                var day; var date;
                                                                if (today.getDay() == 0) day = "星期天"
                                                                if (today.getDay() == 1) day = "星期一"
                                                                if (today.getDay() == 2) day = "星期二"
                                                                if (today.getDay() == 3) day = "星期三"
                                                                if (today.getDay() == 4) day = "星期四"
                                                                if (today.getDay() == 5) day = "星期五"
                                                                if (today.getDay() == 6) day = "星期六"
                                                                date = "" + (today.getYear()) + "年 " + (today.getMonth() + 1) + "月 " + today.getDate() + "日 " + day + " ";
                                                                //显示 年月日
                                                                document.write("" + date + "");
                                                                //显示　小时、分、秒 　（"原理就是　一秒刷新一次页面，效果上就是　和表一样，看上去秒是动的"）
                                                                document.write("<SPAN id=liveclock 15px? height: 109px; style?=width:></SPAN>");
                                                                //运行　上面 刷新　秒　的函数

                                                                www_helpor_net();
                                                            </script>

                                                        </div>
                                                    </span>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                    <td width="21">
                                        <img src="images/main_11.gif" width="21" height="38">
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td height="8" style="line-height: 8px;">
                            <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td width="270" background="images/main_29.gif" style="line-height: 8px;">
                                        &nbsp;
                                    </td>
                                    <td width="505" background="images/main_30.gif" style="line-height: 8px;">
                                        &nbsp;
                                    </td>
                                    <td style="line-height: 8px;">
                                        &nbsp;
                                    </td>
                                    <td width="21" style="line-height: 8px;">
                                        <img src="images/main_31.gif" width="21" height="8">
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td height="28" background="images/main_36.gif">
                <table width="100%" border="0" cellspacing="0" cellpadding="0">
                    <tr>
                        <td width="177" height="28" background="images/main_32.gif">
                            <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td width="20%" height="22">
                                        &nbsp;
                                    </td>
                                    <td width="59%" valign="bottom">
                                        &nbsp;
                                    </td>
                                    <td width="21%">
                                        &nbsp;
                                    </td>
                                </tr>
                            </table>
                        </td>
                        <td>
                            <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td height="28">
                                        <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                            <tr>
                                                <td height="23" valign="bottom" align="left">
                                                    &nbsp;&nbsp;<img src="images/localGIF.gif" />
                                                    当前用户：【<asp:Label ID="labRole" runat="server" ForeColor="Blue" Text="Label"></asp:Label>】<asp:Label
                                                        ID="labAdminName" runat="server" ForeColor="Blue"></asp:Label>&nbsp;&nbsp;欢迎您！
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </td>
                        <td width="21">
                            <img src="images/main_37.gif" width="21" height="28">
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
