<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewsList.aspx.cs" Inherits="Web.admin.News.NewsList" %>

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
        <span class="add"><a href="NewsAdd.aspx">发布文章</a></span><b>您当前的位置：首页 &gt; 资讯管理 &gt;
            资讯列表</b></div>
    <div>
        <fieldset>
            <legend style="background: url(../images/icons/legendimg.jpg) no-repeat 6px 50%;
                font-weight: bold; line-height: 35px; padding-left: 60px;">新闻列表</legend>
            <table width="100%" border="0" cellspacing="0" cellpadding="0">
                <tr>
                    <td>
                        <asp:GridView ID="gvdataList" runat="server" Width="100%" AutoGenerateColumns="False"
                            Height="112px" CssClass="msgtable">
                            <Columns>
                                <asp:TemplateField HeaderText="选择">
                                    <ItemTemplate>
                                        <asp:CheckBox ID="cb_id" CssClass="checkall" runat="server" />
                                        <asp:Label ID="lb_id" runat="Server" Text='<%#Eval("ID")%>' Visible="false"></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" Width="5%" />
                                </asp:TemplateField>
                                <asp:BoundField DataField="CMS_Title" HeaderText="新闻标题">
                                    <ItemStyle Width="20%" />
                                </asp:BoundField>
                                <asp:TemplateField HeaderText="新闻类型">
                                    <ItemTemplate>
                                        <span>
                                            <%# getClassName(Convert.ToInt32(Eval("CMS_Type")))%></span>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="CMS_Author" HeaderText="作者" />
                                <asp:BoundField DataField="CMS_Puter" HeaderText="发布者" />
                                <asp:BoundField DataField="CMS_Time" HeaderText="发布时间">
                                    <ItemStyle Width="20%" />
                                </asp:BoundField>
                                
                                <asp:TemplateField HeaderText="操作">
                                    <ItemTemplate>
                                        <a href="NewsEdit.aspx?id=<%# Eval("ID") %>">修改</a> 
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
                        <span class="btn_all" onclick="checkAll(this);">全选</span>
                        <span class="btn_bg">
                            <asp:LinkButton ID="lbtnDel" runat="server" OnClientClick="return confirm( '确定要删除这些记录吗？ ');"
                                OnClick="lbtnDel_Click">删 除</asp:LinkButton>
                        </span>
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
