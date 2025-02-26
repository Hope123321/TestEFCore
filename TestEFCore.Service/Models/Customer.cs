using System;
using System.Collections.Generic;

namespace TestEFCore.Service.Models;

/// <summary>
/// 客戶資料
/// </summary>
public partial class Customer
{
    /// <summary>
    /// 客戶編號
    /// </summary>
    public string CustNo { get; set; } = null!;

    /// <summary>
    /// 客戶名稱
    /// </summary>
    public string CustNa { get; set; } = null!;

    /// <summary>
    /// 是否停用 0=啟用/1=停用
    /// </summary>
    public bool IsStop { get; set; }

    /// <summary>
    /// 上線日期
    /// </summary>
    public string OnlineDate { get; set; } = null!;

    /// <summary>
    /// 研發人員1 FK:SYSUSER.USERNO
    /// </summary>
    public string CustDev1 { get; set; } = null!;

    /// <summary>
    /// 研發人員2 FK:SYSUSER.USERNO
    /// </summary>
    public string CustDev2 { get; set; } = null!;

    /// <summary>
    /// 客服人員1 FK:SYSUSER.USERNO
    /// </summary>
    public string CustOps1 { get; set; } = null!;

    /// <summary>
    /// 客服人員2 FK:SYSUSER.USERNO
    /// </summary>
    public string CustOps2 { get; set; } = null!;

    /// <summary>
    /// 客戶備註
    /// </summary>
    public string CustRem { get; set; } = null!;
}
