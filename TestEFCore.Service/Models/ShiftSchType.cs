using System;
using System.Collections.Generic;

namespace TestEFCore.Service.Models;

/// <summary>
/// 值機類別設定
/// </summary>
public partial class ShiftSchType
{
    /// <summary>
    /// 類別代碼
    /// </summary>
    public string ShiftTyNo { get; set; } = null!;

    /// <summary>
    /// 類別名稱
    /// </summary>
    public string ShiftTyNa { get; set; } = null!;

    /// <summary>
    /// 是否啟用 1=啟用/0=停用
    /// </summary>
    public bool IsUse { get; set; }

    /// <summary>
    /// 起始時間 HH:MM
    /// </summary>
    public string StTime { get; set; } = null!;

    /// <summary>
    /// 結束時間 HH:MM
    /// </summary>
    public string EdTime { get; set; } = null!;

    /// <summary>
    /// 值機時數
    /// </summary>
    public decimal ShiftHour { get; set; }

    /// <summary>
    /// 值機費倍率
    /// </summary>
    public decimal PayRate { get; set; }

    /// <summary>
    /// 日曆底色
    /// </summary>
    public string BackColor { get; set; } = null!;
}
