using System;
using System.Collections.Generic;
using System.Text;

namespace Zsrnpr.EntityData
{
    [Serializable]
    /// <summary>
    /// 数据库信息
    /// </summary>
    public class DataBaseInfoZED : BaseInterface.InterfaceDataInfoZBI
    {

        /// <summary>
        /// 唯一GUID
        /// </summary>
        public string GID { get; set; }

        /// <summary>
        /// 数据库服务器信息
        /// </summary>
        public string DataServer_GID { get; set; }

        
      

        /// <summary>
        /// 连接字符串
        /// </summary>
        public string ConnString { get; set; }


        /// <summary>
        /// 数据库名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 数据库本地名称
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 数据库描述
        /// </summary>
        public string Description { get; set; }
    }
}
