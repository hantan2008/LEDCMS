using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CMS.DBUtility;
using System.Data;

namespace CMS.DAL
{
    /// <summary>
    /// 数据访问类CMS_Product。
    /// </summary>
    public class CMS_Product
    {
        public CMS_Product()
        { }
        #region  Method

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from CMS_Product");
            strSql.Append(" where ID=" + ID + " ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(CMS.Model.CMS_Product model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.CMS_ProductName != null)
            {
                strSql1.Append("CMS_ProductName,");
                strSql2.Append("'" + model.CMS_ProductName + "',");
            }
            if (model.CMS_ProductClassID != null)
            {
                strSql1.Append("CMS_ProductClassID,");
                strSql2.Append("" + model.CMS_ProductClassID + ",");
            }
            if (model.CMS_ProductContent != null)
            {
                strSql1.Append("CMS_ProductContent,");
                strSql2.Append("'" + model.CMS_ProductContent + "',");
            }
            if (model.CMS_ProductImg != null)
            {
                strSql1.Append("CMS_ProductImg,");
                strSql2.Append("'" + model.CMS_ProductImg + "',");
            }
            if (model.CMS_AddTime != null)
            {
                strSql1.Append("CMS_AddTime,");
                strSql2.Append("'" + model.CMS_AddTime + "',");
            }
            if (model.CMS_Puter != null)
            {
                strSql1.Append("CMS_Puter,");
                strSql2.Append("'" + model.CMS_Puter + "',");
            }
            if (model.CMS_IsSlide != null)
            {
                strSql1.Append("CMS_IsSlide,");
                strSql2.Append("" + model.CMS_IsSlide + ",");
            }
            strSql.Append("insert into CMS_Product(");
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
        public bool Update(CMS.Model.CMS_Product model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CMS_Product set ");
            if (model.CMS_ProductName != null)
            {
                strSql.Append("CMS_ProductName='" + model.CMS_ProductName + "',");
            }
            else
            {
                strSql.Append("CMS_ProductName= null ,");
            }
            if (model.CMS_ProductClassID != null)
            {
                strSql.Append("CMS_ProductClassID=" + model.CMS_ProductClassID + ",");
            }
            else
            {
                strSql.Append("CMS_ProductClassID= null ,");
            }
            if (model.CMS_ProductContent != null)
            {
                strSql.Append("CMS_ProductContent='" + model.CMS_ProductContent + "',");
            }
            else
            {
                strSql.Append("CMS_ProductContent= null ,");
            }
            if (model.CMS_ProductImg != null)
            {
                strSql.Append("CMS_ProductImg='" + model.CMS_ProductImg + "',");
            }
            else
            {
                strSql.Append("CMS_ProductImg= null ,");
            }
            if (model.CMS_AddTime != null)
            {
                strSql.Append("CMS_AddTime='" + model.CMS_AddTime + "',");
            }
            else
            {
                strSql.Append("CMS_AddTime= null ,");
            }
            if (model.CMS_Puter != null)
            {
                strSql.Append("CMS_Puter='" + model.CMS_Puter + "',");
            }
            else
            {
                strSql.Append("CMS_Puter= null ,");
            }
            if (model.CMS_IsSlide != null)
            {
                strSql.Append("CMS_IsSlide=" + model.CMS_IsSlide + ",");
            }
            else
            {
                strSql.Append("CMS_IsSlide= null ,");
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
            strSql.Append("delete from CMS_Product ");
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
            strSql.Append("delete from CMS_Product ");
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
        public CMS.Model.CMS_Product GetModel(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" ID,CMS_ProductName,CMS_ProductClassID,CMS_ProductContent,CMS_ProductImg,CMS_AddTime,CMS_Puter,CMS_IsSlide ");
            strSql.Append(" from CMS_Product ");
            strSql.Append(" where ID=" + ID + "");
            CMS.Model.CMS_Product model = new CMS.Model.CMS_Product();
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
        public CMS.Model.CMS_Product DataRowToModel(DataRow row)
        {
            CMS.Model.CMS_Product model = new CMS.Model.CMS_Product();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["CMS_ProductName"] != null)
                {
                    model.CMS_ProductName = row["CMS_ProductName"].ToString();
                }
                if (row["CMS_ProductClassID"] != null && row["CMS_ProductClassID"].ToString() != "")
                {
                    model.CMS_ProductClassID = int.Parse(row["CMS_ProductClassID"].ToString());
                }
                if (row["CMS_ProductContent"] != null)
                {
                    model.CMS_ProductContent = row["CMS_ProductContent"].ToString();
                }
                if (row["CMS_ProductImg"] != null)
                {
                    model.CMS_ProductImg = row["CMS_ProductImg"].ToString();
                }
                if (row["CMS_AddTime"] != null && row["CMS_AddTime"].ToString() != "")
                {
                    model.CMS_AddTime = DateTime.Parse(row["CMS_AddTime"].ToString());
                }
                if (row["CMS_Puter"] != null)
                {
                    model.CMS_Puter = row["CMS_Puter"].ToString();
                }
                if (row["CMS_IsSlide"] != null && row["CMS_IsSlide"].ToString() != "")
                {
                    model.CMS_IsSlide = int.Parse(row["CMS_IsSlide"].ToString());
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
            strSql.Append("select ID,CMS_ProductName,CMS_ProductClassID,CMS_ProductContent,CMS_ProductImg,CMS_AddTime,CMS_Puter,CMS_IsSlide ");
            strSql.Append(" FROM CMS_Product ");
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
            strSql.Append(" ID,CMS_ProductName,CMS_ProductClassID,CMS_ProductContent,CMS_ProductImg,CMS_AddTime,CMS_Puter,CMS_IsSlide ");
            strSql.Append(" FROM CMS_Product ");
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
            strSql.Append("select count(1) FROM CMS_Product ");
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
            strSql.Append(")AS Row, T.*  from CMS_Product T ");
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

        #region 分页列表
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
        public DataTable GetPagesAll(string strWhere,int PageIndex, int PageSize, out int RecordCount, out int PageCount)
        {
            string AllFields = " ID,CMS_ProductName,CMS_ProductClassID,CMS_ProductContent,CMS_ProductImg,CMS_AddTime,CMS_Puter,CMS_IsSlide";
            string SqlTablesAndWhere = "";
            string SqlTables = " CMS_Product";
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


        #endregion

        #region 获取幻灯片展示图片
        /// <summary>
        /// 获取幻灯片展示图片
        /// </summary>
        /// <returns></returns>
        public DataTable GetFlashList()
        {
            DataTable dt = new DataTable();
            dt = this.GetList(" CMS_IsSlide = 1").Tables[0];

            return dt;
        }
        #endregion


       
    }
}
