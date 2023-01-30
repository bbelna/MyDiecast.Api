using MyDiecast.Api.Data;

namespace MyDiecast.Api.Diecast.Entities {
  public class DiecastMake : AuditIdEntity<Guid> {
    public string Name { get; set; }
  }
}
