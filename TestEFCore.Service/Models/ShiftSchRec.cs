using System;
using System.Collections.Generic;

namespace TestEFCore.Service.Models;

/// <summary>
/// 值機排班記錄
/// </summary>
public partial class ShiftSchRec
{
    /// <summary>
    /// 年份
    /// </summary>
    public int Year { get; set; }

    /// <summary>
    /// 值機日期
    /// </summary>
    public string ShiftDate { get; set; } = null!;

    /// <summary>
    /// 值機人員 FK:SYSUSER.USERNO
    /// </summary>
    public string ShiftUser { get; set; } = null!;

    /// <summary>
    /// 文字顏色
    /// </summary>
    public string TextColor { get; set; } = null!;

    /// <summary>
    /// 結算狀態 CF=已確認/S=已簽核/CL=已結算
    /// </summary>
    public string CloseStatus { get; set; } = null!;

    /// <summary>
    /// 更新人員 FK:SYSUSER.USERNO
    /// </summary>
    public string UpdateUser { get; set; } = null!;

    /// <summary>
    /// 更新時間 YYYY/MM/DD HH:MM
    /// </summary>
    public string UpdateTime { get; set; } = null!;
}
