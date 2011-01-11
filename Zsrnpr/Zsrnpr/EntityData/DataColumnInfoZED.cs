using System;
using System.Collections.Generic;
using System.Text;

namespace Zsrnpr.EntityData
{
    [Serializable]
    /// <summary>
    /// 数据列实体
    /// </summary>
    public class DataColumnInfoZED : BaseInterface.InterfaceDataInfoZBI
    {

        /// <summary>
        /// 唯一GUID
        /// </summary>
        public string GID { get; set; }

        /// <summary>
        /// 表GUID
        /// </summary>
        public string DataTable_GID { get; set; }


        /// <summary>
        /// 列名
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// 列类型
        /// </summary>
        public BaseEnum.DataColumnType ColumnType { get; set; }

        /// <summary>
        /// 列长度
        /// </summary>
        public string ColumnLength { get; set; }


        /// <summary>
        /// 默认值
        /// </summary>
        public string DefaultValue { get; set; }

        /// <summary>
        /// 列描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 列
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 列说明
        /// </summary>
        public string ColumnRemark { get; set; }

        /// <summary>
        /// 允许空
        /// </summary>
        public bool FlagAllowNull { get; set; }

        

    }
}
