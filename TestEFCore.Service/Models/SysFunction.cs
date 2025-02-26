using System;
using System.Collections.Generic;

namespace TestEFCore.Service.Models;

/// <summary>
/// 系統功能權限
/// </summary>
public partial class SysFunction
{
    /// <summary>
    /// 系統類別 FK:SYSMENU.SYSTYPE
    /// </summary>
    public string SysType { get; set; } = null!;

    /// <summary>
    /// 功能編號 FK:SYSMENU.MENUNO
    /// </summary>
    public string MenuNo { get; set; } = null!;

    /// <summary>
    /// 操作編號
    /// </summary>
    public string FuncNo { get; set; } = null!;

    /// <summary>
    /// 操作名稱
    /// </summary>
    public string FuncNa { get; set; } = null!;

    /// <summary>
    /// 功能編號
    /// </summary>
    public int FuncSort { get; set; }
}
