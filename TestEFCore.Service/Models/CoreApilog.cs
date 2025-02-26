using System;
using System.Collections.Generic;

namespace TestEFCore.Service.Models;

/// <summary>
/// CoreAPI傳輸記錄
/// </summary>
public partial class CoreApilog
{
    /// <summary>
    /// 記錄序號
    /// </summary>
    public long LogNo { get; set; }

    /// <summary>
    /// 記錄時間
    /// </summary>
    public DateTime? LogDateTime { get; set; }

    /// <summary>
    /// 記錄來源
    /// </summary>
    public string LogIp { get; set; } = null!;

    /// <summary>
    /// 連線識別碼 FK:COREAPISET.TOKEN
    /// </summary>
    public string Token { get; set; } = null!;

    /// <summary>
    /// 時間戳記
    /// </summary>
    public long Timestamp { get; set; }

    /// <summary>
    /// API方法 參考API規格說明文件
    /// </summary>
    public string Apimethod { get; set; } = null!;

    /// <summary>
    /// 要求資料 存放要求JSON資料內容(明文)
    /// </summary>
    public string Request { get; set; } = null!;

    public string? Signature { get; set; }

    public string Response { get; set; } = null!;
}
