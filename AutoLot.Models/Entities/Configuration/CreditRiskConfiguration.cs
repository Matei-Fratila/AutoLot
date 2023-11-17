﻿
namespace AutoLot.Models.Entities.Configuration;
public class CreditRiskConfiguration : IEntityTypeConfiguration<CreditRisk>
{
    public void Configure(EntityTypeBuilder<CreditRisk> builder)
    {
        builder.HasOne(d => d.CustomerNavigation)
            .WithMany(p => p.CreditRisks)
            .HasForeignKey(d => d.CustomerId)
            .HasConstraintName("FK_CreditRisks_Customers");
        
        builder.OwnsOne(o => o.PersonInformation,
            pd =>
            {
                pd.Property<string>(nameof(Person.FirstName))
                    .HasColumnName(nameof(Person.FirstName))
                    .HasColumnType("nvarchar(50)");
                pd.Property<string>(nameof(Person.LastName))
                    .HasColumnName(nameof(Person.LastName))
                    .HasColumnType("nvarchar(50)");
                pd.Property(p => p.FullName)
                    .HasColumnName(nameof(Person.FullName))
                    .HasComputedColumnSql("[LastName] + ', ' + [FirstName]");
            });

        builder.Navigation(d => d.PersonInformation).IsRequired(true);
    }
}
