using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CMS.Web.UI;
using System.Data;

namespace Web.admin.Advertising
{
    public partial class AdvList : ManagePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.PageNavigator1.OnPageChange += new Web.admin.Control.PageChangeHandler(PageNavigator1_OnPageChange);
            if (!IsPostBack)
            {
                InitData();
            }
        }

        private void InitData()
        {
            ListDataBind(1);
        }

        /// <summary>
        /// 绑定数据
        /// </summary>
        /// <param name="PageIndex">页码</param>
        private void ListDataBind(int PageIndex)
        {
            int num = 15, i = 0, j = 0;

            string strWhere = "";

            CMS.DAL.CMS_Advertising dal = new CMS.DAL.CMS_Advertising();

            DataTable dt = dal.GetPagesAll(strWhere, PageIndex, num, out i, out j);
            this.PageNavigator1.PageCount = j;
            this.PageNavigator1.PageIndex = PageIndex;
            this.PageNavigator1.RecordCount = i;
            gvdataList.DataSource = dt;
            gvdataList.DataBind();
        }

        

        void PageNavigator1_OnPageChange(object send, int nPageIndex)
        {
            ListDataBind(nPageIndex);
        }

        protected void lbtnDel_Click(object sender, EventArgs e)
        {

        }
    }
}
