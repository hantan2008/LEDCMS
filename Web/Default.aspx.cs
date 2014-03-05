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
            //载入成功案例
            InitProject();
            //载入首页推荐产品
            InitIndexProduct();
            //载入首页产品类别
            InitIndexProductClass();
        }

        private void InitProject()
        {
            StringBuilder strHTML = new StringBuilder();
            strHTML.Append("");
            strHTML.Append("    <script type=\"text/javascript\">").Append(Environment.NewLine);
            strHTML.Append("    var pic_width = 292; //图片宽度").Append(Environment.NewLine);
            strHTML.Append("    var pic_height = 200; //图片高度").Append(Environment.NewLine);
            strHTML.Append("    var button_pos = 1; //按扭位置 1左 2右 3上 4下").Append(Environment.NewLine);
            strHTML.Append("    var stop_time = 3000; //图片停留时间(1000为1秒钟)").Append(Environment.NewLine);
            strHTML.Append("    var show_text = 0; //是否显示文字标签 1显示 0不显示").Append(Environment.NewLine);
            strHTML.Append("    var txtcolor = \"000000\"; //文字色").Append(Environment.NewLine);
            strHTML.Append("    var bgcolor = \"DDDDDD\"; //背景色").Append(Environment.NewLine);
            strHTML.Append("    var imag = new Array();").Append(Environment.NewLine);
            strHTML.Append("    var link = new Array();").Append(Environment.NewLine);
            strHTML.Append("    var text = new Array();").Append(Environment.NewLine);

            for (int i = 0; i < 5; i++)
            {
                string strimg = "images/01.jpg";
                string strlink = "http://www.chinaz.com/";
                string strtext = "标题 1";

                strHTML.Append("    imag[" + i + "] = '" + strimg + "';").Append(Environment.NewLine);
                strHTML.Append("    link[" + i + "] = '" + strlink + "';").Append(Environment.NewLine);
                strHTML.Append("    text[" + i + "] = '" + strtext + "';").Append(Environment.NewLine);
            }            

            strHTML.Append("    //可编辑内容结束").Append(Environment.NewLine);
            strHTML.Append("    var swf_height = show_text == 1 ? pic_height + 20 : pic_height;").Append(Environment.NewLine);
            strHTML.Append("    var pics = \"\", links = \"\", texts = \"\";").Append(Environment.NewLine);
            strHTML.Append("    for (var i = 1; i < imag.length; i++) {").Append(Environment.NewLine);
            strHTML.Append("        pics = pics + (\"|\" + imag[i]);").Append(Environment.NewLine);
            strHTML.Append("        links = links + (\"|\" + link[i]);").Append(Environment.NewLine);
            strHTML.Append("        texts = texts + (\"|\" + text[i]);").Append(Environment.NewLine);
            strHTML.Append("    }").Append(Environment.NewLine);
            strHTML.Append("    pics = pics.substring(1);").Append(Environment.NewLine);
            strHTML.Append("    links = links.substring(1);").Append(Environment.NewLine);
            strHTML.Append("    texts = texts.substring(1);").Append(Environment.NewLine);
            strHTML.Append("    document.write('<object classid=\"clsid:d27cdb6e-ae6d-11cf-96b8-444553540000\" codebase=\"http://fpdownload.macromedia.com/pub/shockwave/cabs/flash/swflash.cabversion=6,0,0,0\" width=\"' + pic_width + '\" height=\"' + swf_height + '\">');").Append(Environment.NewLine);
            strHTML.Append("    document.write('<param name=\"movie\" value=\"flash/focus.swf\">');").Append(Environment.NewLine);
            strHTML.Append("    document.write('<param name=\"quality\" value=\"high\"><param name=\"wmode\" value=\"opaque\">');").Append(Environment.NewLine);
            strHTML.Append("    document.write('<param name=\"FlashVars\" value=\"pics=' + pics + '&links=' + links + '&texts=' + texts + '&pic_width=' + pic_width + '&pic_height=' + pic_height + '&show_text=' + show_text + '&txtcolor=' + txtcolor + '&bgcolor=' + bgcolor + '&button_pos=' + button_pos + '&stop_time=' + stop_time + '\">');").Append(Environment.NewLine);
            strHTML.Append("    document.write('<embed src=\"flash/focus.swf\" FlashVars=\"pics=' + pics + '&links=' + links + '&texts=' + texts + '&pic_width=' + pic_width + '&pic_height=' + pic_height + '&show_text=' + show_text + '&txtcolor=' + txtcolor + '&bgcolor=' + bgcolor + '&button_pos=' + button_pos + '&stop_time=' + stop_time + '\" quality=\"high\" width=\"' + pic_width + '\" height=\"' + swf_height + '\" allowScriptAccess=\"sameDomain\" type=\"application/x-shockwave-flash\" pluginspage=\"http://www.macromedia.com/go/getflashplayer\" />');").Append(Environment.NewLine);
            strHTML.Append("    document.write('</object>');").Append(Environment.NewLine);
            strHTML.Append("    </script>").Append(Environment.NewLine);

            this.lbtFlashHTML.Text = strHTML.ToString();
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
