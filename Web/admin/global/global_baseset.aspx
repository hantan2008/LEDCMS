<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="global_baseset.aspx.cs"
    Inherits="Web.admin.global.global_baseset" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
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
    <div >
        <table width="100%" border="0" cellspacing="0" cellpadding="0"  class="msgtable">
            <tr>
                <td>
                    <fieldset>
                        <legend style="background: url(../images/icons/icon55.jpg) no-repeat 6px 50%;
                            font-weight: bold; line-height: 45px; padding-left: 60px;">网站配置</legend>
                        <table width="100%" border="0" cellspacing="0" cellpadding="0">
                            <tr>
                                <td>
                                    <asp:HiddenField ID="hdfid" runat="server" />
                                </td>
                            </tr>
                        </table>
                        <table width="100%" border="0" cellspacing="0" cellpadding="0" >
                            <tr>
                                <td style="width: 15%; text-align: right">
                                    网站名称：
                                </td>
                                <td style="text-align: left">
                                    <asp:TextBox ID="txtWebSiteName" runat="server" CssClass="input w250 required"
                                    HintTitle="网站名称" HintInfo="控制在100个字数内，名称文本尽量不要太长。"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 15%; text-align: right">
                                    公司名称：
                                </td>
                                <td style="text-align: left">
                                    <asp:TextBox ID="txtCompanyName" runat="server" CssClass="input w100 required" HintTitle="公司名称" HintInfo="控制在100个字数内。"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 15%; text-align: right">
                                    公司地址：
                                </td>
                                <td style="text-align: left">
                                    <asp:TextBox ID="txtCompanyAddress" runat="server" CssClass="input w250 required" HintTitle="公司地址" HintInfo="控制在100个字数内。"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 15%; text-align: right">
                                    公司电话：
                                </td>
                                <td style="text-align: left">
                                    <asp:TextBox ID="txtCompanyTel" runat="server" CssClass="input w50 required" HintTitle="公司电话" HintInfo="控制在100个字数内。"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 15%; text-align: right">
                                    传真：
                                </td>
                                <td style="text-align: left">
                                    <asp:TextBox ID="txtCompanyFax" runat="server" CssClass="input w50 required" HintTitle="公司传真" HintInfo="控制在100个字数内。"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 15%; text-align: right">
                                    Email：
                                </td>
                                <td style="text-align: left">
                                    <asp:TextBox ID="txtEmail" runat="server" CssClass="input w250 required" HintTitle="Emai" HintInfo="控制在100个字数内。"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 15%; text-align: right">
                                    QQ：
                                </td>
                                <td style="text-align: left">
                                    <asp:TextBox ID="txtQQ" runat="server" CssClass="input w50 required" HintTitle="QQ号码" HintInfo="控制在100个字数内。"></asp:TextBox>
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
    </div>
    </form>
</body>
</html>
