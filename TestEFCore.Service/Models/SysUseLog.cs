using System;
using System.Collections.Generic;

namespace TestEFCore.Service.Models;

/// <summary>
/// 系統使用記錄
/// </summary>
public partial class SysUseLog
{
    /// <summary>
    /// 記錄編號
    /// </summary>
    public long LogNo { get; set; }

    /// <summary>
    /// 記錄類型 IO:登入登出/PW:密碼/AT:操作
    /// </summary>
    public string LogType { get; set; } = null!;

    /// <summary>
    /// 系統類別 FK:SYSMENU.SYSTYPE
    /// </summary>
    public string SysType { get; set; } = null!;

    /// <summary>
    /// 功能編號 FK:SYSMENU.MENUNO
    /// </summary>
    public string MenuNo { get; set; } = null!;

    /// <summary>
    /// 操作名稱
    /// </summary>
    public string FuncNa { get; set; } = null!;

    /// <summary>
    /// 帳號名稱
    /// </summary>
    public string UserNa { get; set; } = null!;

    /// <summary>
    /// 來源位置
    /// </summary>
    public string LogIp { get; set; } = null!;

    /// <summary>
    /// 記錄日期
    /// </summary>
    public string LogDate { get; set; } = null!;

    /// <summary>
    /// 記錄時間
    /// </summary>
    public string LogTime { get; set; } = null!;

    /// <summary>
    /// 記錄主鍵值 記錄操作異動資料主鍵值
    /// </summary>
    public string LogPk { get; set; } = null!;

    /// <summary>
    /// 記錄備註
    /// </summary>
    public string LogRem { get; set; } = null!;
}
