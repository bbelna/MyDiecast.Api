namespace MyDiecast.Api.Models {
  public class SignInDto {
    public string UserName { get; set; }
    public string Password { get; set; }
    public bool RememberMe { get; set; }
  }
}
