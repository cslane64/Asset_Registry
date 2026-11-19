using System;
using System.Collections.Generic;

namespace AssetRegistry.Models;

public partial class User
{
    public int UserId { get; set; }

    public string LastName { get; set; } = null!;

    public string? FirstName { get; set; }

    public string? Email { get; set; }

    public string? Username { get; set; }

    public string? Department { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual ICollection<Asset> Assets { get; set; } = new List<Asset>();
}
