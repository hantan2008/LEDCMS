using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;
using System.Text;
using CMS.Web.UI;

namespace Web
{
    public partial class _Default : BasePage
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
           //载入首页新闻
            InitNewsList();
            //载入公司简介
            InitCompanyAbout();
            //载入首页推荐产品
            InitIndexProduct();
            //载入首页产品类别
            InitIndexProductClass();
        }
        /// <summary>
        /// 
        /// </summary>
        private void InitIndexProductClass()
        {
            CMS.DAL.CMS_ProductClass dal = new CMS.DAL.CMS_ProductClass();
            DataTable dt = dal.GetList(" CMS_PID  =0").Tables[0];

            this.RepeaterProducts.DataSource = dt.DefaultView;
            this.RepeaterProducts.DataBind();
        }

        /// <summary>
        /// 载入首页推荐产品
        /// </summary>
        private void InitIndexProduct()
        {
            StringBuilder strHTML = new StringBuilder();
            strHTML.Append("<table style=\"width: 100%;\" align=\"left\" cellpadding=\"0\" cellspacing=\"0\" border=\"0\">");
            strHTML.Append("<tr>");
            CMS.DAL.CMS_Product dal = new CMS.DAL.CMS_Product();
            DataTable dt =  dal.GetFlashList();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string strID = dt.Rows[i]["ID"].ToString();
                string strProductImg = dt.Rows[i]["CMS_ProductImg"].ToString();
                string strProductName = dt.Rows[i]["CMS_ProductName"].ToString();

                strHTML.Append("<td valign=\"top\" width=\"150\">");
                strHTML.Append("<a href=\"ProductView.aspx?id=" + strID + " \"  target=\"_blank\"> <img src=\"" + strProductImg + "\" alt=\"\" width=\"150\" height=\"150\" border=\"0\" /></a>");
                strHTML.Append(" ");
                strHTML.Append("<span style=\"text-align:center\">" + strProductName + "</span>");
                strHTML.Append("</td>");
                strHTML.Append("<td valign=\"top\" width=\"5px\">");
                strHTML.Append("</td>");
            }
            strHTML.Append("</tr>");
            strHTML.Append("</table>");

            this.ltrIndexProductHTML.Text = strHTML.ToString();
        }

        

        /// <summary>
        /// 载入公司简介
        /// </summary>
        private void InitCompanyAbout()
        {
            CMS.DAL.CMS_Contents dal = new CMS.DAL.CMS_Contents();
            CMS.Model.CMS_Contents model = new CMS.Model.CMS_Contents();
            model = dal.GetModelByCallIndex("about");

            if (model.CMS_Content.ToString().Length > 350)
            {
                this.lblAbout.Text = model.CMS_Content.ToString().Substring(0, 350) + "...";
            }
             
        }

        /// <summary>
        /// 载入首页新闻
        /// </summary>
        private void InitNewsList()
        {
            CMS.DAL.CMS_News dal = new CMS.DAL.CMS_News();
            DataTable dt = dal.GetTopList(6," "," order by id desc").Tables[0];

            this.RepeaterNews.DataSource = dt.DefaultView;
            this.RepeaterNews.DataBind();
        }


    }
}
