﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System.Xml.Serialization;

namespace Zsrnpr.StaticClass
{
    public class EntitySerializerZSC<T>
    {




        /// <summary>
        /// 
        /// Description: 实体转xml
        /// Author:Liudpc
        /// Create Date: 2010-7-20 15:30:41
        /// </summary>
        /// <param name="t"></param>
        /// <param name="sFileName"></param>
        /// <returns></returns>
        public static string EntityToXml(T t, string sFileName)
        {
            string sReturm = sFileName;


            XmlTextWriter xw = new XmlTextWriter(sReturm, Encoding.Unicode);

           

                XmlSerializer mySerializer = new XmlSerializer(t.GetType());

                // To write to a file, create a StreamWriter object. 
                //StreamWriter myWriter = new StreamWriter(sReturm);
                //XmlWriter xw = XmlWriter.Create(sReturm);


                mySerializer.Serialize(xw, t);
                xw.Close();

            return sReturm;
        }





        /// <summary>
        /// 
        /// Author:Liudpc
        /// Create Date: 2009-11-23 12:02:02
        /// Description: 实体序列化成字符串序列
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static string EntityToString(T t)
        {
            XmlDocument xd = new XmlDocument();
            string sGuid = Guid.NewGuid().ToString();
            string sFileName = EntityToXml(t, sGuid);
            xd.Load(sFileName);

            return xd.OuterXml;
        }









        /// <summary>
        /// 
        /// Author:Liudpc
        /// Create Date: 2009-11-23 12:02:46
        /// Description: 文件反序列化
        /// </summary>
        /// <param name="sFileName"></param>
        /// <returns></returns>
        public static T XmlToEntity(string sFileName)
        {
            T t;

           


                FileStream myFileStream = new FileStream(sFileName, FileMode.Open);

                XmlSerializer mySerializer = new XmlSerializer(typeof(T));
                t = (T)mySerializer.Deserialize(myFileStream);
                myFileStream.Close();
          
            
            return t;

        }


        /// <summary>
        /// 
        /// Author:Liudpc
        /// Create Date: 2009-11-23 12:00:36
        /// Description: 根据字符串反序列化
        /// </summary>
        /// <param name="sString"></param>
        /// <returns></returns>
        public static T StringToEntity(string sString)
        {
            T t;
            
                XmlSerializer mySerializer = new XmlSerializer(typeof(T));
                byte[] b = Encoding.Convert(Encoding.Unicode, Encoding.UTF8, Encoding.Unicode.GetBytes(sString));
                MemoryStream inStream = new MemoryStream(b);

                //StreamReader sr = new StreamReader(inStream);
                XmlTextReader sr = new XmlTextReader(inStream);
                sr.Normalization = false;

                t = (T)mySerializer.Deserialize(sr);
                sr.Close();

            return t;
        }

    }
}