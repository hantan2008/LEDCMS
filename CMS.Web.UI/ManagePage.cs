using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using CMS.Common;

namespace CMS.Web.UI
{
    /// <summary>
    /// 后台管理系统基础页面类
    /// </summary>
    public class ManagePage : System.Web.UI.Page
    {
        protected internal CMS.Model.WebSet webset;
        public ManagePage()
        {
            webset = new CMS.DAL.WebSet().loadConfig(Utils.GetXmlMapPath("Configpath"));
        }
        /// <summary>
        /// 遮罩提示窗口
        /// </summary>
        /// <param name="w">宽度</param>
        /// <param name="h">高度</param>
        /// <param name="msgtitle">窗口标题</param>
        /// <param name="msgbox">提示文字</param>
        /// <param name="url">返回地址</param>
        /// <param name="msgcss">CSS样式</param>
        protected void JscriptMsg(int w, int h, string msgtitle, string msgbox, string url, string msgcss)
        {
            string msbox = "";
            msbox += "<script type=\"text/javascript\">\n";
            msbox += "parent.jsmsg(" + w + "," + h + ",\"" + msgtitle + "\",\"" + msgbox + "\",\"" + url + "\",\"" + msgcss + "\")\n";
            msbox += "</script>\n";
            ClientScript.RegisterClientScriptBlock(Page.GetType(), "JsMsg", msbox);
        }

        /// <summary>
        /// 添加编辑删除提示
        /// </summary>
        /// <param name="msgtitle">提示文字</param>
        /// <param name="url">返回地址</param>
        /// <param name="msgcss">CSS样式</param>
        protected void JscriptPrint(string msgtitle, string url, string msgcss)
        {
            string msbox = "";
            msbox += "<script type=\"text/javascript\">\n";
            msbox += "parent.jsprint(\"" + msgtitle + "\",\"" + url + "\",\"" + msgcss + "\")\n";
            msbox += "</script>\n";
            ClientScript.RegisterClientScriptBlock(Page.GetType(), "JsPrint", msbox);
        }
    }


}
