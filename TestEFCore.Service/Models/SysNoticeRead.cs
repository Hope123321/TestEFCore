using System;
using System.Collections.Generic;

namespace TestEFCore.Service.Models;

/// <summary>
/// 總部公告讀取記錄
/// </summary>
public partial class SysNoticeRead
{
    /// <summary>
    /// 公告編號 FK:SYSNOTICE.NTCNO
    /// </summary>
    public int NtcNo { get; set; }

    /// <summary>
    /// 讀取員工
    /// </summary>
    public string EmpNo { get; set; } = null!;

    /// <summary>
    /// 員工所屬店櫃
    /// </summary>
    public string ShopNo { get; set; } = null!;

    /// <summary>
    /// 讀取日期
    /// </summary>
    public string ReadDate { get; set; } = null!;

    /// <summary>
    /// 讀取時間 24H
    /// </summary>
    public string ReadTime { get; set; } = null!;
}
