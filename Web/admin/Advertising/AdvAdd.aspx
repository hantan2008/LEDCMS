<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdvAdd.aspx.cs" Inherits="Web.admin.Advertising.AdvAdd" %>

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
    <script type="text/javascript" src="../../KindEditor/kindeditor.js"></script>
    <script type="text/javascript">

        KE.show({
            id: 'txtContent',
            imageUploadJson: '../../../Tools/upload_json.ashx',
            fileManagerJson: '../../../Tools/file_manager_json.ashx',
            allowFileManager: true
        });

        $(function () {
            //表单验证JS
            $("#form1").validate({
                //出错时添加的标签
                errorElement: "span",
                success: function (label) {
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
                        font-weight: bold; line-height: 45px; padding-left: 60px;">发布产品</legend>
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                            <td>
                                <asp:HiddenField ID="hdfid" runat="server" />
                            </td>
                        </tr>
                    </table>
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                            <td style="width: 15%; text-align: right">
                                广告名称：
                            </td>
                            <td style="text-align: left">
                                <asp:TextBox ID="txtTitle" runat="server" minlength="3" CssClass="input w50 required"
                                    HintTitle="发布的广告名称" HintInfo="控制在50个字数内，广告名称文本尽量不要太长。"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 15%; text-align: right">
                                广告类型：
                            </td>
                            <td style="text-align: left">
                                <asp:RadioButtonList ID="rblAdType" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                                    <asp:ListItem Selected="True" Value="1">文字 </asp:ListItem>
                                    <asp:ListItem Value="2">图片 </asp:ListItem>
                                    <asp:ListItem Value="3">幻灯片 </asp:ListItem>
                                    <asp:ListItem Value="4">动画 </asp:ListItem>
                                    <asp:ListItem Value="5">FLV视频 </asp:ListItem>
                                    <asp:ListItem Value="6">代码 </asp:ListItem>
                                </asp:RadioButtonList>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 15%; text-align: right">
                                广告位说明：
                            </td>
                            <td style="text-align: left">
                                <asp:TextBox ID="txtAdRemark" runat="server" minlength="3" CssClass="input w150 required"
                                    HintTitle="发布的广告位说明" HintInfo="控制在150个字数内，广告名称文本尽量不要太长。" Width="600px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 15%; text-align: right">
                                广告位宽度：
                            </td>
                            <td style="text-align: left">
                                <asp:TextBox ID="txtAdWidth" runat="server" minlength="3" CssClass="input w3 required"
                                    HintTitle="发布的广告位宽度" HintInfo="控制在3个字数内，广告名称文本尽量不要太长。" Width="100px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 15%; text-align: right">
                                广告位高度：
                            </td>
                            <td style="text-align: left">
                                <asp:TextBox ID="txtAdHeight" runat="server" minlength="3" CssClass="input w3 required"
                                    HintTitle="发布的广告位高度" HintInfo="控制在3个字数内，广告名称文本尽量不要太长。" Width="100px"></asp:TextBox>
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
