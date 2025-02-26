using System;
using System.Collections.Generic;

namespace TestEFCore.Service.Models;

/// <summary>
/// 系統使用權限
/// </summary>
public partial class SysUseLimit
{
    /// <summary>
    /// 權限類型 U:帳號/G:群組
    /// </summary>
    public string UlType { get; set; } = null!;

    /// <summary>
    /// 權限編號
    /// </summary>
    public string UlNo { get; set; } = null!;

    /// <summary>
    /// 系統類別 FK:SYSMENU.SYSTYPE
    /// </summary>
    public string SysType { get; set; } = null!;

    /// <summary>
    /// 功能編號 FK:SYSMENU.MENUNO
    /// </summary>
    public string MenuNo { get; set; } = null!;

    /// <summary>
    /// 操作編號 FK:SYSFUNCTION.FUNCNO
    /// </summary>
    public string FuncNo { get; set; } = null!;

    /// <summary>
    /// 權限旗標 1:可使用/0:不控管/-1:禁用
    /// </summary>
    public int UlLimit { get; set; }
}
