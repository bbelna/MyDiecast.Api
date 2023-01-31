namespace MyDiecast.Api.Data.Entities {
  public class Diecast : AuditIdEntity<Guid> {
    public DiecastMake Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
  }
}
