using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CMS.Web.UI;

namespace Web.admin
{
    public partial class admin_index : ManagePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.lblAdminName.Text = "admin";

                CMS.DAL.CMS_SysMod dal = new CMS.DAL.CMS_SysMod();
                DataSet ds = dal.GetList("mod_level=1 and mod_isvisible = 1");

                this.RepeaterMainMenu.DataSource = ds;
                this.RepeaterMainMenu.DataBind();

                this.RepeaterMainMenu1.DataSource = ds;
                this.RepeaterMainMenu1.DataBind();

                DataSet dsChild = dal.GetList("mod_level=2 and mod_isvisible = 1");
                this.RepeaterChild.DataSource = dsChild;
                this.RepeaterChild.DataBind();
            }
        }

        protected void lbtnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
