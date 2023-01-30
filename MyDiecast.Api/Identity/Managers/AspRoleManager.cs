using Microsoft.AspNetCore.Identity;
using MyDiecast.Api.Identity.Entities;

namespace MyDiecast.Api.Identity.Managers {
  public class AspRoleManager : RoleManager<AspRole> {
    public AspRoleManager(
      IRoleStore<AspRole> store,
      IEnumerable<IRoleValidator<AspRole>> roleValidators,
      ILookupNormalizer keyNormalizer,
      IdentityErrorDescriber errors,
      ILogger<RoleManager<AspRole>> logger
    ) : base(store, roleValidators, keyNormalizer, errors, logger) { }
  }
}
