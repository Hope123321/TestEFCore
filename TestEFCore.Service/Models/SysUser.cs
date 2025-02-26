using System;
using System.Collections.Generic;

namespace TestEFCore.Service.Models;

/// <summary>
/// 系統帳號資料
/// </summary>
public partial class SysUser
{
    /// <summary>
    /// 帳號編號 英文不區分大小寫
    /// </summary>
    public string UserNo { get; set; } = null!;

    /// <summary>
    /// 帳號名稱
    /// </summary>
    public string UserNa { get; set; } = null!;

    /// <summary>
    /// 帳號密碼 SHA256(英文區分大小寫)
    /// </summary>
    public string UserPwd { get; set; } = null!;

    /// <summary>
    /// 前台登入密碼 SHA256(英文全部大寫)
    /// </summary>
    public string EcrPwd { get; set; } = null!;

    /// <summary>
    /// 員工編號 FK:EMPLOYEE.EMPNO
    /// </summary>
    public string EmpNo { get; set; } = null!;

    /// <summary>
    /// 店櫃編號 FK:SHOP.SHOPNO
    /// </summary>
    public string ShopNo { get; set; } = null!;

    /// <summary>
    /// 帳號狀態 OK:正常/ED:停用/LC:鎖定
    /// </summary>
    public string UserStatus { get; set; } = null!;

    /// <summary>
    /// 密碼變更日期
    /// </summary>
    public string PwdChgDate { get; set; } = null!;

    /// <summary>
    /// 密碼有效日期
    /// </summary>
    public string PwdEffDate { get; set; } = null!;

    /// <summary>
    /// 密碼輸入錯誤
    /// </summary>
    public int PwdError { get; set; }

    /// <summary>
    /// 密碼錯誤時間
    /// </summary>
    public DateTime? PwdErrTime { get; set; }

    /// <summary>
    /// 前台使用旗標
    /// </summary>
    public bool IsEcrCashier { get; set; }

    /// <summary>
    /// 後台使用旗標
    /// </summary>
    public bool IsWebUser { get; set; }

    public string Avatar { get; set; } = null!;
}
