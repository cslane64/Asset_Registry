using System;
using System.Collections.Generic;

namespace AssetRegistry.Models;

public partial class AssetType
{
    public int AssetTypeId { get; set; }

    public string AssetTypeName { get; set; } = null!;

    public virtual ICollection<Asset> Assets { get; set; } = new List<Asset>();
}
