using System;
using System.Collections.Generic;

namespace TestEFCore.Service.Models;

/// <summary>
/// 使用者常用功能
/// </summary>
public partial class SysUserMenu
{
    /// <summary>
    /// 使用者編號 FK:SYSUSER.USERNO
    /// </summary>
    public string UserNo { get; set; } = null!;

    /// <summary>
    /// 系統類別 FK:SYSMENU.SYSTYPE
    /// </summary>
    public string SysType { get; set; } = null!;

    /// <summary>
    /// 功能編號 FK:SYSMENU.MENUNO
    /// </summary>
    public string MenuNo { get; set; } = null!;

    /// <summary>
    /// 功能排序
    /// </summary>
    public int MenuSort { get; set; }
}
