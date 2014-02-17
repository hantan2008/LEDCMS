using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CMS.DBUtility;
using System.Data;

namespace CMS.DAL
{
    /// <summary>
    /// 数据访问类CMS_Baseset。
    /// </summary>
    public class CMS_Baseset
    {
        public CMS_Baseset()
        { }
        #region  成员方法

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from CMS_Baseset");
            strSql.Append(" where ID=" + ID + " ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(CMS.Model.CMS_Baseset model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.WebSiteName != null)
            {
                strSql1.Append("WebSiteName,");
                strSql2.Append("'" + model.WebSiteName + "',");
            }
            if (model.CompanyName != null)
            {
                strSql1.Append("CompanyName,");
                strSql2.Append("'" + model.CompanyName + "',");
            }
            if (model.CompanyTel != null)
            {
                strSql1.Append("CompanyTel,");
                strSql2.Append("'" + model.CompanyTel + "',");
            }
            if (model.CompanyFax != null)
            {
                strSql1.Append("CompanyFax,");
                strSql2.Append("'" + model.CompanyFax + "',");
            }
            if (model.CompanyAddress != null)
            {
                strSql1.Append("CompanyAddress,");
                strSql2.Append("'" + model.CompanyAddress + "',");
            }
            if (model.Email != null)
            {
                strSql1.Append("Email,");
                strSql2.Append("'" + model.Email + "',");
            }
            if (model.QQ != null)
            {
                strSql1.Append("QQ,");
                strSql2.Append("'" + model.QQ + "',");
            }
            strSql.Append("insert into CMS_Baseset(");
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
        public bool Update(CMS.Model.CMS_Baseset model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CMS_Baseset set ");
            strSql.Append("WebSiteName='" + model.WebSiteName + "',");
            strSql.Append("CompanyName='" + model.CompanyName + "',");
            strSql.Append("CompanyTel='" + model.CompanyTel + "',");
            strSql.Append("CompanyFax='" + model.CompanyFax + "',");
            strSql.Append("CompanyAddress='" + model.CompanyAddress + "',");
            strSql.Append("Email='" + model.Email + "',");
            strSql.Append("QQ='" + model.QQ + "'");
            strSql.Append(" where ID=" + model.ID + " ");
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
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete CMS_Baseset ");
            strSql.Append(" where ID=" + ID + " ");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public CMS.Model.CMS_Baseset GetModel(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" ID,WebSiteName,CompanyName,CompanyTel,CompanyFax,CompanyAddress,Email,QQ ");
            strSql.Append(" from CMS_Baseset ");
            strSql.Append(" where ID=" + ID + " ");
            CMS.Model.CMS_Baseset model = new CMS.Model.CMS_Baseset();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                model.WebSiteName = ds.Tables[0].Rows[0]["WebSiteName"].ToString();
                model.CompanyName = ds.Tables[0].Rows[0]["CompanyName"].ToString();
                model.CompanyTel = ds.Tables[0].Rows[0]["CompanyTel"].ToString();
                model.CompanyFax = ds.Tables[0].Rows[0]["CompanyFax"].ToString();
                model.CompanyAddress = ds.Tables[0].Rows[0]["CompanyAddress"].ToString();
                model.Email = ds.Tables[0].Rows[0]["Email"].ToString();
                model.QQ = ds.Tables[0].Rows[0]["QQ"].ToString();
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
            strSql.Append("select ID,WebSiteName,CompanyName,CompanyTel,CompanyFax,CompanyAddress,Email,QQ ");
            strSql.Append(" FROM CMS_Baseset ");
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
