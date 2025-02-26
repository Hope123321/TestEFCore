using System;
using System.Collections.Generic;

namespace TestEFCore.Service.Models;

/// <summary>
/// 值機假日設定
/// </summary>
public partial class ShiftSchSet
{
    /// <summary>
    /// 年份
    /// </summary>
    public int Year { get; set; }

    /// <summary>
    /// 假日日期
    /// </summary>
    public string HldDate { get; set; } = null!;

    /// <summary>
    /// 假日名稱
    /// </summary>
    public string HldName { get; set; } = null!;

    /// <summary>
    /// 值機類別 FK:SHIFTSCHTYPE.SHIFTTYNO
    /// </summary>
    public string ShiftTyNo { get; set; } = null!;

    /// <summary>
    /// 文字顏色
    /// </summary>
    public string TextColor { get; set; } = null!;
}
