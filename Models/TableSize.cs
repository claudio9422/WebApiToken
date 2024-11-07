using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class TableSize
{
    public string? Name { get; set; }

    public string? Rows { get; set; }

    public string? Reserved { get; set; }

    public string? Data { get; set; }

    public string? IndexSize { get; set; }

    public string? Unused { get; set; }
}
