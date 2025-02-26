using System;
using System.Collections.Generic;

namespace TestEFCore.Service.Models;

/// <summary>
/// 報價單據記錄
/// </summary>
public partial class CsQuoDocTop
{
    /// <summary>
    /// 報價單號
    /// </summary>
    public string QuoNo { get; set; } = null!;

    /// <summary>
    /// 報價名稱
    /// </summary>
    public string QuoNa { get; set; } = null!;

    /// <summary>
    /// 報價狀態 Q=報價/S=簽回/D=作廢
    /// </summary>
    public string QuoStatus { get; set; } = null!;

    /// <summary>
    /// 客戶統編 FK:CUSTCOMPANY.COMPNO
    /// </summary>
    public string CompNo { get; set; } = null!;

    /// <summary>
    /// 聯絡人員
    /// </summary>
    public string ContName { get; set; } = null!;

    /// <summary>
    /// 聯絡電話
    /// </summary>
    public string ContTel { get; set; } = null!;

    /// <summary>
    /// 聯絡信箱
    /// </summary>
    public string ContEmail { get; set; } = null!;

    /// <summary>
    /// 承辦人員 FK:SYSUSER.USERNO
    /// </summary>
    public string QuoUser { get; set; } = null!;

    /// <summary>
    /// 承辦電話
    /// </summary>
    public string Tel { get; set; } = null!;

    /// <summary>
    /// 報價日期
    /// </summary>
    public string QuoDate { get; set; } = null!;

    /// <summary>
    /// 報價金額
    /// </summary>
    public decimal QuoAmt { get; set; }

    /// <summary>
    /// 報價備註
    /// </summary>
    public string QuoRem { get; set; } = null!;

    /// <summary>
    /// 單據備註
    /// </summary>
    public string DocRem { get; set; } = null!;

    /// <summary>
    /// 報價類別 R=客製增修/H=硬體採購/F=設備維修
    /// </summary>
    public string QuoType { get; set; } = null!;

    /// <summary>
    /// 關聯單號 依QUOTYPE關聯不同資料表
    /// </summary>
    public string LinkDocNo { get; set; } = null!;

    /// <summary>
    /// 電子文檔 實體檔案儲存，僅記錄檔名(含副檔名)
    /// </summary>
    public string DocFile { get; set; } = null!;
}
