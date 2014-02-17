using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

namespace Web
{
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.PageNavigator1.OnPageChange += new Web.Control.PageChangeHandler(PageNavigator1_OnPageChange);
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

            CMS.DAL.CMS_Product dal = new CMS.DAL.CMS_Product();
            CMS.DAL.CMS_ProductClass dalClass = new CMS.DAL.CMS_ProductClass();

            string strWhere = "";
            if (!string.IsNullOrEmpty(Request.QueryString["class"]))
            {
                string strclassid = Request.QueryString["class"];
                int classid = int.Parse(strclassid);
                CMS.Model.CMS_ProductClass model = dalClass.GetModel(classid);
                string classidlist = model.CMS_ClassIdList;//树结构列表

                StringBuilder strSql = new StringBuilder();
                strSql.Append("SELECT ID  FROM CMS_ProductClass");
                strSql.Append(" where CMS_ClassIdList like '" + classidlist + "%'");

                strWhere = " CMS_ProductClassID in ("+strSql.ToString()+")";
            }
            
            
             



            DataTable dt = dal.GetPagesAll(strWhere, PageIndex, num, out i, out j);
            this.PageNavigator1.PageCount = j;
            this.PageNavigator1.PageIndex = PageIndex;
            this.PageNavigator1.RecordCount = i;

            this.Repeater1.DataSource = dt;
            this.Repeater1.DataBind();
        }

        void PageNavigator1_OnPageChange(object send, int nPageIndex)
        {
            ListDataBind(nPageIndex);
        }
    }
}
