<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewsAdd.aspx.cs" Inherits="Web.admin.News.NewsAdd"
    ValidateRequest="false" %>

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
                        font-weight: bold; line-height: 45px; padding-left: 60px;">发布资讯</legend>
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
                                新闻标题：
                            </td>
                            <td style="text-align: left">
                                <asp:TextBox ID="txtCMS_Title" runat="server" minlength="3" CssClass="input w250 required"
                                    HintTitle="发布的文章标题" HintInfo="控制在100个字数内，标题文本尽量不要太长。"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 15%; text-align: right">
                                新闻类型：
                            </td>
                            <td style="text-align: left">
                                <asp:DropDownList ID="ddlNewType" runat="server" CssClass="input w250 required">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 15%; text-align: right">
                                作 者：
                            </td>
                            <td style="text-align: left">
                                <asp:TextBox ID="txtCMS_Author" runat="server" CssClass="input w50" HintTitle="作者"
                                    HintInfo="控制在50个字数内。"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 15%; text-align: right">
                                新闻内容：
                            </td>
                            <td style="text-align: left">
                                <textarea id="txtContent" cols="100" rows="8" style="width: 90%; height: 400px; visibility: hidden;"
                                    runat="server"></textarea>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 15%; text-align: right">
                                新闻来源：
                            </td>
                            <td style="text-align: left">
                                <asp:TextBox ID="txtCMS_Form" runat="server" CssClass="input w50" HintTitle="新闻来源"
                                    HintInfo="控制在50个字数内。"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 15%; text-align: right">
                                文章关键字：
                            </td>
                            <td style="text-align: left">
                                <asp:TextBox ID="txtCMS_Keyword" runat="server" CssClass="input w50" HintTitle="文章关键字"
                                    HintInfo="控制在150个字数内。"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 15%; text-align: right">
                                发布者：
                            </td>
                            <td style="text-align: left">
                                <asp:TextBox ID="txtCMS_Puter" runat="server" CssClass="input w50" HintTitle="发布者"
                                    HintInfo="控制在50个字数内。"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 15%; text-align: right">
                                发布时间：
                            </td>
                            <td style="text-align: left">
                                <asp:TextBox ID="txtCMS_Time" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 15%; text-align: right">
                                点击率：
                            </td>
                            <td style="text-align: left">
                                <asp:TextBox ID="txtCMS_Click" runat="server" Text="0"></asp:TextBox>
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
