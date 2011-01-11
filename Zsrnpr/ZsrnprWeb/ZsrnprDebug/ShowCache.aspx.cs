using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZsrnprWeb.ZsrnprDebug
{
    public partial class ShowCacheWebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Cache["a"] = "dd";
            foreach (System.Collections.DictionaryEntry de in Cache)
            {
               string s=de.Key.ToString() ;
            }


        }
    }
}