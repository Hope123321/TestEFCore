using System;
using System.Collections.Generic;

namespace TestEFCore.Service.Models;

/// <summary>
/// 系統參數群組
/// </summary>
public partial class SysSetTop
{
    /// <summary>
    /// 群組編號
    /// </summary>
    public string SetTopNo { get; set; } = null!;

    /// <summary>
    /// 群組名稱
    /// </summary>
    public string SetTopNa { get; set; } = null!;

    /// <summary>
    /// 群組說明
    /// </summary>
    public string SetTopRem { get; set; } = null!;

    /// <summary>
    /// 群組排序
    /// </summary>
    public int SetTopSort { get; set; }
}
