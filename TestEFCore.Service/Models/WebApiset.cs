using System;
using System.Collections.Generic;

namespace TestEFCore.Service.Models;

/// <summary>
/// 程式介面連線設定
/// </summary>
public partial class WebApiset
{
    /// <summary>
    /// 連線識別碼
    /// </summary>
    public string Token { get; set; } = null!;

    /// <summary>
    /// 系統類型 EC=網購平台/APP=行動裝置/POS=收銀系統/LINE=LINE@/MMS=點餐平台
    /// </summary>
    public string SysType { get; set; } = null!;

    /// <summary>
    /// 品牌代碼
    /// </summary>
    public string SysBraNo { get; set; } = null!;

    /// <summary>
    /// Key
    /// </summary>
    public string Apikey { get; set; } = null!;

    /// <summary>
    /// IV
    /// </summary>
    public string Apiiv { get; set; } = null!;

    /// <summary>
    /// SaltKey
    /// </summary>
    public string ApisaltKey { get; set; } = null!;

    /// <summary>
    /// 會員新增模式 M10=單筆消費滿額
    /// </summary>
    public string DefRegMdNo { get; set; } = null!;

    /// <summary>
    /// 會員新增型別
    /// </summary>
    public string DefVpTyNo { get; set; } = null!;

    /// <summary>
    /// 會員申辦店櫃
    /// </summary>
    public string DefShopNo { get; set; } = null!;

    /// <summary>
    /// 會員綁定模式 Y=註記且對照型別/N=註記不對照型別
    /// </summary>
    public string BindingType { get; set; } = null!;

    /// <summary>
    /// 會員批次戳記 儲存會員批次查詢最後戳記
    /// </summary>
    public long VipStamp { get; set; }

    /// <summary>
    /// 簽章加密類型 SHA256/SHA512(預設)
    /// </summary>
    public string EncodingType { get; set; } = null!;

    /// <summary>
    /// 庫存計算類型 Q=即時庫存表/S=標準推算(預設)
    /// </summary>
    public string GdsQtyType { get; set; } = null!;

    public string CreditCard { get; set; } = null!;
}
