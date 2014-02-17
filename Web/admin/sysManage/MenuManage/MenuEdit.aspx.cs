using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CMS.Web.UI;

namespace Web.admin.sysManage.MenuManage
{
    public partial class MenuEdit : ManagePage
    {
        int id;
        CMS.DAL.CMS_SysMod dal = new CMS.DAL.CMS_SysMod();
        CMS.Model.CMS_SysMod model = new CMS.Model.CMS_SysMod();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Int32.TryParse(Request.Params["id"] as string, out this.id))
            {
                JscriptMsg(350, 230, "错误提示", "<b>出现错误啦！</b>您要修改类别的种类不明确或参数不正确。", "back", "Error");
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
            model = dal.GetModel(id);
            this.txtmod_name.Text = model.mod_name;
            this.txtmod_URL.Text = model.mod_URL;
            this.cbxisvisible.Checked = model.mod_isvisible ? true : false;
            this.txtmod_sortnum.Text = model.mod_sortnum.ToString();
            this.txtmod_desc.Text = model.mod_desc;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            model = dal.GetModel(id);
            //int id = int.Parse(this.hdfid.Value);
            string mod_name = this.txtmod_name.Text;
            //int mod_parentid = int.Parse(this.txtmod_parentid.Text);
            //string mod_defaultpage = this.txtmod_defaultpage.Text;
            string mod_URL = this.txtmod_URL.Text;
            //int mod_level = int.Parse(this.txtmod_level.Text);
            //bool mod_enable = this.chkmod_enable.Checked;
            string mod_desc = this.txtmod_desc.Text;
            int mod_sortnum = int.Parse(this.txtmod_sortnum.Text);
            bool mod_isvisible = this.cbxisvisible.Checked;


            //model.id = id;
            model.mod_name = mod_name;
            //model.mod_parentid = mod_parentid;
            //model.mod_defaultpage = mod_defaultpage;
            model.mod_URL = mod_URL;
            //model.mod_level = mod_level;
            //model.mod_enable = mod_enable;
            model.mod_desc = mod_desc;
            model.mod_sortnum = mod_sortnum;
            model.mod_isvisible = mod_isvisible;


            if (dal.Update(model))
            {
                JscriptPrint("菜单修改成功！", "MenuList.aspx", "Success");
            }


        }
    }
}