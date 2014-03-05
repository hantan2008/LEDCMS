using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CMS.Web.UI;
using System.Data;

namespace Web.admin.News
{
    public partial class NewsEdit : ManagePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
                {
                    int ID = (Convert.ToInt32(Request.Params["id"]));

                    InitData();
                    ShowInfo(ID);
                }
            }
        }

        /// <summary>
        /// 初始化数据
        /// </summary>
        private void InitData()
        {
            InitDropDownList();
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
        private void ShowInfo(int ID)
        {
            CMS.DAL.CMS_News bll = new CMS.DAL.CMS_News();
            CMS.Model.CMS_News model = bll.GetModel(ID);
            this.hdfid.Value = model.ID.ToString();
            this.txtCMS_Title.Text = model.CMS_Title;
            this.ddlNewType.SelectedValue = model.CMS_Type.ToString();
            this.txtCMS_Author.Text = model.CMS_Author;
            this.txtContent.Value = model.CMS_Content;
            this.txtCMS_Form.Text = model.CMS_Form;
            this.txtCMS_Keyword.Text = model.CMS_Keyword;
            this.txtCMS_Puter.Text = model.CMS_Puter;
            this.txtCMS_Time.Text = model.CMS_Time.ToString();
            this.txtCMS_Click.Text = model.CMS_Click.ToString();
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(this.hdfid.Value);
            string CMS_Title = this.txtCMS_Title.Text;
            int CMS_Type = int.Parse(this.ddlNewType.SelectedValue);
            string CMS_Author = this.txtCMS_Author.Text;
            string CMS_Content = this.txtContent.Value;
            string CMS_Form = this.txtCMS_Form.Text;
            string CMS_Keyword = this.txtCMS_Keyword.Text;
            string CMS_Puter = this.txtCMS_Puter.Text;
            DateTime CMS_Time = DateTime.Parse(this.txtCMS_Time.Text);
            int CMS_Click = int.Parse(this.txtCMS_Click.Text);


            CMS.Model.CMS_News model = new CMS.Model.CMS_News();
            model.ID = ID;
            model.CMS_Title = CMS_Title;
            model.CMS_Type = CMS_Type;
            model.CMS_Author = CMS_Author;
            model.CMS_Content = CMS_Content;
            model.CMS_Form = CMS_Form;
            model.CMS_Keyword = CMS_Keyword;
            model.CMS_Puter = CMS_Puter;
            model.CMS_Time = CMS_Time;
            model.CMS_Click = CMS_Click;

            CMS.DAL.CMS_News bll = new CMS.DAL.CMS_News();
            bll.Update(model);

            JscriptPrint("资讯信息修改成功！", "NewsList.aspx", "Success");
        }
    }
}
