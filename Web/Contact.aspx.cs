using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace Web
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitData();
            }
        }

        /// <summary>
        /// 初始化
        /// </summary>
        private void InitData()
        {
            string callindex = "contact";

            CMS.DAL.CMS_Contents dal = new CMS.DAL.CMS_Contents();
            CMS.Model.CMS_Contents model = new CMS.Model.CMS_Contents();
            model = dal.GetModelByCallIndex(callindex);

            this.lblContent.Text = model.CMS_Content.ToString();
        }
    }
}
