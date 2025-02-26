using System;
using System.Collections.Generic;

namespace TestEFCore.Service.Models;

/// <summary>
/// 系統功能選單
/// </summary>
public partial class SysMenu
{
    /// <summary>
    /// 系統類別
    /// </summary>
    public string SysType { get; set; } = null!;

    /// <summary>
    /// 排序編號
    /// </summary>
    public int ListNo { get; set; }

    /// <summary>
    /// 上層編號 MENUTYPE必須為F
    /// </summary>
    public int ParentNo { get; set; }

    /// <summary>
    /// 功能類別 F:目錄/P:程式
    /// </summary>
    public string MenuType { get; set; } = null!;

    /// <summary>
    /// 功能編號
    /// </summary>
    public string MenuNo { get; set; } = null!;

    /// <summary>
    /// 功能名稱
    /// </summary>
    public string MenuNa { get; set; } = null!;

    /// <summary>
    /// 功能說明
    /// </summary>
    public string MenuDesc { get; set; } = null!;

    /// <summary>
    /// 功能圖示路徑
    /// </summary>
    public string ImageUrl { get; set; } = null!;
}
