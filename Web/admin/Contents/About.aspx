<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Web.admin.Contents.About" validateRequest=false%>

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
                        font-weight: bold; line-height: 45px; padding-left: 60px;">关于我们</legend>
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                            <td>
                                <asp:HiddenField ID="hdfcallindex" runat="server"  />
                            </td>
                        </tr>
                    </table>
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                            <td style="width: 15%; text-align: right">
                                标题：
                            </td>
                            <td style="text-align: left">
                                <asp:TextBox ID="txtCMS_Title" runat="server" minlength="3" CssClass="input w250" Enabled="false" Text="关于我们"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 15%; text-align: right">
                                公司简介：
                            </td>
                            <td style="text-align: left">
                                <textarea id="txtContent" cols="100" rows="8" style="width: 90%; height: 400px; visibility: hidden;"
                                    runat="server"></textarea>
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
