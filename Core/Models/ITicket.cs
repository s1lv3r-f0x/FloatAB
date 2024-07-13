namespace FloatAB.Core.Models
{
  public interface ITicket
  {
    Guid Id { get; set; }
    string Title { get; set; }
    string? Description {get; set;}
    Priority Priority { get; set; }
  }
}