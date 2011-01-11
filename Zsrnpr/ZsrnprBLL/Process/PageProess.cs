using System;
using System.Collections.Generic;
using System.Text;

namespace ZsrnprBLL.Process
{
    public class PageProess
    {


        public static string PageShow(Uri PageUrl,System.Collections.Specialized.NameValueCollection pageRequest)
        {


            string sHost = PageUrl.Host;

            if (pageRequest["z"] != null)
            {
                sHost = "Default";
            }

            string sPage = pageRequest["p"] == null ? "index" : pageRequest["p"].ToString().Trim();


            Zsrnpr.Web.ConfigEntity.WebSiteZWCE siteInfo = Zsrnpr.Web.WebConfig.LoadConfigZWWC.SiteConfig(sHost);





            return "";

        }

    }
}
