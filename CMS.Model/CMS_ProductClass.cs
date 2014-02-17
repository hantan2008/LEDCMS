using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMS.Model
{
    /// <summary>
    /// 实体类CMS_ProductClass 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public class CMS_ProductClass
    {
        public CMS_ProductClass()
        { }
        #region Model
        private int _id;
        private string _cms_classname;
        private string _cms_memo;
        private int _cms_pid;
        private int? _cms_classlayer;
        private string _cms_classidlist;
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
        /// 
        /// </summary>
        public string CMS_ClassName
        {
            set { _cms_classname = value; }
            get { return _cms_classname; }
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
        /// 
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
        /// 子栏目ID列表
        /// </summary>
        public string CMS_ClassIdList
        {
            set { _cms_classidlist = value; }
            get { return _cms_classidlist; }
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
