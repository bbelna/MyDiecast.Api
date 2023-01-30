using MyDiecast.Api.Data;

namespace MyDiecast.Api.Diecast.Entities {
  public class Diecast : AuditIdEntity<Guid> {
    public DiecastMake Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
  }
}
