using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CMS.Web.UI;

namespace Web.admin.Contents
{
    public partial class About : ManagePage
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
            this.hdfcallindex.Value = "about";

            CMS.DAL.CMS_Contents dal = new CMS.DAL.CMS_Contents();
            CMS.Model.CMS_Contents model = new CMS.Model.CMS_Contents();
            model = dal.GetModelByCallIndex("about");

            this.txtContent.Value = model.CMS_Content.ToString();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string CMS_CallIndex = this.hdfcallindex.Value;
            string CMS_Title = this.txtCMS_Title.Text;
            string CMS_Content = this.txtContent.Value;


            CMS.Model.CMS_Contents model = new CMS.Model.CMS_Contents();
            model.CMS_CallIndex = CMS_CallIndex;
            model.CMS_Title = CMS_Title;
            model.CMS_Content = CMS_Content;

            CMS.DAL.CMS_Contents dal = new CMS.DAL.CMS_Contents();
            dal.UpdateByCallindex(model);


            this.Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "js", "<script>alert('修改成功!');</script>");
        }
    }
}
