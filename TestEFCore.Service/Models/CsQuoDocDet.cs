using System;
using System.Collections.Generic;

namespace TestEFCore.Service.Models;

/// <summary>
/// 報價單據明細
/// </summary>
public partial class CsQuoDocDet
{
    /// <summary>
    /// 報價單號 FK:CSQUODOCTOP.QUONO
    /// </summary>
    public string QuoNo { get; set; } = null!;

    /// <summary>
    /// 項次
    /// </summary>
    public int ItemOrd { get; set; }

    /// <summary>
    /// 報價項目
    /// </summary>
    public string QuoItem { get; set; } = null!;

    /// <summary>
    /// 單價
    /// </summary>
    public decimal Prc { get; set; }

    /// <summary>
    /// 數量
    /// </summary>
    public decimal Qty { get; set; }
}
