using System;
using System.Collections.Generic;

namespace TestEFCore.Service.Models;

/// <summary>
/// 需求單據記錄
/// </summary>
public partial class CsReqDocTop
{
    /// <summary>
    /// 需求單號
    /// </summary>
    public string ReqNo { get; set; } = null!;

    /// <summary>
    /// 需求名稱
    /// </summary>
    public string ReqNa { get; set; } = null!;

    /// <summary>
    /// 客戶編號 FK:CUSTOMER.CUSTNO
    /// </summary>
    public string CustNo { get; set; } = null!;

    /// <summary>
    /// 合約編號 FK:CONTRACT.CONTNO
    /// </summary>
    public string ContNo { get; set; } = null!;

    /// <summary>
    /// 需求狀態 A=申請/Y=確認/F=結案/C=取消/D=作廢
    /// </summary>
    public string ReqStatus { get; set; } = null!;

    /// <summary>
    /// 申請日期
    /// </summary>
    public string ReqDate { get; set; } = null!;

    /// <summary>
    /// 申請人員
    /// </summary>
    public string ReqUser { get; set; } = null!;

    /// <summary>
    /// 需求說明
    /// </summary>
    public string ReqDesc { get; set; } = null!;

    /// <summary>
    /// 客服人員 FK:SYSUSER.USERNO
    /// </summary>
    public string OpsUser { get; set; } = null!;

    /// <summary>
    /// 評估人員 FK:SYSUSER.USERNO
    /// </summary>
    public string EstUser { get; set; } = null!;

    /// <summary>
    /// 開發人員 FK:SYSUSER.USERNO
    /// </summary>
    public string? DevUser { get; set; }

    /// <summary>
    /// 評估說明
    /// </summary>
    public string EstDesc { get; set; } = null!;

    /// <summary>
    /// 評估單位 H=人時/D=人日
    /// </summary>
    public string EstUnit { get; set; } = null!;

    /// <summary>
    /// 評估單價 可利用合約自動帶入
    /// </summary>
    public decimal EstPrc { get; set; }

    /// <summary>
    /// 評估數量
    /// </summary>
    public decimal EstQty { get; set; }

    /// <summary>
    /// 預計完成日
    /// </summary>
    public string EstDate { get; set; } = null!;

    /// <summary>
    /// 執行狀態 RA=待評估/CF=待確認/SA=待派工/PG=執行中/TS=交測中/OK=已驗收
    /// </summary>
    public string ExeStatus { get; set; } = null!;

    /// <summary>
    /// 確認日期
    /// </summary>
    public string CfmDate { get; set; } = null!;

    /// <summary>
    /// 交測日期
    /// </summary>
    public string DlvDate { get; set; } = null!;

    /// <summary>
    /// 驗收日期
    /// </summary>
    public string AccDate { get; set; } = null!;

    /// <summary>
    /// 需求備註
    /// </summary>
    public string ReqRem { get; set; } = null!;

    /// <summary>
    /// 請款類別 N=合約範圍不計費/Y=報價收費或合約人日折抵
    /// </summary>
    public string InvType { get; set; } = null!;

    /// <summary>
    /// 請款狀態 N.無須請款/W.等待請款/Y.完成請款
    /// </summary>
    public string InvStatus { get; set; } = null!;

    /// <summary>
    /// 請款金額
    /// </summary>
    public decimal InvAmt { get; set; }

    /// <summary>
    /// 發票日期
    /// </summary>
    public string InvDate { get; set; } = null!;

    /// <summary>
    /// 發票號碼
    /// </summary>
    public string InvNo { get; set; } = null!;

    /// <summary>
    /// 請款備註
    /// </summary>
    public string InvRem { get; set; } = null!;

    /// <summary>
    /// 電子文檔 實體檔案儲存，僅記錄檔名(含副檔名)
    /// </summary>
    public string DocFile { get; set; } = null!;
}
