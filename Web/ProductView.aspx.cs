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
    public partial class ProductView : System.Web.UI.Page
    {
        public CMS.Model.CMS_Product model;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitData();

            }
        }

        private void InitData()
        {
            if (!string.IsNullOrEmpty(Request.QueryString["id"]))
            {
                int id = Int32.Parse(Request.QueryString["id"]);

                model = new CMS.Model.CMS_Product();
                CMS.DAL.CMS_Product dal = new CMS.DAL.CMS_Product();

                model = dal.GetModel(id);

                this.imgproduct.ImageUrl = model.CMS_ProductImg.ToString();
                this.lblProductName.Text = model.CMS_ProductName;
                this.lblProductClass.Text = model.CMS_ProductClassID.ToString();
                this.lblContent.Text = model.CMS_ProductContent;
            }
        }
    }
}
