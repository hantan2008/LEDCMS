using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CMS.Web.UI;

namespace Web
{
    public partial class News : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.PageNavigator1.OnPageChange += new Web.Control.PageChangeHandler(PageNavigator1_OnPageChange);
            if (!IsPostBack)
            {
                ListDataBind(1);
            }
        }

        /// <summary>
        /// 绑定数据
        /// </summary>
        /// <param name="PageIndex">页码</param>
        private void ListDataBind(int PageIndex)
        {
            int num = 15, i = 0, j = 0;

            CMS.DAL.CMS_News dal = new CMS.DAL.CMS_News();

            DataTable dt = dal.GetAll(null, null, PageIndex, num, out i, out j);
            this.PageNavigator1.PageCount = j;
            this.PageNavigator1.PageIndex = PageIndex;
            this.PageNavigator1.RecordCount = i;

            this.datalistnews.DataSource = dt;
            this.datalistnews.DataBind();
        }

        void PageNavigator1_OnPageChange(object send, int nPageIndex)
        {
            ListDataBind(nPageIndex);
        }
    }
}
