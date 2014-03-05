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
    public partial class NewsList : ManagePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.PageNavigator1.OnPageChange += new Web.admin.Control.PageChangeHandler(PageNavigator1_OnPageChange);
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
            gvdataList.DataSource = dt;
            gvdataList.DataBind();
        }

        void PageNavigator1_OnPageChange(object send, int nPageIndex)
        {
            ListDataBind(nPageIndex);
        }


        protected void lbtnDel_Click(object sender, EventArgs e)
        {
            CMS.DAL.CMS_News dal = new CMS.DAL.CMS_News();

            for (int i = 0; i < gvdataList.Rows.Count; i++)
            {
                Label label = (Label)gvdataList.Rows[i].FindControl("lb_id");
                int id = Convert.ToInt32(label.Text);
                CheckBox cb = (CheckBox)gvdataList.Rows[i].FindControl("cb_id");
                if (cb.Checked)
                {
                    //保存日志
                    // SaveLogs("[资讯模块]删除文章：" + model.Title);
                    //删除记录
                    //bll.Delete(kindId, id);
                    dal.Delete(id);
                }
            }

            JscriptPrint("批量删除成功啦！", "NewsList.aspx", "Success");

        }
        /// <summary>
        /// 根据类型ID获取类型名称
        /// </summary>
        /// <param name="ClassID"></param>
        /// <returns></returns>
        public string getClassName(int ClassID)
        {
            string strClassName = "";
            CMS.DAL.CMS_NewsType dal = new CMS.DAL.CMS_NewsType();
            CMS.Model.CMS_NewsType model = dal.GetModel(ClassID);

            strClassName = model.CMS_TypeName;
            return strClassName;
        }
    }
}
