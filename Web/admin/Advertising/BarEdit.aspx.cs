using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Web.admin.Advertising
{
    public partial class BarEdit : CMS.Web.UI.ManagePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitData();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void InitData()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(Server.MapPath("~/swf/imgList.xml"));
            XmlNode imgListNode = xmlDoc.SelectSingleNode("imgList");
            
            XmlNode picNode =imgListNode.SelectSingleNode("pic");
            int i = 0;
            foreach (XmlNode node in picNode)
            {
                
                XmlElement xe = (XmlElement)node;
                this.txtProductImg.Text = xe.GetAttribute("path");
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}