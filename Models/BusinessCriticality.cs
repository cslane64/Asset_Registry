using System;
using System.Collections.Generic;

namespace AssetRegistry.Models;

public partial class BusinessCriticality
{
    public int CriticalityId { get; set; }

    public string CriticalityName { get; set; } = null!;

    public virtual ICollection<Asset> Assets { get; set; } = new List<Asset>();
}
