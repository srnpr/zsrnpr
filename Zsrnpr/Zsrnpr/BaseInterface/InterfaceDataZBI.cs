using System;
using System.Collections.Generic;
using System.Text;

namespace Zsrnpr.BaseInterface
{

    /// <summary>
    /// 数据默认接口
    /// </summary>
    interface InterfaceDataInfoZBI:InterfaceBaseZBI
    {

        /// <summary>
        /// 名称
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        string Title { get; set; }


        /// <summary>
        /// 描述
        /// </summary>
        string Description { get; set; }

    }
}
