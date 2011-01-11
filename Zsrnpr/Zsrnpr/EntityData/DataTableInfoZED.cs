using System;
using System.Collections.Generic;
using System.Text;

namespace Zsrnpr.EntityData
{

    [Serializable]
    /// <summary>
    /// 数据表实体
    /// </summary>
    public class DataTableInfoZED : BaseInterface.InterfaceDataInfoZBI
    {


        /// <summary>
        /// 唯一GUID
        /// </summary>
        public string GID { get; set; }


        /// <summary>
        /// 数据库编号
        /// </summary>
        public string DataBase_GID { get; set; }



        /// <summary>
        /// 表名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 表描述
        /// </summary>
        public string Description { get; set; }


        /// <summary>
        /// 表名称缩写
        /// </summary>
        public string ShortName { get; set; }


        public string Title { get; set; }

    }
}
