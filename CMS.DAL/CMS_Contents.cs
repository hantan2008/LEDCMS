using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CMS.DBUtility;
using System.Data;

namespace CMS.DAL
{
    /// <summary>
    /// 数据访问类CMS_Contents。
    /// </summary>
    public class CMS_Contents
    {
        public CMS_Contents()
        { }
        #region  成员方法

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from CMS_Contents");
            strSql.Append(" where id=" + id + " ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(CMS.Model.CMS_Contents model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.CMS_CallIndex != null)
            {
                strSql1.Append("CMS_CallIndex,");
                strSql2.Append("'" + model.CMS_CallIndex + "',");
            }
            if (model.CMS_Title != null)
            {
                strSql1.Append("CMS_Title,");
                strSql2.Append("'" + model.CMS_Title + "',");
            }
            if (model.CMS_Content != null)
            {
                strSql1.Append("CMS_Content,");
                strSql2.Append("'" + model.CMS_Content + "',");
            }
            strSql.Append("insert into CMS_Contents(");
            strSql.Append(strSql1.ToString().Remove(strSql1.Length - 1));
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append(strSql2.ToString().Remove(strSql2.Length - 1));
            strSql.Append(")");
            strSql.Append(";select @@IDENTITY");
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 1;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(CMS.Model.CMS_Contents model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CMS_Contents set ");
            strSql.Append("CMS_CallIndex='" + model.CMS_CallIndex + "',");
            strSql.Append("CMS_Title='" + model.CMS_Title + "',");
            strSql.Append("CMS_Content='" + model.CMS_Content + "'");
            strSql.Append(" where id=" + model.id + " ");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete CMS_Contents ");
            strSql.Append(" where id=" + id + " ");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public CMS.Model.CMS_Contents GetModel(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" id,CMS_CallIndex,CMS_Title,CMS_Content ");
            strSql.Append(" from CMS_Contents ");
            strSql.Append(" where id=" + id + " ");
            CMS.Model.CMS_Contents model = new CMS.Model.CMS_Contents();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    model.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                model.CMS_CallIndex = ds.Tables[0].Rows[0]["CMS_CallIndex"].ToString();
                model.CMS_Title = ds.Tables[0].Rows[0]["CMS_Title"].ToString();
                model.CMS_Content = ds.Tables[0].Rows[0]["CMS_Content"].ToString();
                return model;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,CMS_CallIndex,CMS_Title,CMS_Content ");
            strSql.Append(" FROM CMS_Contents ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
        */

        #endregion  成员方法

        /// <summary>
        /// 
        /// </summary>
        /// <param name="UID"></param>
        /// <param name="MemberTypeId"></param>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <param name="RecordCount"></param>
        /// <param name="PageCount"></param>
        /// <returns></returns>
        public DataTable GetAll(string UID, string MemberTypeId, int PageIndex, int PageSize, out int RecordCount, out int PageCount)
        {
            string AllFields = " id,CMS_CallIndex,CMS_Title,CMS_Content";
            string SqlTablesAndWhere = " CMS_Contents";
            string IndexField = "ID";
            string OrderFields = "order by ID Desc";
            DataTable dt = CMS.DBUtility.DbHelperSQL.ExecutePage(AllFields, SqlTablesAndWhere, IndexField, OrderFields, PageIndex, PageSize, out RecordCount, out PageCount);

            return dt;
        }
        /// <summary>
        /// 根据调用标示更新数据
        /// </summary>
        /// <param name="model"></param>
        public void UpdateByCallindex(CMS.Model.CMS_Contents model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CMS_Contents set ");
            strSql.Append("CMS_Title='" + model.CMS_Title + "',");
            strSql.Append("CMS_Content='" + model.CMS_Content + "'");
            strSql.Append(" where CMS_CallIndex='" + model.CMS_CallIndex + "' ");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 根据调用标示得到一个对象实体
        /// </summary>
        public CMS.Model.CMS_Contents GetModelByCallIndex(string callindex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" id,CMS_CallIndex,CMS_Title,CMS_Content ");
            strSql.Append(" from CMS_Contents ");
            strSql.Append(" where CMS_CallIndex='" + callindex + "' ");
            CMS.Model.CMS_Contents model = new CMS.Model.CMS_Contents();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    model.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                model.CMS_CallIndex = ds.Tables[0].Rows[0]["CMS_CallIndex"].ToString();
                model.CMS_Title = ds.Tables[0].Rows[0]["CMS_Title"].ToString();
                model.CMS_Content = ds.Tables[0].Rows[0]["CMS_Content"].ToString();
                return model;
            }
            else
            {
                return null;
            }
        }

    }
}
