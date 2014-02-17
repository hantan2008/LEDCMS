using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CMS.Web.UI;

namespace Web.admin.sysManage.MenuManage
{
    public partial class MenuList : ManagePage
    {
        CMS.DAL.CMS_SysMod dal = new CMS.DAL.CMS_SysMod();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitData();
            }
        }

        private void InitData()
        {
            DataTable dt = new DataTable();
            dt = dal.GetListFromPID(0); 

            this.rptClassList.DataSource = dt;
            this.rptClassList.DataBind();
        }

        protected void rptClassList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }

        protected void rptClassList_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
            {
                Literal LitFirst = (Literal)e.Item.FindControl("LitFirst");
                HiddenField txtClassLayer = (HiddenField)e.Item.FindControl("txtClassLayer");
                string LitStyle = "<span style=width:{0}px;text-align:right;display:inline-block;>{1}{2}</span>";
                string LitImg1 = "<img src=../../images/folder_open.gif align=absmiddle />";
                string LitImg2 = "<img src=../../images/t.gif align=absmiddle />";

                int classLayer = Convert.ToInt32(txtClassLayer.Value);
                if (classLayer == 1)
                {
                    LitFirst.Text = LitImg1;
                }
                else
                {
                    LitFirst.Text = string.Format(LitStyle, classLayer * 18, LitImg2, LitImg1);
                }
            }
        }
    }
}