using System;
using System.Collections.Generic;

namespace TestEFCore.Service.Models;

public partial class SysLocaleDatum
{
    public string LocaleNo { get; set; } = null!;

    public string MenuNo { get; set; } = null!;

    public string DisplayKey { get; set; } = null!;

    public string? DisplayValue { get; set; }

    public string? Rem { get; set; }
}
