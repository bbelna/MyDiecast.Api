using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyDiecast.Api.Identity.Managers;
using MyDiecast.Api.Identity.Models;

namespace MyDiecast.Api.Identity.Controllers {
  [Route("api/[controller]")]
  [ApiController]
  public class IdentityController : ControllerBase {
    protected AspSignInManager signInManager { get; set; }
    protected AspRoleManager roleManager { get; set; }
    protected AspUserManager userManager { get; set; }

    public IdentityController(
      AspSignInManager _signInManager,
      AspRoleManager _roleManager,
      AspUserManager _userManager
    ) {
      signInManager = _signInManager;
      roleManager = _roleManager;
      userManager = _userManager;
    }

    [HttpPost]
    [Route("sign-in")]
    public IActionResult SignIn([FromBody] SignInRequestModel model) {
      // todo
      return Ok();
    }
  }
}
