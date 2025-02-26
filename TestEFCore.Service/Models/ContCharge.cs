using System;
using System.Collections.Generic;

namespace TestEFCore.Service.Models;

/// <summary>
/// 合約資料計費
/// </summary>
public partial class ContCharge
{
    /// <summary>
    /// 合約編號 FK:CONTRACT.CONTNO
    /// </summary>
    public string ContNo { get; set; } = null!;

    /// <summary>
    /// 計費類別 C=客製增修/S=客服維運
    /// </summary>
    public string ChgType { get; set; } = null!;

    /// <summary>
    /// 計費單位 H=人時/D=人日
    /// </summary>
    public string ChgUnit { get; set; } = null!;

    /// <summary>
    /// 計費單價
    /// </summary>
    public decimal ChgPrc { get; set; }
}
