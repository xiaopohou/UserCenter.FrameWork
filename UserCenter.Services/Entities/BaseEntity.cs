﻿/// ***********************************************************************
///
/// =================================
/// CLR版本	：4.0.30319.42000
/// 命名空间	：UserCenter.Services.Entities
/// 文件名称	：BaseEntity.cs
/// =================================
/// 创 建 者	：wyt
/// 创建日期	：2018/11/8 10:51:35 
/// 邮箱		：786744873@qq.com
/// 个人主站	：https://www.cnblogs.com/wyt007/
///
/// 功能描述	：
/// 使用说明	：
/// =================================
/// 修改者	：
/// 修改日期	：
/// 修改内容	：
/// =================================
///
/// ***********************************************************************


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCenter.Services.Entities
{
    /// <summary>
    /// 
    /// <see cref="BaseEntity" langword="" />
    /// </summary>
    public abstract class BaseEntity
    {
        public long Id { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
