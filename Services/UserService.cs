using System.Net.Http;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace WebAdmin.Services
{


    public class UserService : IUserService
    {

        private readonly IHttpContextAccessor _httpContext;
        

        public UserService(IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;
        }
        public string GetUserId()
        {
            return _httpContext.HttpContext.User?.FindFirstValue(ClaimTypes.NameIdentifier);

        }
        public bool IsAuthenticated()
        {
            return _httpContext.HttpContext.User.Identity.IsAuthenticated;
        }

    }
}
