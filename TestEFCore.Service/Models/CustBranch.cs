using System;
using System.Collections.Generic;

namespace TestEFCore.Service.Models;

/// <summary>
/// 客戶資料單位
/// </summary>
public partial class CustBranch
{
    /// <summary>
    /// 客戶編號 FK:CUSTOMER.CUSTNO
    /// </summary>
    public string CustNo { get; set; } = null!;

    /// <summary>
    /// 單位編號
    /// </summary>
    public string CustBraNo { get; set; } = null!;

    /// <summary>
    /// 單位名稱
    /// </summary>
    public string CustBraNa { get; set; } = null!;

    /// <summary>
    /// 是否停用 0=啟用/1=停用
    /// </summary>
    public bool IsStop { get; set; }

    /// <summary>
    /// 聯絡人員
    /// </summary>
    public string ContName { get; set; } = null!;

    /// <summary>
    /// 聯絡電話
    /// </summary>
    public string ContTel { get; set; } = null!;

    /// <summary>
    /// 行動電話
    /// </summary>
    public string ContMobile { get; set; } = null!;

    /// <summary>
    /// 聯絡地址
    /// </summary>
    public string ContAddr { get; set; } = null!;

    /// <summary>
    /// 電子郵件
    /// </summary>
    public string ContEmail { get; set; } = null!;

    /// <summary>
    /// 連線方式
    /// </summary>
    public string Remote { get; set; } = null!;

    /// <summary>
    /// 單位備註
    /// </summary>
    public string CustBraRem { get; set; } = null!;

    public string Ip { get; set; } = null!;
}
