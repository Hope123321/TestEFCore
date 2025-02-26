using System;
using System.Collections.Generic;

namespace TestEFCore.Service.Models;

/// <summary>
/// 員工資料
/// </summary>
public partial class Employee
{
    /// <summary>
    /// 員工編號
    /// </summary>
    public string EmpNo { get; set; } = null!;

    /// <summary>
    /// 員工姓名
    /// </summary>
    public string EmpNa { get; set; } = null!;

    /// <summary>
    /// 身份證字號
    /// </summary>
    public string EmpId { get; set; } = null!;

    /// <summary>
    /// 職稱
    /// </summary>
    public string Title { get; set; } = null!;

    /// <summary>
    /// 電子郵件
    /// </summary>
    public string Email { get; set; } = null!;

    /// <summary>
    /// 地址
    /// </summary>
    public string Addr { get; set; } = null!;

    /// <summary>
    /// 電話一
    /// </summary>
    public string Tel1 { get; set; } = null!;

    /// <summary>
    /// 電話二
    /// </summary>
    public string Tel2 { get; set; } = null!;

    /// <summary>
    /// 行動電話
    /// </summary>
    public string Mobile { get; set; } = null!;

    /// <summary>
    /// 生日
    /// </summary>
    public string Birthday { get; set; } = null!;

    /// <summary>
    /// 前台售貨員旗標
    /// </summary>
    public bool IsEcrSales { get; set; }

    /// <summary>
    /// 業務員旗標
    /// </summary>
    public bool IsEmpSales { get; set; }

    /// <summary>
    /// 員工狀態 OK:正常/ED:停用/LV:離職
    /// </summary>
    public string EmpStatus { get; set; } = null!;

    /// <summary>
    /// 到職日期
    /// </summary>
    public string EffDate { get; set; } = null!;

    /// <summary>
    /// 離職日期
    /// </summary>
    public string ExtDate { get; set; } = null!;

    /// <summary>
    /// 員工卡號
    /// </summary>
    public string EmpCardNo { get; set; } = null!;

    /// <summary>
    /// 可簽到門市
    /// </summary>
    public string? LoginShop { get; set; }

    /// <summary>
    /// 自動更新會員
    /// </summary>
    public bool UpdVip { get; set; }

    /// <summary>
    /// 會員編號
    /// </summary>
    public string VipNo { get; set; } = null!;

    /// <summary>
    /// 會員型別
    /// </summary>
    public string VipTyNo { get; set; } = null!;

    public long TransStamp { get; set; }

    public byte[] DataStamp { get; set; } = null!;
}
