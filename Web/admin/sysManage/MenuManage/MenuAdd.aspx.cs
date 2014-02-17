using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CMS.Web.UI;

namespace Web.admin.sysManage.MenuManage
{
    public partial class MenuAdd : ManagePage
    {
        int parentid=0;
        CMS.DAL.CMS_SysMod dal = new CMS.DAL.CMS_SysMod();
        CMS.Model.CMS_SysMod ParentModel = new CMS.Model.CMS_SysMod();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.Params["parentid"] != null && Request.Params["parentid"].Trim() != "")
            {
                parentid = Int32.Parse(Request.Params["parentid"].Trim());
            }

            if (!IsPostBack)
            {
                InitData();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void InitData()
        {
            if (parentid != 0)
            {
                

                ParentModel = dal.GetModel(parentid);


                this.lblPMod_name.Text = ParentModel.mod_name;
            }
            else
            {
                this.lblPMod_name.Text = "顶级菜单";
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            CMS.Model.CMS_SysMod Model = new CMS.Model.CMS_SysMod();

            ParentModel = dal.GetModel(parentid);

            string mod_name = this.txtmod_name.Text;
            int mod_parentid = parentid;
            //string mod_defaultpage = this.txtmod_defaultpage.Text;
            string mod_URL = this.txtmod_URL.Text;
            int mod_level = (ParentModel != null) ? ParentModel.mod_level + 1 : 1;//int.Parse(this.txtmod_level.Text);
            //bool mod_enable = this.chkmod_enable.Checked;
            string mod_desc = this.txtmod_desc.Text;
            int mod_sortnum = int.Parse(this.txtmod_sortnum.Text);
            bool mod_isvisible = this.cbxisvisible.Checked;

            CMS.Model.CMS_SysMod model = new CMS.Model.CMS_SysMod();
            model.mod_name = mod_name;
            model.mod_parentid = mod_parentid;
            //model.mod_defaultpage = mod_defaultpage;
            model.mod_URL = mod_URL;
            model.mod_level = mod_level;
            //model.mod_enable = mod_enable;
            model.mod_desc = mod_desc;
            model.mod_sortnum = mod_sortnum;
            model.mod_isvisible = mod_isvisible;


            dal.Add(model);

            JscriptPrint("菜单添加成功啦！", "MenuList.aspx", "Success");
            


        }
    }
}