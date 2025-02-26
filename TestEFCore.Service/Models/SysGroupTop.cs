using System;
using System.Collections.Generic;

namespace TestEFCore.Service.Models;

/// <summary>
/// 系統群組資料
/// </summary>
public partial class SysGroupTop
{
    /// <summary>
    /// 群組編號
    /// </summary>
    public string GrpNo { get; set; } = null!;

    /// <summary>
    /// 群組名稱
    /// </summary>
    public string GrpNa { get; set; } = null!;

    /// <summary>
    /// 群組備註
    /// </summary>
    public string GrpRem { get; set; } = null!;
}
