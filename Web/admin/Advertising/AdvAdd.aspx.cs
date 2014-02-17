using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.admin.Advertising
{
    public partial class AdvAdd : CMS.Web.UI.ManagePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string Title = this.txtTitle.Text;
            int AdType = int.Parse(this.rblAdType.SelectedValue);
            string AdRemark = this.txtAdRemark.Text;
            int AdWidth = int.Parse(this.txtAdWidth.Text);
            int AdHeight = int.Parse(this.txtAdHeight.Text);

            CMS.Model.CMS_Advertising model = new CMS.Model.CMS_Advertising();
            model.Title = Title;
            model.AdType = AdType;
            model.AdRemark = AdRemark;
            model.AdWidth = AdWidth;
            model.AdHeight = AdHeight;

            CMS.DAL.CMS_Advertising bll = new CMS.DAL.CMS_Advertising();
            bll.Add(model);

            JscriptPrint("广告位增加成功啦！", "AdvList.aspx", "Success");
        }
    }
}