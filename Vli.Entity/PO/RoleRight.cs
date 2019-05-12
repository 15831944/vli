﻿/**
*
* 功 能： N/A
* 类 名： RoleRight
* 作 者： weili
* 时 间： 2019/2/17 1:37:32
* 版 本： 1.0.0.0
* 版 权： Copyright (c) 2019 Mainki. All rights reserved.
*
*/

using System.ComponentModel.DataAnnotations;

namespace Vli.Entity.PO
{
    public sealed class RoleRight : BaseEntity
    {
        [Required]
        public int RoleId { get; set; }

        [Required]
        public int RightId { get; set; }
    }
}
