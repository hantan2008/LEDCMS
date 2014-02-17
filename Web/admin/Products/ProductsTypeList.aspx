<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductsTypeList.aspx.cs"
    Inherits="Web.admin.Products.ProductsTypeList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="../images/style.css" />

    <script language="javascript" type="text/javascript" src="../../js/jquery-1.3.2.min.js"></script>

    <script language="javascript" type="text/javascript">
        $(function() {
            $(".msgtable tr:nth-child(odd)").addClass("tr_bg"); //隔行变色
            $(".msgtable tr").hover(
			    function() {
			        $(this).addClass("tr_hover_col");
			    },
			    function() {
			        $(this).removeClass("tr_hover_col");
			    }
		    );
        });
    </script>

</head>
<body>
    <form id="form1" runat="server">
    <div class="navigation">
        <span class="add"><a href="ProductsAdd.aspx">发布顶级类别</a></span><b>您当前的位置：首页 &gt; 产品管理
            &gt; 产品类别列表 </b>
    </div>
    <fieldset>
        <legend style="background: url(../images/icons/legendimg.jpg) no-repeat 6px 50%;
            font-weight: bold; line-height: 35px; padding-left: 60px;">产品列表</legend>
        <table width="100%" border="0" cellspacing="0" cellpadding="0">
            <tr>
                <td>
                    <asp:Repeater ID="rptClassList" runat="server" OnItemCommand="rptClassList_ItemCommand"
                        OnItemDataBound="rptClassList_ItemDataBound">
                        <HeaderTemplate>
                            <table width="100%" border="0" cellspacing="0" cellpadding="0" class="msgtable">
                                <tr>
                                    <th width="7%">
                                        编号
                                    </th>
                                    <th align="left"">
                                        类别名称
                                    </th>
                                    <th width="90">
                                        优先级别
                                    </th>
                                    <th width="150">
                                        管理操作
                                    </th>
                                </tr>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <tr>
                                <td align="center">
                                    <asp:HiddenField ID="txtClassId" runat="server" Value='<%#Eval("Id") %>' />
                                    <asp:HiddenField ID="txtClassLayer" runat="server" Value='<%#Eval("CMS_ClassLayer") %>' />
                                    <%# Eval("ID") %>
                                </td>
                                <td>
                                    <asp:Literal ID="LitFirst" runat="server"></asp:Literal>
                                    <%# Eval("CMS_ClassName")%>
                                </td>
                                <td align="center">
                                    <%# Eval("SortId") %>
                                </td>
                                <td align="left">
                                    <span><a href="ProductsTypeAdd.aspx?classId=<%# Eval("Id") %>">添加子类</a></span>
                                    <span><a href="ProductsTypeList.aspx?classId=<%# Eval("Id") %>">管理</a></span> <span>
                                        <a href="ProductsTypeEdit.aspx?classId=<%# Eval("Id") %>">修改</a></span>
                                    <span>
                                        <asp:LinkButton ID="lbDel" CommandName="btndel" runat="server" OnClientClick="return confirm( '该操作会删除本类别和下属类别，确定要删除吗？ ');">删除</asp:LinkButton></span>
                                </td>
                            </tr>
                        </ItemTemplate>
                        <FooterTemplate>
                            </table>
                        </FooterTemplate>
                    </asp:Repeater>
                </td>
            </tr>
        </table>
    </fieldset>
    </form>
</body>
</html>
