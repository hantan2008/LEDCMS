using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMS.Model
{
    /// <summary>
    /// 实体类CMS_Contents 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public class CMS_Contents
    {
        public CMS_Contents()
        { }
        #region Model
        private int _id;
        private string _cms_callindex;
        private string _cms_title;
        private string _cms_content;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 导航标示
        /// </summary>
        public string CMS_CallIndex
        {
            set { _cms_callindex = value; }
            get { return _cms_callindex; }
        }
        /// <summary>
        /// 标题
        /// </summary>
        public string CMS_Title
        {
            set { _cms_title = value; }
            get { return _cms_title; }
        }
        /// <summary>
        /// 内容
        /// </summary>
        public string CMS_Content
        {
            set { _cms_content = value; }
            get { return _cms_content; }
        }
        #endregion Model

    }
}
