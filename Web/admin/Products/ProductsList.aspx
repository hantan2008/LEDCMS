<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductsList.aspx.cs" Inherits="Web.admin.Products.ProductsList" %>

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
        <span class="add"><a href="ProductsAdd.aspx">发布新产品</a></span><b>您当前的位置：首页 &gt; 产品管理
            &gt; 产品列表 </b>
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
                                <asp:BoundField DataField="CMS_ProductName" HeaderText="产品名称">
                                    <ItemStyle Width="20%" />
                                </asp:BoundField>
                               
                                <asp:TemplateField HeaderText="产品类型">
                                    <ItemTemplate>
                                    <span><%# getProductClassName(Convert.ToInt32(Eval("CMS_ProductClassID")))%></span>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="CMS_Puter" HeaderText="发布者" />
                                <asp:BoundField DataField="CMS_AddTime" HeaderText="发布时间">
                                    <ItemStyle Width="20%" />
                                </asp:BoundField>
                                <asp:TemplateField HeaderText="属性">
                                    <ItemTemplate>
                                        <asp:ImageButton ID="ibtnSlide" CommandName="ibtnSlide" runat="server" ImageUrl='<%# Convert.ToInt32(Eval("CMS_IsSlide")) == 1 ? "../Images/ico-4.png" : "../Images/ico-4_.png"%>'
                                            ToolTip='<%# Convert.ToInt32(Eval("CMS_IsSlide")) == 1 ? "取消幻灯片" : "设置幻灯片"%>' />
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="操作">
                                    <ItemTemplate>
                                        <a href="ProductsEdit.aspx?id=<%# Eval("ID") %>">修改</a>
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
