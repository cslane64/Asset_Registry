using System;
using System.Collections.Generic;

namespace AssetRegistry.Models;

public partial class AssetRegistryImport
{
    public string? AssetType { get; set; }

    public string? MakeAndModel { get; set; }

    public string? SerialNum { get; set; }

    public string? Hostname { get; set; }

    public string? OperatingSystem { get; set; }

    public string? AssignedUser { get; set; }

    public string? Location { get; set; }

    public string? BusinessCriticality { get; set; }

    public string? EndOfSupportWarranty { get; set; }

    public string? Status { get; set; }

    public string? LastVerified { get; set; }

    public string? Notes { get; set; }

    public int AssetId { get; set; }
}
