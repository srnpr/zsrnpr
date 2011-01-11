using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZsrnprWeb
{
    public partial class Default :ZsrnprBLL.WebPage.DefaultPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write( ZsrnprBLL.Process.PageProess.PageShow(Request.Url,Request.Form));
        }
    }
}