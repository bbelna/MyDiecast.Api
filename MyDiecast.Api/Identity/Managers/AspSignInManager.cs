using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using MyDiecast.Api.Identity.Entities;

namespace MyDiecast.Api.Identity.Managers {
  public class AspSignInManager : SignInManager<AspUser> {
    public AspSignInManager(
      UserManager<AspUser> userManager,
      IHttpContextAccessor contextAccessor,
      IUserClaimsPrincipalFactory<AspUser> claimsFactory,
      IOptions<IdentityOptions> optionsAccessor,
      ILogger<SignInManager<AspUser>> logger,
      IAuthenticationSchemeProvider schemes,
      IUserConfirmation<AspUser> confirmation
    ) : base(
      userManager, contextAccessor, claimsFactory, optionsAccessor, logger, schemes, confirmation
    ) { }
  }
}
