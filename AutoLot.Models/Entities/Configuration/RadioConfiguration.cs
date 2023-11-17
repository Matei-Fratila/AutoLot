namespace AutoLot.Models.Entities.Configuration;
public class RadioConfiguration : IEntityTypeConfiguration<Radio>
{
    public void Configure(EntityTypeBuilder<Radio> builder)
    {
        builder.HasQueryFilter(r => r.CarNavigation.IsDrivable);
        builder.HasIndex(e => e.CarId, "IX_Radios_CarId")
            .IsUnique();

        builder.HasOne(d => d.CarNavigation)
            .WithOne(p => p.RadioNavigation)
            .HasForeignKey<Radio>(d => d.CarId);

        builder.ToTable(b => b.IsTemporal(t =>
        {
            t.HasPeriodEnd("ValidTo");
            t.HasPeriodStart("ValidFrom");
            t.UseHistoryTable("RadiosAudit");
        }));
    }
}
