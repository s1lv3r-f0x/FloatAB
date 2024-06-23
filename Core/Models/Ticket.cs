namespace FloatAB.Core.Models
{
  public class Ticket
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public string? Description { get; set; }
    public Priority Priority { get; set; }
  }
}

