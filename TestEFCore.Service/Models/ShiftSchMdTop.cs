using System;
using System.Collections.Generic;

namespace TestEFCore.Service.Models;

/// <summary>
/// 值機調整記錄
/// </summary>
public partial class ShiftSchMdTop
{
    /// <summary>
    /// 調整單號
    /// </summary>
    public string SchMdNo { get; set; } = null!;

    /// <summary>
    /// 申請日期
    /// </summary>
    public string ApplyDate { get; set; } = null!;

    /// <summary>
    /// 申請時間 HH:MM
    /// </summary>
    public string ApplyTime { get; set; } = null!;

    /// <summary>
    /// 申請人員 FK:SYSUSER.USERNO
    /// </summary>
    public string ApplyUser { get; set; } = null!;

    /// <summary>
    /// 調整狀態 A=申請中/S=已簽核/D=已撤銷
    /// </summary>
    public string MdStatus { get; set; } = null!;

    /// <summary>
    /// 調整起始日期
    /// </summary>
    public string MdStDate { get; set; } = null!;

    /// <summary>
    /// 調整結束日期
    /// </summary>
    public string MdEdDate { get; set; } = null!;

    /// <summary>
    /// 調整值機人員 FK:SYSUSER.USERNO
    /// </summary>
    public string MdShiftUser { get; set; } = null!;

    public string MdShiftColor { get; set; } = null!;

    /// <summary>
    /// 簽核人員 FK:SYSUSER.USERNO
    /// </summary>
    public string SignUser { get; set; } = null!;

    /// <summary>
    /// 簽核日期
    /// </summary>
    public string SignDate { get; set; } = null!;

    /// <summary>
    /// 簽核時間 HH:MM
    /// </summary>
    public string SignTime { get; set; } = null!;

    /// <summary>
    /// 備註
    /// </summary>
    public string Rem { get; set; } = null!;
}
