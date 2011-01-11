using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Zsrnpr.BaseHelper
{
   public class IOHelperZBH
    {

       /// <summary>
       /// 返回存在的文件名 否则返回空
       /// </summary>
       /// <param name="sFileName"></param>
       /// <returns></returns>
       public static string ExitFileName(string sFileName)
       {
           if (File.Exists(sFileName))
           {
               return sFileName;
           }
           else
           {
               return "";
           }
       }


    }
}
