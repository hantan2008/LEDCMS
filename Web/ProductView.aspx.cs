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
using System.Text;
using CMS.Web.UI;

namespace Web
{
    public partial class ProductView : BasePage
    {
        

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

                 CMS.Model.CMS_Product model = new CMS.Model.CMS_Product();
                CMS.DAL.CMS_Product dal = new CMS.DAL.CMS_Product();

                model = dal.GetModel(id);

                string ProductImg = model.CMS_ProductImg;
                string ProductName = model.CMS_ProductName;

                StringBuilder str = new StringBuilder();
                str.Append("<a href='" + ProductImg + "' title=\"" + ProductName + "\">");
                str.Append("<img alt=\"" + ProductName + "\" src=\"" + ProductImg + "\"  Width=\"300\" Height=\"300\" class=\"photo\"/>");
                str.Append("</a>");

                this.lblimgproduct.Text = str.ToString();                
                
                this.lblProductName.Text = model.CMS_ProductName;
                this.lblProductClass.Text = model.CMS_ProductClassID.ToString();
                this.lblContent.Text = model.CMS_ProductContent;
            }
        }
    }
}
