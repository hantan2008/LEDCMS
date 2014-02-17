using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMS.Model
{
    /// <summary>
    /// 实体类CMS_News 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public class CMS_News
    {
        public CMS_News()
        { }
        #region Model
        private int _id;
        private int? _cms_click;
        private string _cms_title;
        private int _cms_type;
        private string _cms_author;
        private string _cms_content;
        private string _cms_form;
        private string _cms_keyword;
        private string _cms_puter;
        private DateTime _cms_time;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 点击率
        /// </summary>
        public int? CMS_Click
        {
            set { _cms_click = value; }
            get { return _cms_click; }
        }
        /// <summary>
        /// 新闻标题
        /// </summary>
        public string CMS_Title
        {
            set { _cms_title = value; }
            get { return _cms_title; }
        }
        /// <summary>
        /// 文章类型
        /// </summary>
        public int CMS_Type
        {
            set { _cms_type = value; }
            get { return _cms_type; }
        }
        /// <summary>
        /// 文章作者
        /// </summary>
        public string CMS_Author
        {
            set { _cms_author = value; }
            get { return _cms_author; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CMS_Content
        {
            set { _cms_content = value; }
            get { return _cms_content; }
        }
        /// <summary>
        /// 文章来源
        /// </summary>
        public string CMS_Form
        {
            set { _cms_form = value; }
            get { return _cms_form; }
        }
        /// <summary>
        /// 关键字
        /// </summary>
        public string CMS_Keyword
        {
            set { _cms_keyword = value; }
            get { return _cms_keyword; }
        }
        /// <summary>
        /// 发布者
        /// </summary>
        public string CMS_Puter
        {
            set { _cms_puter = value; }
            get { return _cms_puter; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime CMS_Time
        {
            set { _cms_time = value; }
            get { return _cms_time; }
        }
        #endregion Model

    }
}
