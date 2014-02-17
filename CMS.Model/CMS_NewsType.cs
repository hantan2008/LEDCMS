using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMS.Model
{
    /// <summary>
    /// 实体类CMS_NewsType 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public class CMS_NewsType
    {
        public CMS_NewsType()
        { }
        #region Model
        private int _id;
        private string _cms_typename;
        private string _cms_memo;
        private int _cms_pid;
        private int? _cms_classlayer;
        private int? _sortid;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 类型名称
        /// </summary>
        public string CMS_TypeName
        {
            set { _cms_typename = value; }
            get { return _cms_typename; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CMS_Memo
        {
            set { _cms_memo = value; }
            get { return _cms_memo; }
        }
        /// <summary>
        /// 父ID
        /// </summary>
        public int CMS_PID
        {
            set { _cms_pid = value; }
            get { return _cms_pid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? CMS_ClassLayer
        {
            set { _cms_classlayer = value; }
            get { return _cms_classlayer; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? SortId
        {
            set { _sortid = value; }
            get { return _sortid; }
        }
        #endregion Model

    }
}
