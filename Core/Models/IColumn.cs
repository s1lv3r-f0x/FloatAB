namespace FloatAB.Core.Models
{
  public interface IColumn
  {
      Guid Id { get; set; }
      string Name { get; set; }
      List<TicketEntity> Tickets { get; set; }
  }
}