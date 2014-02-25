using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CMS.Web.UI;
using System.Data;
using CMS.Common;

namespace Web.admin.Products
{
    public partial class ProductsEdit : ManagePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
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

        private void ShowInfo(int ID)
        {
            CMS.DAL.CMS_Product bll = new CMS.DAL.CMS_Product();
            CMS.Model.CMS_Product model = bll.GetModel(ID);
            this.hdfid.Value = model.ID.ToString();
            this.txtProductName.Text = model.CMS_ProductName;
            this.ddlProductClass.SelectedValue = model.CMS_ProductClassID.ToString();
            this.txtContent.Value = model.CMS_ProductContent;
            this.txtProductImg.Text = model.CMS_ProductImg;

            this.txtPuter.Text = model.CMS_Puter;
            this.cbxIsSlide.Checked = (model.CMS_IsSlide == 1) ? true : false;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(this.hdfid.Value);
            string CMS_ProductName = this.txtProductName.Text;
            int CMS_ProductClassID = int.Parse(this.ddlProductClass.SelectedValue);
            string CMS_ProductContent = this.txtContent.Value;
            string CMS_ProductImg = this.txtProductImg.Text;
            DateTime CMS_AddTime = DateTime.Now; ;
            string CMS_Puter = this.txtPuter.Text;
            int CMS_IsSlide = (cbxIsSlide.Checked)?1:0;


            CMS.Model.CMS_Product model = new CMS.Model.CMS_Product();
            model.ID = ID;
            model.CMS_ProductName = CMS_ProductName;
            model.CMS_ProductClassID = CMS_ProductClassID;
            model.CMS_ProductContent = CMS_ProductContent;
            model.CMS_ProductImg = CMS_ProductImg;
            model.CMS_AddTime = CMS_AddTime;
            model.CMS_Puter = CMS_Puter;
            model.CMS_IsSlide = CMS_IsSlide;

            CMS.DAL.CMS_Product bll = new CMS.DAL.CMS_Product();
            bll.Update(model);

            JscriptPrint("产品信息修改成功！", "ProductsList.aspx", "Success");
        }
    }
}
