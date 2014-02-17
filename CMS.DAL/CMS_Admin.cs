using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CMS.DBUtility;

namespace CMS.DAL
{
    public class CMS_Admin
    {

        /// <summary>
        /// 根据用户名获取用户实体
        /// </summary>
        /// <param name="userLoginName"></param>
        /// <returns></returns>
        public Model.CMS_admin GetModelByAdmin_Name(string userLoginName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" ID,Admin_Name,Admin_PassWord,Admin_State,Admin_ManageStartTime,Admin_ManageEndTime ");
            strSql.Append(" from CMS_admin ");
            strSql.Append(" where Admin_Name='" + userLoginName + "' ");
            Model.CMS_admin model = new Model.CMS_admin();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                model.Admin_Name = ds.Tables[0].Rows[0]["Admin_Name"].ToString();
                model.Admin_PassWord = ds.Tables[0].Rows[0]["Admin_PassWord"].ToString();
                if (ds.Tables[0].Rows[0]["Admin_State"].ToString() != "")
                {
                    model.Admin_State = int.Parse(ds.Tables[0].Rows[0]["Admin_State"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Admin_ManageStartTime"].ToString() != "")
                {
                    model.Admin_ManageStartTime = DateTime.Parse(ds.Tables[0].Rows[0]["Admin_ManageStartTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Admin_ManageEndTime"].ToString() != "")
                {
                    model.Admin_ManageEndTime = DateTime.Parse(ds.Tables[0].Rows[0]["Admin_ManageEndTime"].ToString());
                }
                return model;
            }
            else
            {
                return null;
            }
        }
    }
}
