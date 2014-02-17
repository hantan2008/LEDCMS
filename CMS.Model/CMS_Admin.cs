using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMS.Model
{
    public class CMS_admin
    {
        public CMS_admin()
        { }
        #region Model
        private int _id;
        private string _admin_name;
        private string _admin_password;
        private int _admin_state;
        private DateTime _admin_managestarttime;
        private DateTime _admin_manageendtime;
        /// <summary>
        /// id
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 用户名
        /// </summary>
        public string Admin_Name
        {
            set { _admin_name = value; }
            get { return _admin_name; }
        }
        /// <summary>
        /// 密码
        /// </summary>
        public string Admin_PassWord
        {
            set { _admin_password = value; }
            get { return _admin_password; }
        }
        /// <summary>
        /// （1，正常，2，冻结）
        /// </summary>
        public int Admin_State
        {
            set { _admin_state = value; }
            get { return _admin_state; }
        }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime Admin_ManageStartTime
        {
            set { _admin_managestarttime = value; }
            get { return _admin_managestarttime; }
        }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime Admin_ManageEndTime
        {
            set { _admin_manageendtime = value; }
            get { return _admin_manageendtime; }
        }
        #endregion Model

    }
}
