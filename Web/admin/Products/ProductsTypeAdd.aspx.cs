using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Web.admin.Products
{
    public partial class ProductsTypeAdd : System.Web.UI.Page
    {
        CMS.DAL.CMS_ProductClass dal = new CMS.DAL.CMS_ProductClass();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["classId"]))
            {
                this.hdfPid.Value = Request.QueryString["classId"];
                int id = int.Parse(Request.QueryString["classId"].ToString());

                CMS.Model.CMS_ProductClass model = dal.GetModel(id);
                string PTitle = model.CMS_ClassName;
                this.lblPtitle.Text = PTitle;
                this.hdfClassLayer.Value = (model.CMS_ClassLayer + 1).ToString();
            }
            else
            {
                this.lblPtitle.Text = "顶级类别";
                this.hdfPid.Value = "0";
                this.hdfClassLayer.Value = "1";
            }

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            CMS.Model.CMS_ProductClass model = new CMS.Model.CMS_ProductClass();
           string classList = "";
            int PID = int.Parse(this.hdfPid.Value);

            model.CMS_ClassName = this.txtCMS_ClassName.Text.Trim();
            model.CMS_Memo = this.txtCMS_Memo.Text.Trim();
            model.CMS_PID = PID;
            model.SortId = Int32.Parse(this.txtShort.Text.Trim());
            model.CMS_ClassLayer = Int32.Parse(this.hdfClassLayer.Value);

            int id = dal.Add(model);

            if (PID > 0)
            {
                
                DataSet ds = dal.GetList(" id = "+PID+"");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = ds.Tables[0].Rows[0];
                    classList = dr["CMS_ClassIdList"].ToString().Trim() + id + ",";
                }
            }
            else
            {
                classList = "," + id + ",";
            }
            model.ID = id;
            model.CMS_ClassIdList = classList;

            dal.Update(model);


            string js = "window.location.href('ProductsTypeList.aspx');";
            this.Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "js", "<script>alert('修改成功!');"+js+"</script>");
        }
    }
}
