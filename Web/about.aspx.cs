using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class about : System.Web.UI.Page
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
            string callindex = "about";

            CMS.DAL.CMS_Contents dal = new CMS.DAL.CMS_Contents();
            CMS.Model.CMS_Contents model = new CMS.Model.CMS_Contents();
            model = dal.GetModelByCallIndex(callindex);

            this.lblContent.Text = model.CMS_Content.ToString();
        }
    }
}
