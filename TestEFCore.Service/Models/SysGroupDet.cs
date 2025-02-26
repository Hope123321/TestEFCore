using System;
using System.Collections.Generic;

namespace TestEFCore.Service.Models;

/// <summary>
/// 系統群組明細
/// </summary>
public partial class SysGroupDet
{
    /// <summary>
    /// 群組編號 FK:SYSGROUPTOP.GRPNO
    /// </summary>
    public string GrpNo { get; set; } = null!;

    /// <summary>
    /// 帳號編號
    /// </summary>
    public string UserNo { get; set; } = null!;
}
