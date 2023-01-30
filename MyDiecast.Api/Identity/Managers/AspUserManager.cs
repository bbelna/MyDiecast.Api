using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using MyDiecast.Api.Identity.Entities;

namespace MyDiecast.Api.Identity.Managers {
  public class AspUserManager : UserManager<AspUser> {
    public AspUserManager(
      IUserStore<AspUser> store,
      IOptions<IdentityOptions> optionsAccessor,
      IPasswordHasher<AspUser> passwordHasher,
      IEnumerable<IUserValidator<AspUser>> userValidators,
      IEnumerable<IPasswordValidator<AspUser>> passwordValidators,
      ILookupNormalizer keyNormalizer, IdentityErrorDescriber errors,
      IServiceProvider services,
      ILogger<UserManager<AspUser>> logger
    ) : base(
      store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger
    ) { }
  }
}
