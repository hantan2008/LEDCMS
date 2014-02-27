using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CMS.Web.UI;
using System.Data;

namespace Web.admin.Contents
{
    public partial class ContentList : ManagePage
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            this.PageNavigator1.OnPageChange += new Web.admin.Control.PageChangeHandler(PageNavigator1_OnPageChange);
            if (!IsPostBack)
            {
                if (Request.Params["Index"] != null && Request.Params["Index"].Trim() != "")
                {
                    string strIndex = Request.Params["Index"].ToString().ToLower();
                    if (strIndex == "about")
                    {
                        Response.Redirect("About.aspx");
                    }

                    if (strIndex == "contact")
                    {
                        Response.Redirect("Contact.aspx");
                    }

                }
                else
                {
                    ListDataBind(1);
                }
            }
        }

         /// <summary>
        /// 绑定数据
        /// </summary>
        /// <param name="PageIndex">页码</param>
        private void ListDataBind(int PageIndex)
        {
            int num = 15, i = 0, j = 0;

            CMS.DAL.CMS_Contents dal = new CMS.DAL.CMS_Contents();

            DataTable dt = dal.GetAll(null, null, PageIndex, num, out i, out j);
            this.PageNavigator1.PageCount = j;
            this.PageNavigator1.PageIndex = PageIndex;
            this.PageNavigator1.RecordCount = i;
            gvNewList.DataSource = dt;
            gvNewList.DataBind();
        }
        /// <summary>
        /// 换行事件处理
        /// </summary>
        /// <param name="send"></param>
        /// <param name="nPageIndex"></param>
         void PageNavigator1_OnPageChange(object send, int nPageIndex)
        {
            ListDataBind(nPageIndex);
        }
    }
}