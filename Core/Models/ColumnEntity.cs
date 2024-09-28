namespace FloatAB.Core.Models
{
  public class ColumnEntity : IColumn
  {
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<TicketEntity> Tickets { get; set; }
  }
}