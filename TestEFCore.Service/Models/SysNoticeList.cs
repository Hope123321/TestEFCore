using System;
using System.Collections.Generic;

namespace TestEFCore.Service.Models;

/// <summary>
/// 公告收文單位清單
/// </summary>
public partial class SysNoticeList
{
    /// <summary>
    /// 公告編號
    /// </summary>
    public int NtcNo { get; set; }

    /// <summary>
    /// 單位代碼
    /// </summary>
    public string RecvNo { get; set; } = null!;

    public byte[] DataStamp { get; set; } = null!;

    public long TransStamp { get; set; }
}
