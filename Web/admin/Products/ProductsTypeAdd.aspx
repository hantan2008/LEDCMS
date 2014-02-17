<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductsTypeAdd.aspx.cs" Inherits="Web.admin.Products.ProductsTypeAdd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
     <link rel="stylesheet" type="text/css" href="../Images/style.css" />

    <script type="text/javascript" language="javascript" src="../../js/jquery-1.3.2.min.js"></script>

    <script type="text/javascript" language="javascript" src="../../js/jquery.validate.min.js"></script>

    <script type="text/javascript" language="javascript" src="../../js/messages_cn.js"></script>

    <script type="text/javascript" language="javascript" src="../../js/jquery.form.js"></script>

    <script type="text/javascript" language="javascript" src="../js/function.js"></script>

    <script type="text/javascript">
        $(function() {
            //表单验证JS
            $("#form1").validate({
                //出错时添加的标签
                errorElement: "span",
                success: function(label) {
                    //正确时的样式
                    label.text(" ").addClass("success");
                }
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <table width="100%" border="0" cellspacing="0" cellpadding="0" class="msgtable">
        <tr>
            <td>
                <fieldset>
                    <legend style="background: url(../images/icons/legendimg.jpg) no-repeat 6px 50%;
                        font-weight: bold; line-height: 45px; padding-left: 60px;">新增产品类别</legend>
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                            <td>
                                <asp:HiddenField ID="hdfPid" runat="server" />
                                <asp:HiddenField ID="hdfClassLayer" runat="server" />
                            </td>
                        </tr>
                    </table>
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                            <td style="width: 15%; text-align: right">
                                上级类别：
                            </td>
                            <td style="text-align: left">
                                <asp:Label ID="lblPtitle" runat="server" Text=""></asp:Label> 
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 15%; text-align: right">
                                类别名称：
                            </td>
                            <td style="text-align: left">
                                <asp:TextBox ID="txtCMS_ClassName" runat="server" CssClass="input  w250" HintTitle="类别名称"
                                    HintInfo="控制在150个字数内。"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 15%; text-align: right">
                                排序：
                            </td>
                           <td style="text-align: left">
                                <asp:TextBox ID="txtShort" runat="server" CssClass="input  w50" HintTitle="排序"
                                    HintInfo="控制在2个字数内。" ></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 15%; text-align: right">
                                类别描述：
                            </td>
                           <td style="text-align: left">
                                <asp:TextBox ID="txtCMS_Memo" runat="server" CssClass="input  w250" HintTitle="类别描述"
                                    HintInfo="控制在200个字数内。" Height="71px" TextMode="MultiLine"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" style="text-align: center">
                                <asp:Button ID="btnSave" runat="server" Text="保  存" OnClick="btnSave_Click" />&nbsp;&nbsp;&nbsp;<asp:Button
                                    ID="Button2" runat="server" Text="取  消" />
                            </td>
                        </tr>
                    </table>
                </fieldset>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
