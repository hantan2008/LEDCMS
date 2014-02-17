<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BarEdit.aspx.cs" Inherits="Web.admin.Advertising.BarEdit" %>

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
                                广告1：
                            </td>
                            <td style="text-align: left">
                            <table border="0" cellspacing="0" cellpadding="0" width="100%">
                            	<tr>
                            		<td style="width: 15%; text-align: right">大图：</td>
                                    <td><asp:TextBox ID="txtProductImg" runat="server" CssClass="input w380 left"></asp:TextBox>
                                <a href="javascript:void(0);" class="files">
                                    <input type="file" id="FileUpload" name="FileUpload" onchange="SingleUpload('txtProductImg','FileUpload',0)" /></a>
                                <span class="uploading">正在上传，请稍候...</span></td>
                            	</tr>
                                <tr>
                            		<td style="width: 15%; text-align: right">小图：</td>
                                    <td><asp:TextBox ID="TextBox1" runat="server" CssClass="input w380 left"></asp:TextBox>
                                <a href="javascript:void(0);" class="files">
                                    <input type="file" id="File1" name="FileUpload" onchange="SingleUpload('txtProductImg','FileUpload',0)" /></a>
                                <span class="uploading">正在上传，请稍候...</span></td>
                            	</tr>
                                <tr>
                            		<td style="width: 15%; text-align: right">提示：</td>
                                    <td><asp:TextBox ID="txtTitle" runat="server" minlength="3" CssClass="input w50 required"
                                    HintTitle="发布的广告名称" HintInfo="控制在50个字数内，广告名称文本尽量不要太长。"></asp:TextBox></td>
                            	</tr>
                                <tr>
                            		<td style="width: 15%; text-align: right">链接：</td>
                                    <td><asp:TextBox ID="TextBox2" runat="server" minlength="3" CssClass="input w50 required"
                                    HintTitle="发布的广告名称" HintInfo="控制在50个字数内，广告名称文本尽量不要太长。" Width="400px"></asp:TextBox></td>
                            	</tr>
                            </table>
                                
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 15%; text-align: right">
                                广告2： 
                            </td>
                            <td style="text-align: left">
                            <table border="0" cellspacing="0" cellpadding="0" width="100%">
                            	<tr>
                            		<td style="width: 15%; text-align: right">大图：</td>
                                    <td><asp:TextBox ID="TextBox3" runat="server" CssClass="input w380 left"></asp:TextBox>
                                <a href="javascript:void(0);" class="files">
                                    <input type="file" id="File2" name="FileUpload" onchange="SingleUpload('txtProductImg','FileUpload',0)" /></a>
                                <span class="uploading">正在上传，请稍候...</span></td>
                            	</tr>
                                <tr>
                            		<td style="width: 15%; text-align: right">小图：</td>
                                    <td><asp:TextBox ID="TextBox4" runat="server" CssClass="input w380 left"></asp:TextBox>
                                <a href="javascript:void(0);" class="files">
                                    <input type="file" id="File3" name="FileUpload" onchange="SingleUpload('txtProductImg','FileUpload',0)" /></a>
                                <span class="uploading">正在上传，请稍候...</span></td>
                            	</tr>
                                <tr>
                            		<td style="width: 15%; text-align: right">提示：</td>
                                    <td><asp:TextBox ID="TextBox5" runat="server" minlength="3" CssClass="input w50 required"
                                    HintTitle="发布的广告名称" HintInfo="控制在50个字数内，广告名称文本尽量不要太长。"></asp:TextBox></td>
                            	</tr>
                                <tr>
                            		<td style="width: 15%; text-align: right">链接：</td>
                                    <td><asp:TextBox ID="TextBox6" runat="server" minlength="3" CssClass="input w50 required"
                                    HintTitle="发布的广告名称" HintInfo="控制在50个字数内，广告名称文本尽量不要太长。" Width="400px"></asp:TextBox></td>
                            	</tr>
                            </table>
                                
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 15%; text-align: right">
                                广告3：
                            </td>
                            <td style="text-align: left">
                            <table border="0" cellspacing="0" cellpadding="0" width="100%">
                            	<tr>
                            		<td style="width: 15%; text-align: right">大图：</td>
                                    <td><asp:TextBox ID="TextBox7" runat="server" CssClass="input w380 left"></asp:TextBox>
                                <a href="javascript:void(0);" class="files">
                                    <input type="file" id="File4" name="FileUpload" onchange="SingleUpload('txtProductImg','FileUpload',0)" /></a>
                                <span class="uploading">正在上传，请稍候...</span></td>
                            	</tr>
                                <tr>
                            		<td style="width: 15%; text-align: right">小图：</td>
                                    <td><asp:TextBox ID="TextBox8" runat="server" CssClass="input w380 left"></asp:TextBox>
                                <a href="javascript:void(0);" class="files">
                                    <input type="file" id="File5" name="FileUpload" onchange="SingleUpload('txtProductImg','FileUpload',0)" /></a>
                                <span class="uploading">正在上传，请稍候...</span></td>
                            	</tr>
                                <tr>
                            		<td style="width: 15%; text-align: right">提示：</td>
                                    <td><asp:TextBox ID="TextBox9" runat="server" minlength="3" CssClass="input w50 required"
                                    HintTitle="发布的广告名称" HintInfo="控制在50个字数内，广告名称文本尽量不要太长。"></asp:TextBox></td>
                            	</tr>
                                <tr>
                            		<td style="width: 15%; text-align: right">链接：</td>
                                    <td><asp:TextBox ID="TextBox10" runat="server" minlength="3" CssClass="input w50 required"
                                    HintTitle="发布的广告名称" HintInfo="控制在50个字数内，广告名称文本尽量不要太长。" Width="400px"></asp:TextBox></td>
                            	</tr>
                            </table>
                                
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 15%; text-align: right">
                                广告4：
                            </td>
                            <td style="text-align: left">
                            <table border="0" cellspacing="0" cellpadding="0" width="100%">
                            	<tr>
                            		<td style="width: 15%; text-align: right">大图：</td>
                                    <td><asp:TextBox ID="TextBox11" runat="server" CssClass="input w380 left"></asp:TextBox>
                                <a href="javascript:void(0);" class="files">
                                    <input type="file" id="File6" name="FileUpload" onchange="SingleUpload('txtProductImg','FileUpload',0)" /></a>
                                <span class="uploading">正在上传，请稍候...</span></td>
                            	</tr>
                                <tr>
                            		<td style="width: 15%; text-align: right">小图：</td>
                                    <td><asp:TextBox ID="TextBox12" runat="server" CssClass="input w380 left"></asp:TextBox>
                                <a href="javascript:void(0);" class="files">
                                    <input type="file" id="File7" name="FileUpload" onchange="SingleUpload('txtProductImg','FileUpload',0)" /></a>
                                <span class="uploading">正在上传，请稍候...</span></td>
                            	</tr>
                                <tr>
                            		<td style="width: 15%; text-align: right">提示：</td>
                                    <td><asp:TextBox ID="TextBox13" runat="server" minlength="3" CssClass="input w50 required"
                                    HintTitle="发布的广告名称" HintInfo="控制在50个字数内，广告名称文本尽量不要太长。"></asp:TextBox></td>
                            	</tr>
                                <tr>
                            		<td style="width: 15%; text-align: right">链接：</td>
                                    <td><asp:TextBox ID="TextBox14" runat="server" minlength="3" CssClass="input w50 required"
                                    HintTitle="发布的广告名称" HintInfo="控制在50个字数内，广告名称文本尽量不要太长。" Width="400px"></asp:TextBox></td>
                            	</tr>
                            </table>
                                
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 15%; text-align: right">
                                广告5：
                            </td>
                            <td style="text-align: left">
                            <table border="0" cellspacing="0" cellpadding="0" width="100%">
                            	<tr>
                            		<td style="width: 15%; text-align: right">大图：</td>
                                    <td><asp:TextBox ID="TextBox15" runat="server" CssClass="input w380 left"></asp:TextBox>
                                <a href="javascript:void(0);" class="files">
                                    <input type="file" id="File8" name="FileUpload" onchange="SingleUpload('txtProductImg','FileUpload',0)" /></a>
                                <span class="uploading">正在上传，请稍候...</span></td>
                            	</tr>
                                <tr>
                            		<td style="width: 15%; text-align: right">小图：</td>
                                    <td><asp:TextBox ID="TextBox16" runat="server" CssClass="input w380 left"></asp:TextBox>
                                <a href="javascript:void(0);" class="files">
                                    <input type="file" id="File9" name="FileUpload" onchange="SingleUpload('txtProductImg','FileUpload',0)" /></a>
                                <span class="uploading">正在上传，请稍候...</span></td>
                            	</tr>
                                <tr>
                            		<td style="width: 15%; text-align: right">提示：</td>
                                    <td><asp:TextBox ID="TextBox17" runat="server" minlength="3" CssClass="input w50 required"
                                    HintTitle="发布的广告名称" HintInfo="控制在50个字数内，广告名称文本尽量不要太长。"></asp:TextBox></td>
                            	</tr>
                                <tr>
                            		<td style="width: 15%; text-align: right">链接：</td>
                                    <td><asp:TextBox ID="TextBox18" runat="server" minlength="3" CssClass="input w50 required"
                                    HintTitle="发布的广告名称" HintInfo="控制在50个字数内，广告名称文本尽量不要太长。" Width="400px"></asp:TextBox></td>
                            	</tr>
                            </table>
                                
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
