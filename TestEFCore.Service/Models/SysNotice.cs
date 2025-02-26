using System;
using System.Collections.Generic;

namespace TestEFCore.Service.Models;

/// <summary>
/// 總部公告
/// </summary>
public partial class SysNotice
{
    /// <summary>
    /// 公告編號 自動編號
    /// </summary>
    public int NtcNo { get; set; }

    public string NtcType { get; set; } = null!;

    /// <summary>
    /// 公告日期
    /// </summary>
    public string NtcDate { get; set; } = null!;

    /// <summary>
    /// 等級類別 S:極重要/A:重要/B:普通/C:一般
    /// </summary>
    public string NtcLevel { get; set; } = null!;

    /// <summary>
    /// 公告主旨
    /// </summary>
    public string Title { get; set; } = null!;

    /// <summary>
    /// 公告內容
    /// </summary>
    public string? Content { get; set; }

    /// <summary>
    /// 公告人員
    /// </summary>
    public string NtcEmpNa { get; set; } = null!;

    /// <summary>
    /// 公告/不公告
    /// </summary>
    public bool? NtcStatus { get; set; }

    public byte[] DataStamp { get; set; } = null!;

    public long TransStamp { get; set; }
}
