namespace AutoLot.Models.Entities;

[Table("Inventory", Schema = "dbo")]
[Index("MakeId", Name = "IX_Inventory_MakeId")]
[EntityTypeConfiguration(typeof(CarConfiguration))]
public partial class Car : BaseEntity
{
    [Required]
    [DisplayName("Make")]
    public int MakeId { get; set; }

    private bool? _isDrivable;
    [DisplayName("Is Drivable")]
    public bool IsDrivable
    {
        get => _isDrivable ?? true;
        set => _isDrivable = value;
    }

    [Required]
    [StringLength(50)]
    public string Color { get; set; }

    [Required]
    [StringLength(50)]
    [DisplayName("Pet Name")]
    public string PetName { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public string Display { get; set; }

    public string Price { get; set; }

    public DateTime? DateBuilt { get; set; }

    [ForeignKey(nameof(MakeId))]
    [InverseProperty(nameof(Make.Cars))]
    public virtual Make MakeNavigation { get; set; }

    [InverseProperty(nameof(Radio.CarNavigation))]
    public virtual Radio RadioNavigation { get; set; }

    [InverseProperty(nameof(Order.CarNavigation))]
    public virtual IEnumerable<Order> Orders { get; set; } = new List<Order>();

    [InverseProperty(nameof(Driver.Cars))]
    public virtual IEnumerable<Driver> Drivers { get; set; } = new List<Driver>();

    [InverseProperty(nameof(CarDriver.CarNavigation))]
    public virtual IEnumerable<CarDriver> CarDrivers { get; set; } = new List<CarDriver>();

    [NotMapped]
    public string MakeName => MakeNavigation?.Name ?? "Unknown";

    public override string ToString()
    {
        return $"{PetName ?? "**No Name**"} is a {Color} {MakeNavigation?.Name} with ID {Id}.";
    }
}
