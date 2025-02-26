using System;
using System.Collections.Generic;

namespace TestEFCore.Service.Models;

public partial class SysLocale
{
    public string LocaleNo { get; set; } = null!;

    public string? LocaleNa { get; set; }

    public string? Rem { get; set; }
}
