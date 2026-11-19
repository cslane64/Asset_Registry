using System;
using System.Collections.Generic;
using AssetRegistry.Models;
using Microsoft.EntityFrameworkCore;

namespace AssetRegistry.Data;

public partial class YourDatabaseContext : DbContext
{
    public YourDatabaseContext()
    {
    }

    public YourDatabaseContext(DbContextOptions<YourDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Asset> Assets { get; set; }

    public virtual DbSet<AssetRegistryImport> AssetRegistryImports { get; set; }

    public virtual DbSet<AssetStatus> AssetStatuses { get; set; }

    public virtual DbSet<AssetType> AssetTypes { get; set; }

    public virtual DbSet<BusinessCriticality> BusinessCriticalities { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Intentionally empty. Program.cs configures DbContext via DI.
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Asset>(entity =>
        {
            entity.HasKey(e => e.AssetId).HasName("PK__Assets__D28B561DC97271E3");

            entity.Property(e => e.AssetId)
                .HasMaxLength(100)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("(CONVERT([nvarchar](200),NEXT VALUE FOR [dbo].[AssetIdSequence]))")
                .HasColumnName("asset_id");
            entity.Property(e => e.AssetTypeId).HasColumnName("asset_type_id");
            entity.Property(e => e.AssignedUserId).HasColumnName("assigned_user_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnName("created_at");
            entity.Property(e => e.CriticalityId).HasColumnName("criticality_id");
            entity.Property(e => e.Hostname)
                .HasMaxLength(255)
                .HasColumnName("hostname");
            entity.Property(e => e.LastVerified).HasColumnName("last_verified");
            entity.Property(e => e.LocationId).HasColumnName("location_id");
            entity.Property(e => e.MakeAndModel)
                .HasMaxLength(255)
                .HasColumnName("make_and_model");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.OperatingSystem)
                .HasMaxLength(255)
                .HasColumnName("operating_system");
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(255)
                .HasColumnName("serial_number");
            entity.Property(e => e.StatusId).HasColumnName("status_id");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnName("updated_at");
            entity.Property(e => e.WarrantyOrEndOfSupport).HasColumnName("warranty_or_end_of_support");

            entity.HasOne(d => d.AssetType).WithMany(p => p.Assets)
                .HasForeignKey(d => d.AssetTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Assets__asset_ty__5CD6CB2B");

            entity.HasOne(d => d.AssignedUser).WithMany(p => p.Assets)
                .HasForeignKey(d => d.AssignedUserId)
                .HasConstraintName("FK__Assets__assigned__5DCAEF64");

            entity.HasOne(d => d.Criticality).WithMany(p => p.Assets)
                .HasForeignKey(d => d.CriticalityId)
                .HasConstraintName("FK__Assets__critical__5FB337D6");

            entity.HasOne(d => d.Location).WithMany(p => p.Assets)
                .HasForeignKey(d => d.LocationId)
                .HasConstraintName("FK__Assets__location__5EBF139D");

            entity.HasOne(d => d.Status).WithMany(p => p.Assets)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("FK__Assets__status_i__60A75C0F");
        });

        modelBuilder.Entity<AssetRegistryImport>(entity =>
        {
            entity.HasKey(e => e.AssetId);

            entity.ToTable("AssetRegistryImport");

            entity.Property(e => e.AssetType)
                .HasMaxLength(100)
                .HasColumnName("assetType");
            entity.Property(e => e.AssignedUser)
                .HasMaxLength(255)
                .HasColumnName("assignedUser");
            entity.Property(e => e.BusinessCriticality)
                .HasMaxLength(50)
                .HasColumnName("businessCriticality");
            entity.Property(e => e.EndOfSupportWarranty)
                .HasMaxLength(50)
                .HasColumnName("endOfSupportWarranty");
            entity.Property(e => e.Hostname)
                .HasMaxLength(255)
                .HasColumnName("hostname");
            entity.Property(e => e.LastVerified)
                .HasMaxLength(50)
                .HasColumnName("lastVerified");
            entity.Property(e => e.Location)
                .HasMaxLength(255)
                .HasColumnName("location");
            entity.Property(e => e.MakeAndModel)
                .HasMaxLength(255)
                .HasColumnName("makeAndModel");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.OperatingSystem)
                .HasMaxLength(255)
                .HasColumnName("operatingSystem");
            entity.Property(e => e.SerialNum)
                .HasMaxLength(255)
                .HasColumnName("serialNum");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
        });

        modelBuilder.Entity<AssetStatus>(entity =>
        {
            entity.HasKey(e => e.StatusId).HasName("PK__AssetSta__3683B531B62ACD83");

            entity.ToTable("AssetStatus");

            entity.HasIndex(e => e.StatusName, "UQ__AssetSta__501B3753CF129B4E").IsUnique();

            entity.Property(e => e.StatusId).HasColumnName("status_id");
            entity.Property(e => e.StatusName)
                .HasMaxLength(50)
                .HasColumnName("status_name");
        });

        modelBuilder.Entity<AssetType>(entity =>
        {
            entity.HasKey(e => e.AssetTypeId).HasName("PK__AssetTyp__95A1E2BC15838755");

            entity.HasIndex(e => e.AssetTypeName, "UQ__AssetTyp__9647F89F7FCF8C27").IsUnique();

            entity.Property(e => e.AssetTypeId).HasColumnName("asset_type_id");
            entity.Property(e => e.AssetTypeName)
                .HasMaxLength(100)
                .HasColumnName("asset_type_name");
        });

        modelBuilder.Entity<BusinessCriticality>(entity =>
        {
            entity.HasKey(e => e.CriticalityId).HasName("PK__Business__5A311E3337B1E02B");

            entity.ToTable("BusinessCriticality");

            entity.HasIndex(e => e.CriticalityName, "UQ__Business__0B93137BA0988C27").IsUnique();

            entity.Property(e => e.CriticalityId).HasColumnName("criticality_id");
            entity.Property(e => e.CriticalityName)
                .HasMaxLength(50)
                .HasColumnName("criticality_name");
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.HasKey(e => e.LocationId).HasName("PK__Location__771831EA9F72C310");

            entity.HasIndex(e => e.LocationName, "UQ__Location__F809DCA033E7BACC").IsUnique();

            entity.Property(e => e.LocationId).HasColumnName("location_id");
            entity.Property(e => e.LocationName)
                .HasMaxLength(200)
                .HasColumnName("location_name");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__B9BE370F96CA7384");

            entity.HasIndex(e => e.LastName, "UQ__Users__A79AD91F81EEED5B").IsUnique();

            entity.HasIndex(e => e.Email, "UQ__Users__AB6E6164BC5A1A43").IsUnique();

            entity.HasIndex(e => e.Username, "UQ__Users__F3DBC57254816A66").IsUnique();

            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(sysdatetime())", "DF__Users__created_a__4E88ABD4")
                .HasColumnName("created_at");
            entity.Property(e => e.Department)
                .HasMaxLength(200)
                .HasColumnName("department");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(25)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(25)
                .HasColumnName("last_name");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .HasColumnName("username");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
