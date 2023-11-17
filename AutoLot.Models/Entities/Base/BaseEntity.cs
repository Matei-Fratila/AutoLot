namespace AutoLot.Models.Entities.Base;
public class BaseEntity
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Timestamp]
    public byte[] TimeStamp { get; set; }
}
