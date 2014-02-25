<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConfigManage.aspx.cs" Inherits="Web.admin.sysManage.Config.ConfigManage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="../../Images/style.css" />
    <script type="text/javascript" language="javascript" src="../../../js/jquery-1.3.2.min.js"></script>
    <script type="text/javascript" language="javascript" src="../../../js/jquery.validate.min.js"></script>
    <script type="text/javascript" language="javascript" src="../../../js/messages_cn.js"></script>
    <script type="text/javascript" language="javascript" src="../../../js/jquery.form.js"></script>
    <script type="text/javascript" language="javascript" src="../../js/function.js"></script>
    <script type="text/javascript">


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
    <div class="navigation">
        <b>您当前的位置：首页 &gt; 系统管理 &gt; 系统参数设置</b></div>
    <div style="padding-bottom: 10px;">
    </div>
    <table width="100%" border="0" cellspacing="0" cellpadding="0" class="msgtable">
        <tbody>
            <tr>
                <th colspan="2" align="left">
                    系统基本设置（注意：如果你不是专业人员请勿改动，只有开放文件的读写权限才能修改）
                </th>
            </tr>
            <tr>
                <td width="25%" align="right">
                    网站标题：
                </td>
                <td width="75%">
                    <asp:TextBox ID="txtWebName" runat="server" CssClass="input required" size="48" MaxLength="50"
                        HintTitle="系统的名称" HintInfo="给你的系统起个有意义的名字哦，长度不能超过50个字符。"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right">
                    网站域名：
                </td>
                <td>
                    <asp:TextBox ID="txtWebUrl" runat="server" CssClass="input required" size="48" MaxLength="100"
                        HintTitle="网站的域名" HintInfo="请以http://为开头填写，长度不能超过100个字符。"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right">
                    办公电话：
                </td>
                <td>
                    <asp:TextBox ID="txtWebTel" runat="server" CssClass="input required" size="25" MaxLength="50"
                        HintTitle="办公电话号码" HintInfo="格式如：0757-22228888。"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right">
                    传真号码：
                </td>
                <td>
                    <asp:TextBox ID="txtWebFax" runat="server" CssClass="input" size="25" MaxLength="50"
                        HintTitle="传真号码" HintInfo="格式如：0757-22228888。"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right">
                    管理员信箱：<br />
                </td>
                <td>
                    <asp:TextBox ID="txtWebEmail" runat="server" CssClass="input" size="25" MaxLength="50"
                        HintTitle="网站管理员信箱" HintInfo="方便客户需要咨询时发送邮件。"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right">
                    网站备案号：
                </td>
                <td>
                    <asp:TextBox ID="txtWebCrod" runat="server" CssClass="input" size="25" MaxLength="50"
                        HintTitle="网站备案号码" HintInfo="信息产业部申请的合法TCP/IP备案号。"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right">
                    网站关健字：
                </td>
                <td>
                    <asp:TextBox ID="txtWebKeywords" runat="server" CssClass="input" Style="width: 300px;"
                        MaxLength="250" HintTitle="网站关健字" HintInfo="搜索引擎可根据网站设置的关健字，以“,”号分隔开。"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right">
                    网站描述：
                </td>
                <td>
                    <asp:TextBox ID="txtWebDescription" runat="server" CssClass="textarea" Style="width: 300px;
                        height: 45px;" MaxLength="250" HintTitle="网站描述" HintInfo="搜索引擎可根据网站设置的描述信息，字符小于等于250位字符。"
                        TextMode="MultiLine"></asp:TextBox>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td align="right">
                    系统版权信息：<br />
                    （支持HTML）
                </td>
                <td>
                    <asp:TextBox ID="txtWebCopyright" runat="server" TextMode="MultiLine" CssClass="textarea"
                        Style="width: 300px; height: 80px;" HintTitle="网站版权信息" HintInfo="该信息将会显示在网站的底部，支持HTML标志填写，所以请认真填写。"></asp:TextBox>
                </td>
            </tr>
        </tbody>
    </table>
    <div class="spClear">
    </div>
    <table width="100%" border="0" cellspacing="0" cellpadding="0" class="msgtable">
        <tbody>
            <tr>
                <th colspan="2" align="left">
                    <strong>系统参数设置</strong>
                </th>
            </tr>
            <tr>
                <td width="25%" align="right">
                    虚拟目录：
                </td>
                <td width="75%">
                    <asp:TextBox ID="txtWebPath" runat="server" CssClass="input required" size="25" MaxLength="20"
                        HintTitle="网站的虚拟目录" HintInfo="请填写网站的虚拟目录名称，如果放在根目录下，输入“/”；如：http://abc.com/web，输入“/web/”，要加“/”开头和结尾，否则系统无法使用。"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right">
                    后台管理目录：
                </td>
                <td>
                    <asp:TextBox ID="txtWebManagePath" runat="server" CssClass="input required" size="25"
                        MaxLength="20" HintTitle="网站的后台管理目录" HintInfo="默认是Admin，如果你已经更改，请输入你更改过的目录名称，如“WebManger”，如果填写不正确，将可能导注系统无法使用。"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right">
                    文件上传目录：
                </td>
                <td>
                    <asp:TextBox ID="txtWebFilePath" runat="server" CssClass="input required" size="50"
                        MaxLength="255" HintTitle="文件上传目录" HintInfo="上传图片或附件的目录名称，该目录将会自动创建在网站根目录下，如：“UploadFiles”。"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right">
                    允许文件上传类型：
                </td>
                <td>
                    <asp:TextBox ID="txtWebFileType" runat="server" CssClass="input required" size="50"
                        MaxLength="255" HintTitle="允许上传文件扩展名" HintInfo="上传图片或附件时用于检测，以英文的|号分隔开，如：“jpg|gif|rar”。"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right">
                    允许文件上传大小：
                </td>
                <td>
                    <asp:TextBox ID="txtWebFileSize" runat="server" CssClass="input required digits"
                        MaxLength="9" size="5" HintTitle="允许上传文件大小" HintInfo="整数，如果超过设置的大小将不给予上传。"></asp:TextBox>
                    &nbsp;KB
                </td>
            </tr>
        </tbody>
    </table>
    <div style="margin-top: 10px; text-align: center;">
        <asp:Button ID="btnSave" runat="server" Text="确认保存" CssClass="submit" OnClick="btnSave_Click" />
        &nbsp;
        <input name="重置" type="reset" class="submit" value="重置" />
    </div>
    </form>
</body>
</html>
