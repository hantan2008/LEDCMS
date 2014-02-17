using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CMS.DBUtility;
using System.Data;

namespace CMS.DAL
{
    /// <summary>
    /// 数据访问类CMS_News。
    /// </summary>
    public class CMS_News
    {
        public CMS_News()
        { }
        #region  成员方法

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from CMS_News");
            strSql.Append(" where ID=" + ID + " ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(CMS.Model.CMS_News model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.CMS_Click != null)
            {
                strSql1.Append("CMS_Click,");
                strSql2.Append("" + model.CMS_Click + ",");
            }
            if (model.CMS_Title != null)
            {
                strSql1.Append("CMS_Title,");
                strSql2.Append("'" + model.CMS_Title + "',");
            }
            if (model.CMS_Type != null)
            {
                strSql1.Append("CMS_Type,");
                strSql2.Append("" + model.CMS_Type + ",");
            }
            if (model.CMS_Author != null)
            {
                strSql1.Append("CMS_Author,");
                strSql2.Append("'" + model.CMS_Author + "',");
            }
            if (model.CMS_Content != null)
            {
                strSql1.Append("CMS_Content,");
                strSql2.Append("'" + model.CMS_Content + "',");
            }
            if (model.CMS_Form != null)
            {
                strSql1.Append("CMS_Form,");
                strSql2.Append("'" + model.CMS_Form + "',");
            }
            if (model.CMS_Keyword != null)
            {
                strSql1.Append("CMS_Keyword,");
                strSql2.Append("'" + model.CMS_Keyword + "',");
            }
            if (model.CMS_Puter != null)
            {
                strSql1.Append("CMS_Puter,");
                strSql2.Append("'" + model.CMS_Puter + "',");
            }
            if (model.CMS_Time != null)
            {
                strSql1.Append("CMS_Time,");
                strSql2.Append("'" + model.CMS_Time + "',");
            }
            strSql.Append("insert into CMS_News(");
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
        public void Update(CMS.Model.CMS_News model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CMS_News set ");
            strSql.Append("CMS_Click=" + model.CMS_Click + ",");
            strSql.Append("CMS_Title='" + model.CMS_Title + "',");
            strSql.Append("CMS_Type=" + model.CMS_Type + ",");
            strSql.Append("CMS_Author='" + model.CMS_Author + "',");
            strSql.Append("CMS_Content='" + model.CMS_Content + "',");
            strSql.Append("CMS_Form='" + model.CMS_Form + "',");
            strSql.Append("CMS_Keyword='" + model.CMS_Keyword + "',");
            strSql.Append("CMS_Puter='" + model.CMS_Puter + "',");
            strSql.Append("CMS_Time='" + model.CMS_Time + "'");
            strSql.Append(" where ID=" + model.ID + " ");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete CMS_News ");
            strSql.Append(" where ID=" + ID + " ");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public CMS.Model.CMS_News GetModel(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" ID,CMS_Click,CMS_Title,CMS_Type,CMS_Author,CMS_Content,CMS_Form,CMS_Keyword,CMS_Puter,CMS_Time ");
            strSql.Append(" from CMS_News ");
            strSql.Append(" where ID=" + ID + " ");
            CMS.Model.CMS_News model = new CMS.Model.CMS_News();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CMS_Click"].ToString() != "")
                {
                    model.CMS_Click = int.Parse(ds.Tables[0].Rows[0]["CMS_Click"].ToString());
                }
                model.CMS_Title = ds.Tables[0].Rows[0]["CMS_Title"].ToString();
                if (ds.Tables[0].Rows[0]["CMS_Type"].ToString() != "")
                {
                    model.CMS_Type = int.Parse(ds.Tables[0].Rows[0]["CMS_Type"].ToString());
                }
                model.CMS_Author = ds.Tables[0].Rows[0]["CMS_Author"].ToString();
                model.CMS_Content = ds.Tables[0].Rows[0]["CMS_Content"].ToString();
                model.CMS_Form = ds.Tables[0].Rows[0]["CMS_Form"].ToString();
                model.CMS_Keyword = ds.Tables[0].Rows[0]["CMS_Keyword"].ToString();
                model.CMS_Puter = ds.Tables[0].Rows[0]["CMS_Puter"].ToString();
                if (ds.Tables[0].Rows[0]["CMS_Time"].ToString() != "")
                {
                    model.CMS_Time = DateTime.Parse(ds.Tables[0].Rows[0]["CMS_Time"].ToString());
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
            strSql.Append("select ID,CMS_Click,CMS_Title,CMS_Type,CMS_Author,CMS_Content,CMS_Form,CMS_Keyword,CMS_Puter,CMS_Time ");
            strSql.Append(" FROM CMS_News ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取前几条数据
        /// </summary>
        /// <param name="n"></param>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataSet GetTopList(int n, string strWhere,string strOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top " + n + " ID,CMS_Click,CMS_Title,CMS_Type,CMS_Author,CMS_Content,CMS_Form,CMS_Keyword,CMS_Puter,CMS_Time ");
            strSql.Append(" FROM CMS_News ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            if (strOrder.Trim() != "")
            {
                strSql.Append(strOrder);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法

        #region
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
            string AllFields = " [ID],[CMS_Title],[CMS_Type],[CMS_Author],[CMS_Content],[CMS_Form],[CMS_Keyword],[CMS_Puter],[CMS_Time],[CMS_Click]";
            string SqlTablesAndWhere = " CMS_News";
            string IndexField = "ID";
            string OrderFields = "order by ID Desc";
            DataTable dt = CMS.DBUtility.DbHelperSQL.ExecutePage(AllFields, SqlTablesAndWhere, IndexField, OrderFields, PageIndex, PageSize, out RecordCount, out PageCount);

            return dt;
        }
        #endregion
    }
}
