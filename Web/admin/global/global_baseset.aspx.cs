using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CMS.Web.UI;

namespace Web.admin.global
{
    public partial class global_baseset : ManagePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitData();

            }
        }

        /// <summary>
        /// 初始化
        /// </summary>
        private void InitData()
        {
            CMS.Model.CMS_Baseset model = new CMS.Model.CMS_Baseset();
            CMS.DAL.CMS_Baseset dal = new CMS.DAL.CMS_Baseset();
            model = dal.GetModel(1);


            this.hdfid.Value = model.ID.ToString();
            this.txtWebSiteName.Text = model.WebSiteName;
            this.txtCompanyName.Text = model.CompanyName;
            this.txtCompanyTel.Text = model.CompanyTel;
            this.txtCompanyFax.Text = model.CompanyFax;
            this.txtCompanyAddress.Text = model.CompanyAddress;
            this.txtEmail.Text = model.Email;
            this.txtQQ.Text = model.QQ;
        }


        protected void btnSave_Click(object sender, EventArgs e)
        {
            CMS.Model.CMS_Baseset model = new CMS.Model.CMS_Baseset();
            CMS.DAL.CMS_Baseset dal = new CMS.DAL.CMS_Baseset();

            int id = Int32.Parse(this.hdfid.Value);
            string WebSiteName = this.txtWebSiteName.Text;
            string CompanyName = this.txtCompanyName.Text;
            string CompanyTel = this.txtCompanyTel.Text;
            string CompanyFax = this.txtCompanyFax.Text;
            string CompanyAddress = this.txtCompanyAddress.Text;
            string Email = this.txtEmail.Text;
            string QQ = this.txtQQ.Text;

            model.ID = id;
            model.WebSiteName = WebSiteName;
            model.CompanyName = CompanyName;
            model.CompanyTel = CompanyTel;
            model.CompanyFax = CompanyFax;
            model.CompanyAddress = CompanyAddress;
            model.Email = Email;
            model.QQ = QQ;

            if(dal.Update(model))
            {
                JscriptPrint("网站配置修改成功！", "global_baseset.aspx", "Success");
            }

            
        }
    }
}
