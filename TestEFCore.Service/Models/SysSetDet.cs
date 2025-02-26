using System;
using System.Collections.Generic;

namespace TestEFCore.Service.Models;

/// <summary>
/// 系統參數明細
/// </summary>
public partial class SysSetDet
{
    /// <summary>
    /// 群組編號 FK:SYSSETTOP.SETTOPNO
    /// </summary>
    public string SetTopNo { get; set; } = null!;

    /// <summary>
    /// 參數編號
    /// </summary>
    public string SetNo { get; set; } = null!;

    /// <summary>
    /// 參數名稱
    /// </summary>
    public string SetNa { get; set; } = null!;

    /// <summary>
    /// 參數最大長度
    /// </summary>
    public int MaxLength { get; set; }

    /// <summary>
    /// 參數資料型態
    /// </summary>
    public string DataType { get; set; } = null!;

    /// <summary>
    /// 數值型態最大值
    /// </summary>
    public int MaxValue { get; set; }

    /// <summary>
    /// 數值型態最小值
    /// </summary>
    public int MinValue { get; set; }

    /// <summary>
    /// 集合內容
    /// </summary>
    public string ListItem { get; set; } = null!;

    /// <summary>
    /// 參數值
    /// </summary>
    public string SetValue { get; set; } = null!;

    /// <summary>
    /// 參數說明
    /// </summary>
    public string SetRem { get; set; } = null!;

    /// <summary>
    /// 可視旗標
    /// </summary>
    public bool IsSetShow { get; set; }

    /// <summary>
    /// 設定旗標
    /// </summary>
    public bool IsSetEdit { get; set; }

    /// <summary>
    /// 參數排序
    /// </summary>
    public int SetSort { get; set; }
}
