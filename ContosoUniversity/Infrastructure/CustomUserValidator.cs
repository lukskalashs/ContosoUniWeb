using Microsoft.AspNetCore.Identity;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ContosoUniversity.Infrastructure
{
    public class CustomUserValidator : IUserValidator<IdentityUser>
    {
        public Task<IdentityResult> ValidateAsync(UserManager<IdentityUser> manager,
            IdentityUser user)
        {
            List<IdentityError> errors = new();

            if (!user.Email.ToLower().EndsWith("@contoso.com"))
            {
                errors.Add(new IdentityError
                {
                    Code = "EmailDomainError",
                    Description = "Only contoso.com email addresses are allowed"
                });
            }

            

            return Task.FromResult(errors.Count == 0 ?
              IdentityResult.Success : IdentityResult.Failed(errors.ToArray()));
        }
    }
}
