using System;
using System.Collections.Generic;

namespace TestEFCore.Service.Models;

/// <summary>
/// 合約資料時段
/// </summary>
public partial class ContTime
{
    /// <summary>
    /// 合約編號 FK:CONTRACT.CONTNO
    /// </summary>
    public string ContNo { get; set; } = null!;

    /// <summary>
    /// 時段類別 W=平日/H=假日
    /// </summary>
    public string TimeType { get; set; } = null!;

    /// <summary>
    /// 起始時間 HH:MM
    /// </summary>
    public string StTime { get; set; } = null!;

    /// <summary>
    /// 結束時間 HH:MM
    /// </summary>
    public string EdTime { get; set; } = null!;
}
