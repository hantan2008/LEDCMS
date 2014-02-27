<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContentList.aspx.cs" Inherits="Web.admin.Contents.ContentList" %>

<%@ Register Src="../Control/PageNavigator.ascx" TagName="PageNavigator" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link rel="stylesheet" type="text/css" href="../Images/style.css" />

    <script language="javascript" type="text/javascript" src="../../js/jquery-1.3.2.min.js"></script>

    <script language="javascript" type="text/javascript">
        $(function () {
            $(".msgtable tr:nth-child(odd)").addClass("tr_bg"); //隔行变色
            $(".msgtable tr").hover(
			    function () {
			        $(this).addClass("tr_hover_col");
			    },
			    function () {
			        $(this).removeClass("tr_hover_col");
			    }
		    );
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
     <div class="navigation">
        <b>您当前的位置：首页 > 基本设置 > 内容管理</b></div>
    <div>
        <fieldset>
            <legend style="background: url(../images/icons/legendimg.jpg) no-repeat 6px 50%;
                font-weight: bold; line-height: 35px; padding-left: 60px;">内容列表</legend>
            <table width="100%" border="0" cellspacing="0" cellpadding="0">
                <tr>
                    <td>
                        <asp:GridView ID="gvNewList" runat="server" Width="100%" AutoGenerateColumns="False"
                            Height="112px" CssClass="msgtable">
                            <Columns>
                                <asp:BoundField DataField="id" HeaderText="ID">
                                    <ItemStyle Width="20%" />
                                </asp:BoundField>
                                <asp:BoundField DataField="CMS_CallIndex" HeaderText="内容索引">
                                    <ItemStyle Width="30%" />
                                </asp:BoundField>
                                <asp:BoundField DataField="CMS_Title" HeaderText="内容标题">
                                    <ItemStyle Width="40%" />
                                </asp:BoundField>
                                <asp:TemplateField HeaderText="操作">
                                    <ItemTemplate>
                                        <a href='ContentList.aspx?Index=<%# Eval("CMS_CallIndex") %>'>修改</a>&nbsp; 
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
            </table>
            <table width="100%" border="0" align="center" bgcolor="white" cellpadding="1" cellspacing="1"
                style="height: 20px">
                <tr>
                    
                    <td class="noprint">
                        <uc1:PageNavigator ID="PageNavigator1" runat="server" />
                    </td>
                </tr>
            </table>
        </fieldset>
    </div>
    </form>
</body>
</html>
