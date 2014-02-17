using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMS.Model
{
    public class WebSet
    {
        private string _webname = "";
        private string _weburl = "";
        private string _webtel = "";
        private string _webfax = "";
        private string _webemail = "";
        private string _webcrod = "";
        private string _webkeywords = "";
        private string _webdescription = "";
        private string _webcopyright = "";

        private string _webpath = "";
        private string _webmanagepath = "";

        /// <summary>
        ///  网站名称
        /// </summary>
        public string WebName
        {
            set { _webname = value; }
            get { return _webname; }
        }

        /// <summary>
        ///  网站地址
        /// </summary>
        public string WebUrl
        {
            set { _weburl = value; }
            get { return _weburl; }
        }

        /// <summary>
        ///  联系电话
        /// </summary>
        public string WebTel
        {
            set { _webtel = value; }
            get { return _webtel; }
        }

        /// <summary>
        ///  传真地址
        /// </summary>
        public string WebFax
        {
            set { _webfax = value; }
            get { return _webfax; }
        }

        /// <summary>
        ///  联系邮箱
        /// </summary>
        public string WebEmail
        {
            set { _webemail = value; }
            get { return _webemail; }
        }

        /// <summary>
        ///  ICP备案
        /// </summary>
        public string WebCrod
        {
            set { _webcrod = value; }
            get { return _webcrod; }
        }

        /// <summary>
        /// 网站关健字
        /// </summary>
        public string WebKeywords
        {
            set { _webkeywords = value; }
            get { return _webkeywords; }
        }

        /// <summary>
        ///  网站描述
        /// </summary>
        public string WebDescription
        {
            set { _webdescription = value; }
            get { return _webdescription; }
        }

        /// <summary>
        ///  公司版权
        /// </summary>
        public string WebCopyright
        {
            set { _webcopyright = value; }
            get { return _webcopyright; }
        }

        //=========================================================================

        /// <summary>
        ///  网站路径
        /// </summary>
        public string WebPath
        {
            set { _webpath = value; }
            get { return _webpath; }
        }

        /// <summary>
        ///  管理目录
        /// </summary>
        public string WebManagePath
        {
            set { _webmanagepath = value; }
            get { return _webmanagepath; }
        }
    }
}
