using System;
using System.Collections.Generic;

namespace TestEFCore.Service.Models;

/// <summary>
/// 合約資料
/// </summary>
public partial class Contract
{
    /// <summary>
    /// 合約編號
    /// </summary>
    public string ContNo { get; set; } = null!;

    /// <summary>
    /// 合約名稱
    /// </summary>
    public string ContNa { get; set; } = null!;

    /// <summary>
    /// 客戶編號 FK:CUSTOMER.CUSTNO
    /// </summary>
    public string CustNo { get; set; } = null!;

    /// <summary>
    /// 合約類別 C=新案/S=維護
    /// </summary>
    public string ContType { get; set; } = null!;

    /// <summary>
    /// 原案合約 FK:CONTACT.CONTNO
    /// </summary>
    public string CauseNo { get; set; } = null!;

    /// <summary>
    /// 起始日期
    /// </summary>
    public string StDate { get; set; } = null!;

    /// <summary>
    /// 結束日期
    /// </summary>
    public string EdDate { get; set; } = null!;

    /// <summary>
    /// 終止日期
    /// </summary>
    public string StopDate { get; set; } = null!;

    /// <summary>
    /// 合約金額
    /// </summary>
    public decimal Amount { get; set; }

    /// <summary>
    /// 維護費率
    /// </summary>
    public decimal OpsRate { get; set; }

    /// <summary>
    /// 合約人日
    /// </summary>
    public int ContDay { get; set; }

    /// <summary>
    /// 增購人日
    /// </summary>
    public int BuyDay { get; set; }

    /// <summary>
    /// 合約備註
    /// </summary>
    public string ContRem { get; set; } = null!;

    /// <summary>
    /// 電子文檔 實體檔案儲存，僅記錄檔名(含副檔名)
    /// </summary>
    public string DocFile { get; set; } = null!;
}
