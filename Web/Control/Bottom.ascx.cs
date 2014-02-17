using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CMS.Common;

namespace Web.Control
{
    public partial class Bottom : System.Web.UI.UserControl
    {
        protected internal CMS.Model.WebSet SiteConfig = new CMS.DAL.WebSet().loadConfig(Utils.GetXmlMapPath("Configpath"));
       
    }
}