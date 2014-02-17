using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMS.Model
{
    /// <summary>
    /// 实体类CMS_Product 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public class CMS_Product
    {
        public CMS_Product()
        { }
        #region Model
        private int _id;
        private string _cms_productname;
        private int _cms_productclassid;
        private string _cms_productcontent;
        private string _cms_productimg;
        private DateTime _cms_addtime;
        private string _cms_puter;
        private int? _cms_isslide = 0;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 产品名称
        /// </summary>
        public string CMS_ProductName
        {
            set { _cms_productname = value; }
            get { return _cms_productname; }
        }
        /// <summary>
        /// 产品类别id
        /// </summary>
        public int CMS_ProductClassID
        {
            set { _cms_productclassid = value; }
            get { return _cms_productclassid; }
        }
        /// <summary>
        /// 产品详情描述
        /// </summary>
        public string CMS_ProductContent
        {
            set { _cms_productcontent = value; }
            get { return _cms_productcontent; }
        }
        /// <summary>
        /// 产品图片
        /// </summary>
        public string CMS_ProductImg
        {
            set { _cms_productimg = value; }
            get { return _cms_productimg; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime CMS_AddTime
        {
            set { _cms_addtime = value; }
            get { return _cms_addtime; }
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
        /// 是否幻灯片
        /// </summary>
        public int? CMS_IsSlide
        {
            set { _cms_isslide = value; }
            get { return _cms_isslide; }
        }
        #endregion Model

    }
}
