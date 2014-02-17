using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CMS.Web.UI;

namespace Web.admin.News
{
    public partial class NewsAdd : ManagePage
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
            InitDropDownList();
            this.txtCMS_Time.Text = DateTime.Now.ToString();//时间
        }

        /// <summary>
        /// 初始化下拉列表
        /// </summary>
        private void InitDropDownList()
        {
            CMS.DAL.CMS_NewsType dal = new CMS.DAL.CMS_NewsType();
            DataSet ds = dal.GetList("");

            this.ddlNewType.Items.Add(new ListItem("<==请选择==>", "0"));

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
			{
                ListItem item = new ListItem();
                item.Text = ds.Tables[0].Rows[i]["CMS_TypeName"].ToString();
                item.Value = ds.Tables[0].Rows[i]["ID"].ToString();
                this.ddlNewType.Items.Add(item);
			}

           
            
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            int CMS_Click = int.Parse(this.txtCMS_Click.Text);
            string CMS_Title = this.txtCMS_Title.Text;
            int CMS_Type = int.Parse(this.ddlNewType.SelectedValue);
            string CMS_Author = this.txtCMS_Author.Text;
            string CMS_Content = this.txtContent.Value;
            string CMS_Form = this.txtCMS_Form.Text;
            string CMS_Keyword = this.txtCMS_Keyword.Text;
            string CMS_Puter = this.txtCMS_Puter.Text;
            DateTime CMS_Time = DateTime.Parse(this.txtCMS_Time.Text);

            CMS.Model.CMS_News model = new CMS.Model.CMS_News();
            model.CMS_Click = CMS_Click;
            model.CMS_Title = CMS_Title;
            model.CMS_Type = CMS_Type;
            model.CMS_Author = CMS_Author;
            model.CMS_Content = CMS_Content;
            model.CMS_Form = CMS_Form;
            model.CMS_Keyword = CMS_Keyword;
            model.CMS_Puter = CMS_Puter;
            model.CMS_Time = CMS_Time;

            CMS.DAL.CMS_News dal = new CMS.DAL.CMS_News();
            dal.Add(model);


            string js = "window.location.href('NewsList.aspx');";
            this.Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "js", "<script>alert('修改成功!');" + js + "</script>");
        }
    }
}
