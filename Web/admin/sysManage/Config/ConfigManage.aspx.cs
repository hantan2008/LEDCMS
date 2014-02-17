using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CMS.Web.UI;
using System.Configuration;

namespace Web.admin.sysManage.Config
{
    public partial class ConfigManage : ManagePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                LoadWevSet();
            }

        }

        /// <summary>
        /// 
        /// </summary>
        public void LoadWevSet()
        {
            //赋值给对应的控件
            txtWebName.Text = webset.WebName;
            txtWebUrl.Text = webset.WebUrl;
            txtWebTel.Text = webset.WebTel;
            txtWebFax.Text = webset.WebFax;
            txtWebEmail.Text = webset.WebEmail;
            txtWebCrod.Text = webset.WebCrod;
            txtWebKeywords.Text = webset.WebKeywords.ToString();
            txtWebDescription.Text = webset.WebDescription.ToString();
            txtWebCopyright.Text = webset.WebCopyright;

            //txtWebPath.Text = webset.WebPath;
            //txtWebManagePath.Text = webset.WebManagePath;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            //赋值给MODEL
            CMS.Model.WebSet model = new CMS.Model.WebSet();
            model.WebName = txtWebName.Text;
            model.WebUrl = txtWebUrl.Text;
            model.WebTel = txtWebTel.Text;
            model.WebFax = txtWebFax.Text;
            model.WebEmail = txtWebEmail.Text;
            model.WebCrod = txtWebCrod.Text;
            model.WebCopyright = txtWebCopyright.Text;
            model.WebKeywords = txtWebKeywords.Text.Trim();
            model.WebDescription = txtWebDescription.Text.Trim();

            //修改配置信息
            CMS.DAL.WebSet dal = new CMS.DAL.WebSet();
            dal.saveConifg(model, Server.MapPath(ConfigurationManager.AppSettings["Configpath"].ToString()));

            JscriptPrint("系统设置成功啦！", "ConfigManage.aspx", "Success");
        }
    }
}