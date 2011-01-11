using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Zsrnpr.Web.WebConfig
{
    public class LoadConfigZWWC
    {



        public static ConfigEntity.WebSiteZWCE SiteConfig(string sHost)
        {

            ConfigEntity.WebSiteZWCE siteConfig = new ConfigEntity.WebSiteZWCE();

            siteConfig = GetConfigFromCache(sHost);
           

            return siteConfig;

        }

        private static ConfigEntity.WebSiteZWCE GetConfigFromCache(string sHost)
        {
            ConfigEntity.WebSiteZWCE siteConfig = new ConfigEntity.WebSiteZWCE();

            if (System.Web.HttpContext.Current.Cache[sHost] != null)
            {
                Dictionary<string, ConfigEntity.WebSiteZWCE> dict = (Dictionary<string, ConfigEntity.WebSiteZWCE>)System.Web.HttpContext.Current.Cache[sHost];
                if (dict.ContainsKey(sHost))
                {
                    siteConfig = dict[sHost];
                    
                }
            }



            return siteConfig;
        }


      



    }
}
