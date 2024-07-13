namespace FloatAB.Core.Models
{
  public class TicketEntity : ITicket
  {
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; } = string.Empty;
    public Priority Priority { get; set; } = Priority.Low;
    public ColumnEntity ColumnEntity { get; set; }
  }
}

