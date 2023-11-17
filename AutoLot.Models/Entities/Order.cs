namespace AutoLot.Models.Entities;

[Table("Orders", Schema = "dbo")]
[Index("CarId", Name = "IX_Orders_CarId")]
[Index("CustomerId", "CarId", Name = "IX_Orders_CustomerId_CarId", IsUnique = true)]
[EntityTypeConfiguration(typeof(OrderConfiguration))]
public partial class Order : BaseEntity
{
    public int CustomerId { get; set; }

    public int CarId { get; set; }

    [ForeignKey("CarId")]
    [InverseProperty(nameof(Car.Orders))]
    public virtual Car CarNavigation { get; set; }

    [ForeignKey("CustomerId")]
    [InverseProperty(nameof(Customer.Orders))]
    public virtual Customer CustomerNavigation { get; set; }
}
