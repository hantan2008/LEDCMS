using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CMS.Web.UI;

namespace Web.admin.News
{
    public partial class NewsTypeList : ManagePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitData();
            }
        }

        /// <summary>
        /// 初始化数据
        /// </summary>
        private void InitData()
        {
                CMS.DAL.CMS_NewsType dal = new CMS.DAL.CMS_NewsType();
                DataTable dt = dal.GetList("").Tables[0];

                this.rptClassList.DataSource = dt;
                this.rptClassList.DataBind();
        }

        protected void rptClassList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }

        protected void rptClassList_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {

        }
    }
}
