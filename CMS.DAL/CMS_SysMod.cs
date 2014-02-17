using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CMS.DBUtility;
using System.Data.SqlClient;

namespace CMS.DAL
{
    public class CMS_SysMod
    {
        public CMS_SysMod()
        { }
        #region  Method

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from CMS_SysMod");
            strSql.Append(" where id=" + id + " ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(CMS.Model.CMS_SysMod model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.mod_name != null)
            {
                strSql1.Append("mod_name,");
                strSql2.Append("'" + model.mod_name + "',");
            }
            if (model.mod_parentid != null)
            {
                strSql1.Append("mod_parentid,");
                strSql2.Append("" + model.mod_parentid + ",");
            }
            if (model.mod_defaultpage != null)
            {
                strSql1.Append("mod_defaultpage,");
                strSql2.Append("'" + model.mod_defaultpage + "',");
            }
            if (model.mod_URL != null)
            {
                strSql1.Append("mod_URL,");
                strSql2.Append("'" + model.mod_URL + "',");
            }
            if (model.mod_level != null)
            {
                strSql1.Append("mod_level,");
                strSql2.Append("" + model.mod_level + ",");
            }
            if (model.mod_enable != null)
            {
                strSql1.Append("mod_enable,");
                strSql2.Append("" + (model.mod_enable ? 1 : 0) + ",");
            }
            if (model.mod_desc != null)
            {
                strSql1.Append("mod_desc,");
                strSql2.Append("'" + model.mod_desc + "',");
            }
            if (model.mod_sortnum != null)
            {
                strSql1.Append("mod_sortnum,");
                strSql2.Append("" + model.mod_sortnum + ",");
            }
            if (model.mod_isvisible != null)
            {
                strSql1.Append("mod_isvisible,");
                strSql2.Append("" + (model.mod_isvisible ? 1 : 0) + ",");
            }
            strSql.Append("insert into CMS_SysMod(");
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
        public bool Update(CMS.Model.CMS_SysMod model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CMS_SysMod set ");
            if (model.mod_name != null)
            {
                strSql.Append("mod_name='" + model.mod_name + "',");
            }
            if (model.mod_parentid != null)
            {
                strSql.Append("mod_parentid=" + model.mod_parentid + ",");
            }
            if (model.mod_defaultpage != null)
            {
                strSql.Append("mod_defaultpage='" + model.mod_defaultpage + "',");
            }
            else
            {
                strSql.Append("mod_defaultpage= null ,");
            }
            if (model.mod_URL != null)
            {
                strSql.Append("mod_URL='" + model.mod_URL + "',");
            }
            else
            {
                strSql.Append("mod_URL= null ,");
            }
            if (model.mod_level != null)
            {
                strSql.Append("mod_level=" + model.mod_level + ",");
            }
            if (model.mod_enable != null)
            {
                strSql.Append("mod_enable=" + (model.mod_enable ? 1 : 0) + ",");
            }
            if (model.mod_desc != null)
            {
                strSql.Append("mod_desc='" + model.mod_desc + "',");
            }
            else
            {
                strSql.Append("mod_desc= null ,");
            }
            if (model.mod_sortnum != null)
            {
                strSql.Append("mod_sortnum=" + model.mod_sortnum + ",");
            }
            if (model.mod_isvisible != null)
            {
                strSql.Append("mod_isvisible=" + (model.mod_isvisible ? 1 : 0) + ",");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where id=" + model.id + "");
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
        public bool Delete(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CMS_SysMod ");
            strSql.Append(" where id=" + id + "");
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
        public bool DeleteList(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CMS_SysMod ");
            strSql.Append(" where id in (" + idlist + ")  ");
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
        public CMS.Model.CMS_SysMod GetModel(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" id,mod_name,mod_parentid,mod_defaultpage,mod_URL,mod_level,mod_enable,mod_desc,mod_sortnum,mod_isvisible ");
            strSql.Append(" from CMS_SysMod ");
            strSql.Append(" where id=" + id + "");
            CMS.Model.CMS_SysMod model = new CMS.Model.CMS_SysMod();
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
        public CMS.Model.CMS_SysMod DataRowToModel(DataRow row)
        {
            CMS.Model.CMS_SysMod model = new CMS.Model.CMS_SysMod();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["mod_name"] != null)
                {
                    model.mod_name = row["mod_name"].ToString();
                }
                if (row["mod_parentid"] != null && row["mod_parentid"].ToString() != "")
                {
                    model.mod_parentid = int.Parse(row["mod_parentid"].ToString());
                }
                if (row["mod_defaultpage"] != null)
                {
                    model.mod_defaultpage = row["mod_defaultpage"].ToString();
                }
                if (row["mod_URL"] != null)
                {
                    model.mod_URL = row["mod_URL"].ToString();
                }
                if (row["mod_level"] != null && row["mod_level"].ToString() != "")
                {
                    model.mod_level = int.Parse(row["mod_level"].ToString());
                }
                if (row["mod_enable"] != null && row["mod_enable"].ToString() != "")
                {
                    if ((row["mod_enable"].ToString() == "1") || (row["mod_enable"].ToString().ToLower() == "true"))
                    {
                        model.mod_enable = true;
                    }
                    else
                    {
                        model.mod_enable = false;
                    }
                }
                if (row["mod_desc"] != null)
                {
                    model.mod_desc = row["mod_desc"].ToString();
                }
                if (row["mod_sortnum"] != null && row["mod_sortnum"].ToString() != "")
                {
                    model.mod_sortnum = int.Parse(row["mod_sortnum"].ToString());
                }
                if (row["mod_isvisible"] != null && row["mod_isvisible"].ToString() != "")
                {
                    if ((row["mod_isvisible"].ToString() == "1") || (row["mod_isvisible"].ToString().ToLower() == "true"))
                    {
                        model.mod_isvisible = true;
                    }
                    else
                    {
                        model.mod_isvisible = false;
                    }
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
            strSql.Append("select id,mod_name,mod_parentid,mod_defaultpage,mod_URL,mod_level,mod_enable,mod_desc,mod_sortnum,mod_isvisible ");
            strSql.Append(" FROM CMS_SysMod ");
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
            strSql.Append(" id,mod_name,mod_parentid,mod_defaultpage,mod_URL,mod_level,mod_enable,mod_desc,mod_sortnum,mod_isvisible ");
            strSql.Append(" FROM CMS_SysMod ");
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
            strSql.Append("select count(1) FROM CMS_SysMod ");
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
                strSql.Append("order by T.id desc");
            }
            strSql.Append(")AS Row, T.*  from CMS_SysMod T ");
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

        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public DataTable GetListFromPID(int PId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,mod_name,mod_parentid,mod_defaultpage,mod_URL,mod_level,mod_enable,mod_desc,mod_sortnum,mod_isvisible ");
            strSql.Append(" FROM CMS_SysMod ");
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
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
            DataRow[] dr = oldData.Select("mod_parentid=" + PId);
            for (int i = 0; i < dr.Length; i++)
            {
                //添加一行数据
                DataRow row = newData.NewRow();
                row["Id"] = int.Parse(dr[i]["Id"].ToString());
                row["mod_name"] = dr[i]["mod_name"].ToString();
                row["mod_URL"] = dr[i]["mod_URL"].ToString();
                row["mod_parentid"] = int.Parse(dr[i]["mod_parentid"].ToString());
                row["mod_level"] = int.Parse(dr[i]["mod_level"].ToString());
                row["mod_sortnum"] = int.Parse(dr[i]["mod_sortnum"].ToString());
                row["mod_isvisible"] = dr[i]["mod_isvisible"];
                newData.Rows.Add(row);
                //调用自身迭代
                this.GetChannelChild(oldData, newData, int.Parse(dr[i]["Id"].ToString()));
            }
        }
        #endregion  MethodEx
    }
}
