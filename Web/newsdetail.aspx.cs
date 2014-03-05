using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CMS.Web.UI;

namespace Web
{
    public partial class newsdetail : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitData();

            }
        }

        /// <summary>
        /// 初始化数据
        /// </summary>
        private void InitData()
        {
            if (!string.IsNullOrEmpty(Request.QueryString["id"]))
            {
                int id = Int32.Parse(Request.QueryString["id"]);

                CMS.Model.CMS_News model = new CMS.Model.CMS_News();
                CMS.DAL.CMS_News dal = new CMS.DAL.CMS_News();

                model = dal.GetModel(id);

                this.lblTitle.Text = model.CMS_Title.ToString();
                this.lblTime.Text = model.CMS_Time.ToShortDateString();
                this.lblForm.Text = model.CMS_Form.ToString();
                this.lblAuthor.Text = model.CMS_Author.ToString();
                this.lblClick.Text = model.CMS_Click.ToString();
                this.lblContent.Text = model.CMS_Content.ToString();
            }
        }
    }
}
