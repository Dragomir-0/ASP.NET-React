using System.Security.Claims;
using Application.Interfaces;
using Microsoft.AspNetCore.Http;

namespace Infrastructure.Security
{
    public class UserAccessor : IUserAccessor
    {
        private readonly IHttpContextAccessor HttpContextAccessor;
        public UserAccessor(IHttpContextAccessor HttpContextAccessor)
        {
            this.HttpContextAccessor = HttpContextAccessor;

        }
        public string GetUsername()
        {
            return HttpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Name);
        }
    }
}