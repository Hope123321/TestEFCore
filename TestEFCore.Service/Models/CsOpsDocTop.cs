using System;
using System.Collections.Generic;

namespace TestEFCore.Service.Models;

/// <summary>
/// 服務單據記錄
/// </summary>
public partial class CsOpsDocTop
{
    /// <summary>
    /// 服務單號
    /// </summary>
    public string OpsNo { get; set; } = null!;

    /// <summary>
    /// 客戶編號 FK:CUSTOMER.CUSTNO
    /// </summary>
    public string CustNo { get; set; } = null!;

    /// <summary>
    /// 單位編號 FK:CUSTBRANCH.CUSTBRANO
    /// </summary>
    public string CustBraNo { get; set; } = null!;

    /// <summary>
    /// 服務說明
    /// </summary>
    public string OpsDesc { get; set; } = null!;

    /// <summary>
    /// 處理說明
    /// </summary>
    public string ProcDesc { get; set; } = null!;

    /// <summary>
    /// 服務狀態 C.待處理/P.處理中/Y.已結案
    /// </summary>
    public string OpsStatus { get; set; } = null!;

    /// <summary>
    /// 時段類別 W=平日/H=假日
    /// </summary>
    public string TimeType { get; set; } = null!;

    /// <summary>
    /// 聯絡人員
    /// </summary>
    public string ContName { get; set; } = null!;

    /// <summary>
    /// 聯絡電話
    /// </summary>
    public string ContTel { get; set; } = null!;

    /// <summary>
    /// 服務備註
    /// </summary>
    public string OpsRem { get; set; } = null!;

    /// <summary>
    /// 服務人員 FK:SYSUSER.USERNO
    /// </summary>
    public string OpsUser { get; set; } = null!;

    /// <summary>
    /// 服務日期
    /// </summary>
    public string OpsDate { get; set; } = null!;

    /// <summary>
    /// 服務時間 HH:MM
    /// </summary>
    public string OpsTime { get; set; } = null!;

    /// <summary>
    /// 服務工時
    /// </summary>
    public decimal OpsHour { get; set; }

    /// <summary>
    /// 結案人員 FK:SYSUSER.USERNO
    /// </summary>
    public string CloseUser { get; set; } = null!;

    /// <summary>
    /// 結案日期
    /// </summary>
    public string CloseDate { get; set; } = null!;

    /// <summary>
    /// 結案時間 HH:MM
    /// </summary>
    public string CloseTime { get; set; } = null!;
}
