using System;
using System.Collections.Generic;

namespace AssetRegistry.Models;

public partial class AssetStatus
{
    public int StatusId { get; set; }

    public string StatusName { get; set; } = null!;

    public virtual ICollection<Asset> Assets { get; set; } = new List<Asset>();
}
