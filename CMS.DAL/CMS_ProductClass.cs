using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CMS.DBUtility;
using System.Data;

namespace CMS.DAL
{
    /// <summary>
    /// 数据访问类CMS_ProductClass。
    /// </summary>
    public class CMS_ProductClass
    {
        public CMS_ProductClass()
        { }
        #region  成员方法

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from CMS_ProductClass");
            strSql.Append(" where ID=" + ID + " ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(CMS.Model.CMS_ProductClass model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.CMS_ClassName != null)
            {
                strSql1.Append("CMS_ClassName,");
                strSql2.Append("'" + model.CMS_ClassName + "',");
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
            if (model.CMS_ClassIdList != null)
            {
                strSql1.Append("CMS_ClassIdList,");
                strSql2.Append("'" + model.CMS_ClassIdList + "',");
            }
            if (model.SortId != null)
            {
                strSql1.Append("SortId,");
                strSql2.Append("" + model.SortId + ",");
            }
            strSql.Append("insert into CMS_ProductClass(");
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
        public void Update(CMS.Model.CMS_ProductClass model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CMS_ProductClass set ");
            strSql.Append("CMS_ClassName='" + model.CMS_ClassName + "',");
            strSql.Append("CMS_Memo='" + model.CMS_Memo + "',");
            strSql.Append("CMS_PID=" + model.CMS_PID + ",");
            strSql.Append("CMS_ClassLayer=" + model.CMS_ClassLayer + ",");
            strSql.Append("CMS_ClassIdList='" + model.CMS_ClassIdList + "',");
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
            strSql.Append("delete CMS_ProductClass ");
            strSql.Append(" where ID=" + ID + " ");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public CMS.Model.CMS_ProductClass GetModel(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" ID,CMS_ClassName,CMS_Memo,CMS_PID,CMS_ClassLayer,CMS_ClassIdList,SortId ");
            strSql.Append(" from CMS_ProductClass ");
            strSql.Append(" where ID=" + ID + " ");
            CMS.Model.CMS_ProductClass model = new CMS.Model.CMS_ProductClass();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                model.CMS_ClassName = ds.Tables[0].Rows[0]["CMS_ClassName"].ToString();
                model.CMS_Memo = ds.Tables[0].Rows[0]["CMS_Memo"].ToString();
                if (ds.Tables[0].Rows[0]["CMS_PID"].ToString() != "")
                {
                    model.CMS_PID = int.Parse(ds.Tables[0].Rows[0]["CMS_PID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CMS_ClassLayer"].ToString() != "")
                {
                    model.CMS_ClassLayer = int.Parse(ds.Tables[0].Rows[0]["CMS_ClassLayer"].ToString());
                }
                model.CMS_ClassIdList = ds.Tables[0].Rows[0]["CMS_ClassIdList"].ToString();
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
            strSql.Append("select ID,CMS_ClassName,CMS_Memo,CMS_PID,CMS_ClassLayer,CMS_ClassIdList,SortId ");
            strSql.Append(" FROM CMS_ProductClass ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
        */

        #endregion  成员方法

        #region 获取某节点下的所有数据
        /// <summary>
        /// 获取某节点下的所有数据
        /// </summary>
        /// <param name="PId">父节点</param>
        /// <returns></returns>
        public DataTable GetListFromPID(int PId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,CMS_ClassName,CMS_Memo,CMS_PID,CMS_ClassLayer,SortId ");
            strSql.Append(" FROM CMS_ProductClass ");
           DataSet ds=  DbHelperSQL.Query(strSql.ToString());
           DataTable oldData = ds.Tables[0] as DataTable;
           if (oldData == null)
           {
               return null;
           }
           //复制结构
           DataTable newData = oldData.Clone();
           //调用迭代组合成DAGATABLE
           GetChannelChild(oldData, newData, PId);
           return newData;

        }

        /// <summary>
        /// 从内存中取得所有下级栏目列表（自身迭代）
        /// </summary>
        private void GetChannelChild(DataTable oldData, DataTable newData, int PId)
        {
            DataRow[] dr = oldData.Select("CMS_PID=" + PId);
            for (int i = 0; i < dr.Length; i++)
            {
                //添加一行数据
                DataRow row = newData.NewRow();
                row["Id"] = int.Parse(dr[i]["Id"].ToString());
                row["CMS_ClassName"] = dr[i]["CMS_ClassName"].ToString();
                row["CMS_Memo"] = dr[i]["CMS_Memo"].ToString();
                row["CMS_PID"] = int.Parse(dr[i]["CMS_PID"].ToString());
                row["CMS_ClassLayer"] = int.Parse(dr[i]["CMS_ClassLayer"].ToString());
                row["SortId"] = int.Parse(dr[i]["SortId"].ToString());
                newData.Rows.Add(row);
                //调用自身迭代
                this.GetChannelChild(oldData, newData, int.Parse(dr[i]["Id"].ToString()));
            }
        }
        #endregion
    }
}
