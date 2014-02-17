using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CMS.Common;
using CMS.Web.UI;

namespace Web.admin.Products
{
    public partial class ProductsAdd : ManagePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitData();
            }
        }

        #region 初始化
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
            CMS.DAL.CMS_ProductClass dal = new CMS.DAL.CMS_ProductClass();
            DataSet ds = dal.GetList("");

            this.ddlProductClass.Items.Add(new ListItem("<==请选择==>", "0"));

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ListItem item = new ListItem();
                int ClassLayer = int.Parse(ds.Tables[0].Rows[i]["CMS_ClassLayer"].ToString());
                string strName = ds.Tables[0].Rows[i]["CMS_ClassName"].ToString();
                string strValue = ds.Tables[0].Rows[i]["ID"].ToString();
                if (ClassLayer > 1)
                {
                    strName = Utils.StringOfChar(ClassLayer - 1, "　|-") + strName;

                }

                item.Text = strName;
                item.Value = strValue;
                this.ddlProductClass.Items.Add(item);
            }



        }
        #endregion

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string CMS_ProductName = this.txtProductName.Text;
            int CMS_ProductClassID = int.Parse(ddlProductClass.SelectedValue);
            string CMS_ProductContent = this.txtContent.Value;
            string CMS_ProductImg = this.txtProductImg.Text;
            string CMS_Puter = this.txtPuter.Text;
            int IsSlide = (cbxIsSlide.Checked) ? 1 : 0;

            CMS.Model.CMS_Product model = new CMS.Model.CMS_Product();
            model.CMS_ProductName = CMS_ProductName;
            model.CMS_ProductClassID = CMS_ProductClassID;
            model.CMS_ProductContent = CMS_ProductContent;
            model.CMS_ProductImg = CMS_ProductImg;
            model.CMS_AddTime = DateTime.Now;
            model.CMS_Puter = CMS_Puter;
            model.CMS_IsSlide = IsSlide;

            CMS.DAL.CMS_Product dal = new CMS.DAL.CMS_Product();
            dal.Add(model);

            string js = "window.location.href('ProductsList.aspx');";
            this.Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "js", "<script>alert('修改成功!');"+js+"</script>");

        }
    }
}
