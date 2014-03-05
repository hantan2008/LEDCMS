using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CMS.Web.UI;

namespace Web.admin
{
    public partial class Admin_Center : ManagePage
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

            lblWebSiteName.Text = webset.WebName;
            lblDDNS.Text = webset.WebUrl;
            lblPath.Text = webset.WebPath;
            lblAdminPath.Text = webset.WebManagePath;
            lblTel.Text = webset.WebTel;
            lblfax.Text = webset.WebFax;
            lblEmail.Text = webset.WebEmail;

        }
    }
}