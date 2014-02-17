using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Web.admin
{
    public partial class left : System.Web.UI.Page
    {
        public int Num;//
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.LoadData();
            }
        }

        private void LoadData()
        {
            CMS.DAL.CMS_SysMod dal = new CMS.DAL.CMS_SysMod();

            DataSet relationSet = new DataSet();
            DataTable tmpTable1 = dal.GetList(" Mod_Level = 1 AND mod_isvisible = 1 order By mod_sortnum,ID ASC").Tables[0];
            tmpTable1.TableName = "T_SYS_Mod_Level1";
            DataTable tmpTable2 = dal.GetList(" Mod_Level = 2 AND mod_isvisible = 1 order By mod_sortnum,ID ASC").Tables[0];
            tmpTable2.TableName = "T_SYS_Mod_Level2";
            relationSet.Tables.Add(tmpTable1.Copy());
            relationSet.Tables.Add(tmpTable2.Copy());


            DataRelation Level1Level2Ralation = relationSet.Relations.Add("Level1Level2Ralation", relationSet.Tables["T_SYS_Mod_Level1"].Columns["ID"], relationSet.Tables["T_SYS_Mod_Level2"].Columns["mod_parentid"]);

            this.rptModLevel1.DataSource = relationSet.Tables["T_SYS_Mod_Level1"].DefaultView;
            this.rptModLevel1.DataBind();
        }

        public int GetNextNum()
        {
            return this.Num++;
        }
    }
}
