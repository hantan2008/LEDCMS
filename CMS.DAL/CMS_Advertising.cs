using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CMS.DBUtility;
using System.Data;

namespace CMS.DAL
{
    public class CMS_Advertising
    {
        public CMS_Advertising()
        { }
        #region  Method


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(CMS.Model.CMS_Advertising model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.Title != null)
            {
                strSql1.Append("Title,");
                strSql2.Append("'" + model.Title + "',");
            }
            if (model.AdType != null)
            {
                strSql1.Append("AdType,");
                strSql2.Append("" + model.AdType + ",");
            }
            if (model.AdRemark != null)
            {
                strSql1.Append("AdRemark,");
                strSql2.Append("'" + model.AdRemark + "',");
            }
            if (model.AdWidth != null)
            {
                strSql1.Append("AdWidth,");
                strSql2.Append("" + model.AdWidth + ",");
            }
            if (model.AdHeight != null)
            {
                strSql1.Append("AdHeight,");
                strSql2.Append("" + model.AdHeight + ",");
            }
            strSql.Append("insert into CMS_Advertising(");
            strSql.Append(strSql1.ToString().Remove(strSql1.Length - 1));
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append(strSql2.ToString().Remove(strSql2.Length - 1));
            strSql.Append(")");
            strSql.Append(";select @@IDENTITY");
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(CMS.Model.CMS_Advertising model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CMS_Advertising set ");
            if (model.Title != null)
            {
                strSql.Append("Title='" + model.Title + "',");
            }
            if (model.AdType != null)
            {
                strSql.Append("AdType=" + model.AdType + ",");
            }
            if (model.AdRemark != null)
            {
                strSql.Append("AdRemark='" + model.AdRemark + "',");
            }
            else
            {
                strSql.Append("AdRemark= null ,");
            }
            if (model.AdWidth != null)
            {
                strSql.Append("AdWidth=" + model.AdWidth + ",");
            }
            else
            {
                strSql.Append("AdWidth= null ,");
            }
            if (model.AdHeight != null)
            {
                strSql.Append("AdHeight=" + model.AdHeight + ",");
            }
            else
            {
                strSql.Append("AdHeight= null ,");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where ID=" + model.ID + "");
            int rowsAffected = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CMS_Advertising ");
            strSql.Append(" where ID=" + ID + "");
            int rowsAffected = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }		/// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CMS_Advertising ");
            strSql.Append(" where ID in (" + IDlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public CMS.Model.CMS_Advertising GetModel(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" ID,Title,AdType,AdRemark,AdWidth,AdHeight ");
            strSql.Append(" from CMS_Advertising ");
            strSql.Append(" where ID=" + ID + "");
            CMS.Model.CMS_Advertising model = new CMS.Model.CMS_Advertising();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public CMS.Model.CMS_Advertising DataRowToModel(DataRow row)
        {
            CMS.Model.CMS_Advertising model = new CMS.Model.CMS_Advertising();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["Title"] != null)
                {
                    model.Title = row["Title"].ToString();
                }
                if (row["AdType"] != null && row["AdType"].ToString() != "")
                {
                    model.AdType = int.Parse(row["AdType"].ToString());
                }
                if (row["AdRemark"] != null)
                {
                    model.AdRemark = row["AdRemark"].ToString();
                }
                if (row["AdWidth"] != null && row["AdWidth"].ToString() != "")
                {
                    model.AdWidth = int.Parse(row["AdWidth"].ToString());
                }
                if (row["AdHeight"] != null && row["AdHeight"].ToString() != "")
                {
                    model.AdHeight = int.Parse(row["AdHeight"].ToString());
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,Title,AdType,AdRemark,AdWidth,AdHeight ");
            strSql.Append(" FROM CMS_Advertising ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" ID,Title,AdType,AdRemark,AdWidth,AdHeight ");
            strSql.Append(" FROM CMS_Advertising ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM CMS_Advertising ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.ID desc");
            }
            strSql.Append(")AS Row, T.*  from CMS_Advertising T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
        */

        #endregion  Method
        #region  MethodEx
        public DataTable GetPagesAll(string strWhere, int PageIndex, int PageSize, out int RecordCount, out int PageCount)
        {
            string AllFields = " ID,Title,AdType,AdRemark,AdWidth,AdHeight";
            string SqlTablesAndWhere = "";
            string SqlTables = " CMS_Advertising";
            if (strWhere != "")
            {
                SqlTablesAndWhere = SqlTables + " where " + strWhere;
            }
            else
            {
                SqlTablesAndWhere = SqlTables;
            }

            string IndexField = "ID";
            string OrderFields = "order by ID Desc";
            DataTable dt = DbHelperSQL.ExecutePage(AllFields, SqlTablesAndWhere, IndexField, OrderFields, PageIndex, PageSize, out RecordCount, out PageCount);

            return dt;
        }
        #endregion  MethodEx


    }
}
