using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CMS.Common;

namespace CMS.Web.UI
{
    public class BasePage : System.Web.UI.Page
    {
        protected internal CMS.Model.WebSet SiteConfig = new CMS.DAL.WebSet().loadConfig(Utils.GetXmlMapPath("Configpath"));

        public BasePage()
        {

        }

        /// <summary>
        /// 返回页面Meta信息
        /// </summary>
        protected string AddMetaInfo(string _keywords, string _description)
        {
            StringBuilder strTxt = new StringBuilder();
            strTxt.Append("<meta name=\"keywords\" content=\"" + Utils.DropHTML(_keywords, 250).Replace("\"", " ") + "\" />\n");
            strTxt.Append("<meta name=\"description\" content=\"" + Utils.DropHTML(_description, 250).Replace("\"", " ") + "\" />");
            return strTxt.ToString();
        }
    }
}
