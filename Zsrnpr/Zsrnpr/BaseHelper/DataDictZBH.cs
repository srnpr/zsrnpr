using System;
using System.Collections.Generic;
using System.Text;

namespace Zsrnpr.BaseHelper
{
    public class DataDictZBH
    {


        public virtual string ConnString { get; set; }


        public List<Dictionary<string, string>> DictSelect(Dictionary<string, string> dict, string sTableName, string sSelectFields)
        {
            return DataHelperZBH.DictSelect(ConnString,dict,sTableName,sSelectFields);
        }










    }
}
