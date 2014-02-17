<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="left.aspx.cs" Inherits="Web.admin.left" %>
<%@ Import Namespace="System.Data" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        body
        {
            margin-left: 0px;
            margin-top: 0px;
            margin-right: 0px;
            margin-bottom: 0px;
        }
        .STYLE1
        {
            font-size: 12px;
            color: #FFFFFF;
        }
        .STYLE3
        {
            font-size: 12px;
            color: #033d61;
        }
        .menu_title SPAN
        {
            font-weight: bold;
            left: 3px;
            color: #ffffff;
            position: relative;
            top: 2px;
        }
        .menu_title2 SPAN
        {
            font-weight: bold;
            left: 3px;
            color: #FFCC00;
            position: relative;
            top: 2px;
        }
    </style>

    <script type="text/javascript">

        function showMainFile(strs) {
            var objFrame = window.parent.document.getElementById('rightframe');
            objFrame.src = strs;
        }
    </script>

</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table width="165" height="100%" border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td height="28" background="images/main_40.gif">
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                            <td width="19%">
                                &nbsp;
                            </td>
                            <td width="81%" height="20">
                                <span class="STYLE1">管理菜单</span>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td valign="top">
                    <table width="151" border="0" align="center" cellpadding="0" cellspacing="0">
                        <tr>
                            <td>
                                <asp:Repeater ID="rptModLevel1" runat="server">
                                    <ItemTemplate>
                                        <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                            <tr>
                                                <td height="23" background="images/main_47.gif" class="menu_title" onmouseover="this.className='menu_title2';"
                                                    onclick="showObj(<%# GetNextNum()%>)" onmouseout="this.className='menu_title';"
                                                    style="cursor: hand">
                                                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                                        <tr>
                                                            <td width="18%">
                                                                &nbsp;
                                                            </td>
                                                            <td width="82%" class="STYLE1">
                                                                <%# DataBinder.Eval(Container.DataItem,"Mod_Name") %>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td background="images/main_51.gif" id="submenu" style="display: none">
                                                    <div class="sec_menu">
                                                        <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                                            <tr>
                                                                <td>
                                                                    <table width="90%" border="0" align="center" cellpadding="0" cellspacing="0">
                                                                        <asp:Repeater ID="rptModLevel2" runat="server" DataSource='<%# ((DataRowView)Container.DataItem).CreateChildView("Level1Level2Ralation") %>'>
                                                                            <ItemTemplate>
                                                                                <tr>
                                                                                    <td width="16%" height="25">
                                                                                        <div align="center">
                                                                                            <img src="images/left.gif" width="10" height="10" /></div>
                                                                                    </td>
                                                                                    <td width="84%" height="23">
                                                                                        <table width="95%" border="0" cellspacing="0" cellpadding="0">
                                                                                            <tr>
                                                                                                <td height="20" style="cursor: hand" onmouseover="this.style.borderStyle='solid';this.style.borderWidth='1';borderColor='#7bc4d3'; "
                                                                                                    onmouseout="this.style.borderStyle='none'" onclick="showMainFile('<%# DataBinder.Eval(Container.DataItem,"Mod_DefaultPage") %>')">
                                                                                                    <span class="STYLE3">
                                                                                                        <%# DataBinder.Eval(Container.DataItem,"Mod_Name") %></span>
                                                                                                </td>
                                                                                            </tr>
                                                                                        </table>
                                                                                    </td>
                                                                                </tr>
                                                                            </ItemTemplate>
                                                                        </asp:Repeater>
                                                                    </table>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td height="5">
                                                                    <img src="images/main_52.gif" width="151" height="5" />
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </div>
                                                </td>
                                            </tr>
                                        </table>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td height="18" background="images/main_58.gif">
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                            <td height="18" valign="bottom">
                                <div align="center" class="STYLE3">
                                    版本：2009V2.9</div>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>

        <script>




            function showsubmenu(sid) {
                whichEl = eval("submenu" + sid);
                imgmenu = eval("imgmenu" + sid);
                if (whichEl.style.display == "none") {
                    eval("submenu" + sid + ".style.display=\"\";");
                    imgmenu.background = "images/main_47.gif";
                }
                else {
                    eval("submenu" + sid + ".style.display=\"none\";");
                    imgmenu.background = "images/main_48.gif";
                }
            }


            function hideAll() {
                for (i = 0; i < submenu.length; i++) {
                    submenu[i].style.display = "none";
                }
            }

            function showObj(num) {

                if (submenu[num].style.display == "none") {
                    hideAll();
                    submenu[num].style.display = "inline";
                }
                else {
                    submenu[num].style.display = "none";
                }

            }

        </script>

    </div>
    </form>
</body>
</html>
