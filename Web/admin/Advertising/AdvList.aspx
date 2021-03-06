﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdvList.aspx.cs" Inherits="Web.admin.Advertising.AdvList" %>
<%@ Register Src="../Control/PageNavigator.ascx" TagName="PageNavigator" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
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

        //全选取消按钮函数，调用样式如：
        function checkAll(chkobj) {
            if ($(chkobj).text() == "全选") {
                $(chkobj).text("取消");
                $(".checkall input").attr("checked", true);
            } else {
                $(chkobj).text("全选");
                $(".checkall input").attr("checked", false);
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="navigation">
        <span class="add"><a href="AdvAdd.aspx">发布新广告</a></span><b>您当前的位置：首页 &gt; 基本设置
            &gt; 广告列表 </b>
    </div>
    <div>
        <fieldset>
            <legend style="background: url(../images/icons/legendimg.jpg) no-repeat 6px 50%;
                font-weight: bold; line-height: 35px; padding-left: 60px;">产品列表</legend>
            <table width="100%" border="0" cellspacing="0" cellpadding="0">
                <tr>
                    <td>
                        <asp:GridView ID="gvdataList" runat="server" Width="100%" AutoGenerateColumns="False"
                            Height="112px" CssClass="msgtable">
                            <Columns>
                                <asp:TemplateField HeaderText="选择">
                                    <ItemTemplate>
                                        <asp:CheckBox ID="cb_id" CssClass="checkall" runat="server" />
                                        <asp:Label ID="lb_id" runat="Server" Text='<%#Eval("ID")%>' Visible=false></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" Width="5%" />
                                </asp:TemplateField>
                                <asp:BoundField DataField="Title" HeaderText="广告位名称">
                                    <ItemStyle Width="20%" />
                                </asp:BoundField>
                                <asp:BoundField DataField="AdType" HeaderText="广告位类型">
                                    <ItemStyle Width="20%" />
                                </asp:BoundField>
                                <asp:BoundField DataField="AdWidth" HeaderText="广告位宽度" />
                                <asp:BoundField DataField="AdHeight" HeaderText="广告位高度">
                                    <ItemStyle Width="20%" />
                                </asp:BoundField>
                                
                                <asp:TemplateField HeaderText="操作">
                                    <ItemTemplate>
                                        <a href="BarEdit.aspx?id=<%# Eval("ID") %>">内容管理</a>&nbsp; <a href="AdvList.aspx?id=<%# Eval("ID") %>">修改</a>&nbsp;&nbsp;
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
                    <td>
                        <div class="left">
                            <span class="btn_all" onclick="checkAll(this);">全选</span> <span class="btn_bg">
                                <asp:LinkButton ID="lbtnDel" runat="server" OnClientClick="return confirm( '确定要删除这些记录吗？ ');"
                                    OnClick="lbtnDel_Click">删 除</asp:LinkButton>
                            </span>
                        </div>
                    </td>
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
