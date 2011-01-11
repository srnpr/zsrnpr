using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZsrnprWeb.ZsrnprDebug
{
    public partial class InitWebConfig : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bCreateDefault_Click(object sender, EventArgs e)
        {
            string s = "";

            


            Zsrnpr.Web.ConfigEntity.DefaultConfigZWCE dc = new Zsrnpr.Web.ConfigEntity.DefaultConfigZWCE();
            dc.Config = new List<Zsrnpr.BaseEntity.KvdZBE>();
            dc.Config.Add(new Zsrnpr.BaseEntity.KvdZBE() { K="aa",V="dd",D="dd"});

            Zsrnpr.StaticClass.EntitySerializerZSC<Zsrnpr.Web.ConfigEntity.DefaultConfigZWCE>.EntityToXml(dc, Server.MapPath("/") + "ZsrnprAction\\Config\\Default\\WebSite.config.xml");


        }
    }
}