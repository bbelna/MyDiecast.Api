namespace MyDiecast.Api.Data {
  public class AuditIdEntity<T> : IdEntity<T> {
    public T LastModifiedBy { get; set; }
    public DateTime LastModifiedOn { get; set; }

    public T CreatedBy { get; set; }
    public DateTime CreatedOn { get; set; }
  }
}
