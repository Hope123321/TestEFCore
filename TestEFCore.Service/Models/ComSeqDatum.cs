using System;
using System.Collections.Generic;

namespace TestEFCore.Service.Models;

/// <summary>
/// 共用編號資料
/// </summary>
public partial class ComSeqDatum
{
    /// <summary>
    /// 編號類別
    /// </summary>
    public string SeqType { get; set; } = null!;

    /// <summary>
    /// 編號日期
    /// </summary>
    public string SeqDate { get; set; } = null!;

    /// <summary>
    /// 最大編號
    /// </summary>
    public int SeqNo { get; set; }
}
