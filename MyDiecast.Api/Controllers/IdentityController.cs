using Microsoft.AspNetCore.Mvc;
using MyDiecast.Api.Data.Entities;
using MyDiecast.Api.Managers;
using MyDiecast.Api.Models;

namespace MyDiecast.Api.Controllers {
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
    [Route("is-authenticated")]
    public IActionResult IsAuthenticated() {
      if (User.Identity != null && User.Identity.IsAuthenticated) { return Ok(); }
      return BadRequest();
    }

    [HttpPost]
    [Route("sign-in")]
    public async Task<IActionResult> SignInAsync([FromBody] SignInDto model) {
      AspUser? user = await userManager.FindByNameAsync(model.UserName);
      if (user == null) { return BadRequest(); }

      bool canSignIn = await signInManager.CanSignInAsync(user);
      if (!canSignIn) { return BadRequest(); }

      await signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);
      return Ok();
    }

    [HttpPost]
    [Route("sign-out")]
    public async Task<IActionResult> SignOutAsync() {
      await signInManager.SignOutAsync();
      return Ok();
    }

    [HttpGet]
    [Route("current-user")]
    public async Task<IActionResult> GetCurrentUserAsync() {
      if (User.Identity != null && User.Identity.IsAuthenticated) {
        AspUser user = await userManager.FindByIdAsync(userManager.GetUserId(User));
        return Ok(user);
      }
      return BadRequest();
    }
  }
}
