namespace MyDiecast.Api.Data.Entities {
  public class DiecastMake : AuditIdEntity<Guid> {
    public string Name { get; set; }
  }
}
