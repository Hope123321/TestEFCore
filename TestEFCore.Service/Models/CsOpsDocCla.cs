using System;
using System.Collections.Generic;

namespace TestEFCore.Service.Models;

/// <summary>
/// 服務單據記錄
/// </summary>
public partial class CsOpsDocCla
{
    /// <summary>
    /// 服務單號 FK:CSOPSDOCTOP.OPSNO
    /// </summary>
    public string OpsNo { get; set; } = null!;

    /// <summary>
    /// 分類階層01
    /// </summary>
    public string Cno01 { get; set; } = null!;

    /// <summary>
    /// 分類階層02
    /// </summary>
    public string Cno02 { get; set; } = null!;

    /// <summary>
    /// 分類階層03
    /// </summary>
    public string Cno03 { get; set; } = null!;

    /// <summary>
    /// 分類階層04
    /// </summary>
    public string Cno04 { get; set; } = null!;

    /// <summary>
    /// 分類階層05
    /// </summary>
    public string Cno05 { get; set; } = null!;

    /// <summary>
    /// 分類階層06
    /// </summary>
    public string Cno06 { get; set; } = null!;

    /// <summary>
    /// 分類階層07
    /// </summary>
    public string Cno07 { get; set; } = null!;

    /// <summary>
    /// 分類階層08
    /// </summary>
    public string Cno08 { get; set; } = null!;

    /// <summary>
    /// 分類階層09
    /// </summary>
    public string Cno09 { get; set; } = null!;

    /// <summary>
    /// 分類階層10
    /// </summary>
    public string Cno10 { get; set; } = null!;
}
