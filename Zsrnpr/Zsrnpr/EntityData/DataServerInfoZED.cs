using System;
using System.Collections.Generic;
using System.Text;

namespace Zsrnpr.EntityData
{

    [Serializable]
    /// <summary>
    /// 数据库服务器信息
    /// </summary>
    public class DataServerInfoZED : BaseInterface.InterfaceDataInfoZBI
    {

        /// <summary>
        /// 数据库类型
        /// </summary>
        public BaseEnum.DataServerType ServerType { get; set; }

        /// <summary>
        /// 唯一GUID
        /// </summary>
        public string GID { get; set; }

        public string Name { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}
