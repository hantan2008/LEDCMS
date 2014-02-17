using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Web.Control
{
    public partial class ProductClass : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //载入首页产品类别
                InitIndexProductClass();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void InitIndexProductClass()
        {
            CMS.DAL.CMS_ProductClass dal = new CMS.DAL.CMS_ProductClass();
            DataTable dt = dal.GetList(" CMS_PID  =0").Tables[0];

            this.RepeaterProducts.DataSource = dt.DefaultView;
            this.RepeaterProducts.DataBind();
        }
    }
}