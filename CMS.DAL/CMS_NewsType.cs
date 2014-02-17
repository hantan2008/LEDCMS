using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CMS.DBUtility;
using System.Data;

namespace CMS.DAL
{
    /// <summary>
    /// 数据访问类CMS_NewsType。
    /// </summary>
    public class CMS_NewsType
    {
        public CMS_NewsType()
        { }
        #region  成员方法

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from CMS_NewsType");
            strSql.Append(" where ID=" + ID + " ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(CMS.Model.CMS_NewsType model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.CMS_TypeName != null)
            {
                strSql1.Append("CMS_TypeName,");
                strSql2.Append("'" + model.CMS_TypeName + "',");
            }
            if (model.CMS_Memo != null)
            {
                strSql1.Append("CMS_Memo,");
                strSql2.Append("'" + model.CMS_Memo + "',");
            }
            if (model.CMS_PID != null)
            {
                strSql1.Append("CMS_PID,");
                strSql2.Append("" + model.CMS_PID + ",");
            }
            if (model.CMS_ClassLayer != null)
            {
                strSql1.Append("CMS_ClassLayer,");
                strSql2.Append("" + model.CMS_ClassLayer + ",");
            }
            if (model.SortId != null)
            {
                strSql1.Append("SortId,");
                strSql2.Append("" + model.SortId + ",");
            }
            strSql.Append("insert into CMS_NewsType(");
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
        public void Update(CMS.Model.CMS_NewsType model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CMS_NewsType set ");
            strSql.Append("CMS_TypeName='" + model.CMS_TypeName + "',");
            strSql.Append("CMS_Memo='" + model.CMS_Memo + "',");
            strSql.Append("CMS_PID=" + model.CMS_PID + ",");
            strSql.Append("CMS_ClassLayer=" + model.CMS_ClassLayer + ",");
            strSql.Append("SortId=" + model.SortId + "");
            strSql.Append(" where ID=" + model.ID + " ");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete CMS_NewsType ");
            strSql.Append(" where ID=" + ID + " ");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public CMS.Model.CMS_NewsType GetModel(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" ID,CMS_TypeName,CMS_Memo,CMS_PID,CMS_ClassLayer,SortId ");
            strSql.Append(" from CMS_NewsType ");
            strSql.Append(" where ID=" + ID + " ");
            CMS.Model.CMS_NewsType model = new CMS.Model.CMS_NewsType();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                model.CMS_TypeName = ds.Tables[0].Rows[0]["CMS_TypeName"].ToString();
                model.CMS_Memo = ds.Tables[0].Rows[0]["CMS_Memo"].ToString();
                if (ds.Tables[0].Rows[0]["CMS_PID"].ToString() != "")
                {
                    model.CMS_PID = int.Parse(ds.Tables[0].Rows[0]["CMS_PID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CMS_ClassLayer"].ToString() != "")
                {
                    model.CMS_ClassLayer = int.Parse(ds.Tables[0].Rows[0]["CMS_ClassLayer"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SortId"].ToString() != "")
                {
                    model.SortId = int.Parse(ds.Tables[0].Rows[0]["SortId"].ToString());
                }
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
            strSql.Append("select ID,CMS_TypeName,CMS_Memo,CMS_PID,CMS_ClassLayer,SortId ");
            strSql.Append(" FROM CMS_NewsType ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
        */

        #endregion  成员方法
    }
}
