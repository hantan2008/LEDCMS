using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Web;

namespace CMS.Common
{
    public static class WebUtility
    {

        #region 系统特殊字符处理
        public static string InputText(string text, int maxLength)
        {
            text = text.Trim();
            if (string.IsNullOrEmpty(text))
                return string.Empty;
            if (text.Length > maxLength)
                text = text.Substring(0, maxLength);
            text = Regex.Replace(text, "[\\s]{2,}", " ");	//two or more spaces
            text = Regex.Replace(text, "(<[b|B][r|R]/*>)+|(<[p|P](.|\\n)*?>)", "\n");	//<br>
            text = Regex.Replace(text, "(\\s*&[n|N][b|B][s|S][p|P];\\s*)+", " ");	//&nbsp;
            text = Regex.Replace(text, "<(.|\\n)*?>", string.Empty);	//any other tags
            text = text.Replace("'", "''");
            return text;
        }
        public static string InputText(string text)
        {
            if (string.IsNullOrEmpty(text))
                return string.Empty;
            text = Regex.Replace(text, "[\\s]{2,}", " ");	//two or more spaces
            text = Regex.Replace(text, "(<[b|B][r|R]/*>)+|(<[p|P](.|\\n)*?>)", "\n");	//<br>
            text = Regex.Replace(text, "(\\s*&[n|N][b|B][s|S][p|P];\\s*)+", " ");	//&nbsp;
            text = Regex.Replace(text, "<(.|\\n)*?>", string.Empty);	//any other tags
            text = text.Replace("'", "''");
            return text;
        }

        #region
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strText"></param>
        /// <returns></returns>
        public static string StringToHtml(string strText)
        {
            string strHtml = strText.Replace(" ", "&nbsp;");
            strHtml = strHtml.Replace("<", "&lt;");
            strHtml = strHtml.Replace(">", "&gt;");
            strHtml = strHtml.Replace("\r\n", "<br />");
            strHtml = strHtml.Replace("\"", "&quot;");
            strHtml = strHtml.Replace("'", "&#39;");
            return strHtml;
        }
        public static string StringToHtml1(string strText)
        {
            string strHtml = strText; //strText.Replace(" ", "&nbsp;");
            strHtml = strHtml.Replace("<", "&lt;");
            strHtml = strHtml.Replace(">", "&gt;");
            strHtml = strHtml.Replace("\r\n", "<br />");
            strHtml = strHtml.Replace("\"", "&quot;");
            strHtml = strHtml.Replace("'", "&#39;");
            return strHtml;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strHtml"></param>
        /// <returns></returns>
        public static string HtmlToString(string strHtml)
        {
            string strText = strHtml.Replace("&nbsp;", " ");
            strText = strText.Replace("<br />", "\r\n");
            strText = strText.Replace("&lt;", "<");
            strText = strText.Replace("&gt;", ">");
            strText = strText.Replace("&quot;", "\"");
            strText = strText.Replace("&#39;", "'");
            return strText;
        }

        #region 替换危险Sql字符
        /// <summary>
        /// 替换危险Sql字符
        /// </summary>
        /// <param name="inputString">要替换的字符</param>
        /// <returns></returns>
        public static string replaceStr(string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
                return "";
            string replaceIn = @";|exec|insert|select|delete|update|count|*|%|chr|mid|master|truncate|char|declare|'";
            string[] ArrayReplaceIn = replaceIn.Split(char.Parse("|"));
            int i;
            for (i = 0; i < ArrayReplaceIn.Length; i++)
            {
                inputString = inputString.Replace(ArrayReplaceIn[i].ToString(), "");
            }
            return inputString.Trim();
        }
        #endregion
        #endregion
        #endregion

        public static string CleanNonWord(string text)
        {
            return Regex.Replace(text, "\\W", "");
        }

        #region 获取指定长度的字符串
        public static string GetLenghtAll(string Str, int N)
        {
            if (Str.Length > N)
            {
                return Str.Substring(0, N);
            }
            return Str;
        }
        #endregion

        #region TextBox控件onblur事件
        public static void WebControlOnblur(System.Web.UI.WebControls.TextBox textBox)
        {
            textBox.Attributes.Add("onblur", "this.value=this.value.replace(/\\s/g,'');");
        }
        #endregion

        #region TextBox控件onblur事件
        public static void WebControlOnblur(System.Web.UI.WebControls.TextBox textBox, string str)
        {
            textBox.Attributes.Add("onblur", "this.value=this.value.replace(/\\s/g,'');$(" + str + ").innerHTML=''");
            textBox.Attributes.Add("onfocus", "this.select();$(" + str + ").innerHTML='<img src=../images/bulb.gif border=0>'");
        }
        #endregion

        #region Input控件onblur事件
        public static void HtmlControlOnblur(System.Web.UI.HtmlControls.HtmlInputControl input)
        {
            input.Attributes.Add("onblur", "this.value=this.value.replace(/\\s/g,'');");
        }
        #endregion

        #region 验证组件是否存在
        public static bool checkObj(string obj)
        {
            try
            {
                object meobj = HttpContext.Current.Server.CreateObject(obj);
                return (true);
            }
            catch (Exception)
            {
                return (false);
            }
        }
        public static void checkResult(Label controlName, string str)
        {
            if (checkObj(str))
            {
                controlName.Text = "<font color=red>√</font>";
            }
            else
            {
                controlName.Text = "×";
            }
        }
        //public static string GetImgagesNews()
        //{
        //    string cmdText = "select  top 9  YX_KeyWord,YX_Title,YX_ID from YX_News where YX_UserID=0 and YX_TypeId=10";
        //    SqlDataReader rdr = SqlHelper.ExecuteReader(SqlHelper.ConnectionStringLocalTransactionHr, CommandType.Text, cmdText, null);
        //    StringBuilder sb = new StringBuilder();
        //    YXJob.BLL.YixiangConfig sysbll = new YXJob.BLL.YixiangConfig();
        //    YXJob.Model.Yixiang_config sysobj = new YXJob.Model.Yixiang_config();

        //    YXJob.Model.Yixiang_config _config =sysbll.GetBasicCofing();

        //    while (rdr.Read())
        //    {
        //        sb.Append(rdr.GetString(0)).Append("-").Append(rdr.GetString(1)).Append("-").Append(_config.webUrl+"/News/newsShow.aspx?newsId="+rdr[2].ToString()).Append("|");
        //    }
        //    rdr.Close();
        //    return sb.ToString().TrimEnd(new char[] { '|' });
        //}
        //public  static void IsLogin()
        //{
        //     if(System.Web.HttpContext.Current.Session["admin"]==null)
        //     {
        //         YXJob.Common.alert.RedirectUrl("Default.aspx");
        //     }
        //}       
        #endregion

        #region 字符串截取

        public static string SubString(string content, int length)
        {

            System.Text.StringBuilder sb = null;
            try
            {
                sb = new System.Text.StringBuilder();
                System.Text.Encoding encoding = System.Text.Encoding.GetEncoding("gb2312");
                int totalLength = 0;
                foreach (char contentChar in content)
                {
                    int size = encoding.GetByteCount(new char[] { contentChar }); //获得1或2，中文2，英文1
                    if (totalLength + size > length - 2)
                    {
                        sb.Append("...");
                        break;
                    }
                    sb.Append(contentChar);
                    totalLength += size;
                }
            }
            catch
            {
                sb.Append("");
            }
            return sb.ToString();
        }
        #endregion

        public static string UrlOperation(string url)
        {
            if (url.IndexOf("?") == -1)
            {
                url += "?";
            }
            else
            {
                url += "&";
            }
            return url;
        }
        public static bool isDecimal(string deci)
        {
            if (string.IsNullOrEmpty(deci))
                return false;
            System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex("^(0.|[1-9][0-9]*.)?[0-9]{1,2}$");
            return reg.IsMatch(deci);
        }
        public static bool isDecimal(object deci)
        {
            if (deci == null)
                return false;
            return isDecimal(deci.ToString());
        }
        /// <summary>
        /// 判断某个字符串是不是数字型的
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool isNumeric(string num)
        {
            if (string.IsNullOrEmpty(num))
                return false;
            System.Text.RegularExpressions.Regex r = new System.Text.RegularExpressions.Regex("^[0-9]+$");
            return r.IsMatch(num);
        }
        public static bool isNumeric(object isNum)
        {
            if (isNum == null)
                return false;
            return isNumeric(isNum.ToString());
        }
    } 
}
