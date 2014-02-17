using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMS.Model
{
    /// <summary>
    /// 实体类CMS_Baseset 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public class CMS_Baseset
    {
        public CMS_Baseset()
        { }
        #region Model
        private int _id;
        private string _websitename;
        private string _companyname;
        private string _companytel;
        private string _companyfax;
        private string _companyaddress;
        private string _email;
        private string _qq;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 网站名称
        /// </summary>
        public string WebSiteName
        {
            set { _websitename = value; }
            get { return _websitename; }
        }
        /// <summary>
        /// 公司名称
        /// </summary>
        public string CompanyName
        {
            set { _companyname = value; }
            get { return _companyname; }
        }
        /// <summary>
        /// 公司电话
        /// </summary>
        public string CompanyTel
        {
            set { _companytel = value; }
            get { return _companytel; }
        }
        /// <summary>
        /// 传真
        /// </summary>
        public string CompanyFax
        {
            set { _companyfax = value; }
            get { return _companyfax; }
        }
        /// <summary>
        /// 公司地址
        /// </summary>
        public string CompanyAddress
        {
            set { _companyaddress = value; }
            get { return _companyaddress; }
        }
        /// <summary>
        /// 电子邮箱
        /// </summary>
        public string Email
        {
            set { _email = value; }
            get { return _email; }
        }
        /// <summary>
        /// QQ
        /// </summary>
        public string QQ
        {
            set { _qq = value; }
            get { return _qq; }
        }
        #endregion Model

    }
}
