using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Caching;
using CMS.Common;

namespace CMS.DAL
{
    public class WebSet
    {
        private static object lockHelper = new object();
        /// <summary>
        /// 读取配置文件
        /// </summary>
        /// <param name="configFilePath"></param>
        /// <returns></returns>
        public Model.WebSet loadConfig(string configFilePath)
        {
            //从缓存中根据键读取，并使用as转换
            CMS.Model.WebSet Cache_Webset = HttpContext.Current.Cache["Cache_Webset"] as CMS.Model.WebSet;
            if (Cache_Webset == null)
            {
                //创建缓存依赖项
                CacheDependency dependency = new CacheDependency(configFilePath);
                //创建缓存
                CMS.Model.WebSet webset = (CMS.Model.WebSet)SerializationHelper.Load(typeof(CMS.Model.WebSet), configFilePath);
                HttpContext.Current.Cache.Add("Cache_Webset", webset, dependency, Cache.NoAbsoluteExpiration, new TimeSpan(0, 30, 0), CacheItemPriority.Default, null);
                Cache_Webset = HttpContext.Current.Cache["Cache_Webset"] as CMS.Model.WebSet;
            }

            return Cache_Webset;
        }

        /// <summary>
        /// 保存配置文件
        /// </summary>
        /// <param name="model"></param>
        /// <param name="configFilePath"></param>
        public CMS.Model.WebSet saveConifg(Model.WebSet model, string configFilePath)
        {
            lock (lockHelper)
            {
                SerializationHelper.Save(model, configFilePath);
                //DtCms.Dal.Providers.webSetProvider.SetInstance(mode);
            }
            return model;
        }
    }
}
