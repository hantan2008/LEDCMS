using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMS.Model
{
    public class CMS_SysMod
    {
        public CMS_SysMod()
        { }
        #region Model
        private int _id;
        private string _mod_name;
        private int _mod_parentid;
        private string _mod_defaultpage;
        private string _mod_url;
        private int _mod_level;
        private bool _mod_enable;
        private string _mod_desc;
        private int _mod_sortnum;
        private bool _mod_isvisible;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string mod_name
        {
            set { _mod_name = value; }
            get { return _mod_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int mod_parentid
        {
            set { _mod_parentid = value; }
            get { return _mod_parentid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string mod_defaultpage
        {
            set { _mod_defaultpage = value; }
            get { return _mod_defaultpage; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string mod_URL
        {
            set { _mod_url = value; }
            get { return _mod_url; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int mod_level
        {
            set { _mod_level = value; }
            get { return _mod_level; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool mod_enable
        {
            set { _mod_enable = value; }
            get { return _mod_enable; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string mod_desc
        {
            set { _mod_desc = value; }
            get { return _mod_desc; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int mod_sortnum
        {
            set { _mod_sortnum = value; }
            get { return _mod_sortnum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool mod_isvisible
        {
            set { _mod_isvisible = value; }
            get { return _mod_isvisible; }
        }
        #endregion Model

    }
}
