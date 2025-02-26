using System;
using System.Collections.Generic;

namespace TestEFCore.Service.Models;

/// <summary>
/// 客戶資料公司
/// </summary>
public partial class CustCompany
{
    /// <summary>
    /// 客戶編號 FK:CUSTOMER.CUSTNO
    /// </summary>
    public string CustNo { get; set; } = null!;

    /// <summary>
    /// 公司統編
    /// </summary>
    public string CompNo { get; set; } = null!;

    /// <summary>
    /// 公司名稱
    /// </summary>
    public string CompNa { get; set; } = null!;

    /// <summary>
    /// 是否停用 0=啟用/1=停用
    /// </summary>
    public bool IsStop { get; set; }

    /// <summary>
    /// 負責人
    /// </summary>
    public string CompOwner { get; set; } = null!;

    /// <summary>
    /// 公司電話
    /// </summary>
    public string CompTel { get; set; } = null!;

    /// <summary>
    /// 公司傳真
    /// </summary>
    public string CompFax { get; set; } = null!;

    /// <summary>
    /// 公司地址
    /// </summary>
    public string CompAddr { get; set; } = null!;

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
    /// 電子郵件
    /// </summary>
    public string ContEmail { get; set; } = null!;

    /// <summary>
    /// 公司備註
    /// </summary>
    public string CompRem { get; set; } = null!;
}
