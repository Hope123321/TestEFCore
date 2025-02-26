using System;
using System.Collections.Generic;

namespace TestEFCore.Service.Models;

/// <summary>
/// 共用分類資料
/// </summary>
public partial class ComClaDatum
{
    /// <summary>
    /// 共用代碼 CSOPS=客戶服務
    /// </summary>
    public string ComNo { get; set; } = null!;

    /// <summary>
    /// 類別代碼 FK:COMCLATYPE.CLATYNO
    /// </summary>
    public string ClaTyNo { get; set; } = null!;

    /// <summary>
    /// 分類代碼
    /// </summary>
    public string ClaNo { get; set; } = null!;

    /// <summary>
    /// 分類名稱
    /// </summary>
    public string ClaNa { get; set; } = null!;

    /// <summary>
    /// 上層分類代碼 FK:COMCLADATA.CLANO
    /// </summary>
    public string PclaNo { get; set; } = null!;
}
