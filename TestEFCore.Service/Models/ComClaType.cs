using System;
using System.Collections.Generic;

namespace TestEFCore.Service.Models;

/// <summary>
/// 共用分類類別
/// </summary>
public partial class ComClaType
{
    /// <summary>
    /// 共用代碼 CSOPS=客戶服務
    /// </summary>
    public string ComNo { get; set; } = null!;

    /// <summary>
    /// 類別代碼 01/02../10
    /// </summary>
    public string ClaTyNo { get; set; } = null!;

    /// <summary>
    /// 類別名稱
    /// </summary>
    public string ClaTyNa { get; set; } = null!;

    /// <summary>
    /// 是否啟用
    /// </summary>
    public bool IsUse { get; set; }

    /// <summary>
    /// 必要分類
    /// </summary>
    public bool IsMust { get; set; }

    /// <summary>
    /// 上層分類 FK:COMCLATYPE.CLATYNO
    /// </summary>
    public string PclaTyNo { get; set; } = null!;
}
