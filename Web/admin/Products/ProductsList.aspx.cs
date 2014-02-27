using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Web.admin.Products
{
    public partial class ProductsList : CMS.Web.UI.ManagePage
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

            CMS.DAL.CMS_Product dal = new CMS.DAL.CMS_Product();

            DataTable dt = dal.GetPagesAll(strWhere,PageIndex, num, out i, out j);
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
            CMS.DAL.CMS_Product dal = new CMS.DAL.CMS_Product();
            CMS.Model.CMS_Product model = new CMS.Model.CMS_Product();

            for (int i = 0; i < gvdataList.Rows.Count; i++)
            {
                Label label = (Label)gvdataList.Rows[i].FindControl("lb_id");
                int id = Convert.ToInt32(label.Text);
                CheckBox cb = (CheckBox)gvdataList.Rows[i].FindControl("cb_id");
                if (cb.Checked)
                {
                    model = dal.GetModel(id);
                    //删除图片
                    DeleteFile(model.CMS_ProductImg);
                    //保存日志
                   // SaveLogs("[资讯模块]删除文章：" + model.Title);
                    //删除记录
                    //bll.Delete(kindId, id);
                    dal.Delete(id);
                }
            }

            JscriptPrint("批量删除成功啦！", "ProductsList.aspx", "Success");
           
        }

        /// <summary>
        /// 根据类别ID得到产品类别名称
        /// </summary>
        /// <param name="ProductClassID"></param>
        /// <returns></returns>
        public string getProductClassName(int ProductClassID)
        {
            string strClassName = "";
            CMS.DAL.CMS_ProductClass dal = new CMS.DAL.CMS_ProductClass();
            CMS.Model.CMS_ProductClass model = dal.GetModel(ProductClassID);

            strClassName = model.CMS_ClassName;
            return strClassName;
        }
    }
}
