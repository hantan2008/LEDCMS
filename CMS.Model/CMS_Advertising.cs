using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMS.Model
{
    public class CMS_Advertising
    {
        public CMS_Advertising()
        { }
        #region Model
        private int _id;
        private string _title;
        private int _adtype;
        private string _adremark;
        private int? _adwidth;
        private int? _adheight;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 广告位名称
        /// </summary>
        public string Title
        {
            set { _title = value; }
            get { return _title; }
        }
        /// <summary>
        /// 广告位类型
        /// </summary>
        public int AdType
        {
            set { _adtype = value; }
            get { return _adtype; }
        }
        /// <summary>
        /// 广告位说明
        /// </summary>
        public string AdRemark
        {
            set { _adremark = value; }
            get { return _adremark; }
        }
        /// <summary>
        /// 广告位宽度
        /// </summary>
        public int? AdWidth
        {
            set { _adwidth = value; }
            get { return _adwidth; }
        }
        /// <summary>
        /// 广告位高度
        /// </summary>
        public int? AdHeight
        {
            set { _adheight = value; }
            get { return _adheight; }
        }
        #endregion Model
    }
}
