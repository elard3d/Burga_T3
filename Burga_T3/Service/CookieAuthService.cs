using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
namespace Burga_T3.Service
{
    public interface ICookieAuthService
    {
        void SetHttpContext(HttpContext httpContext);
        public void Login(ClaimsPrincipal claim);
        public Claim ObtenerClaim();
    }


    public class CookieAuthService : ICookieAuthService
    {
        private HttpContext httpContext;

        public void SetHttpContext(HttpContext httpContext)
        {
            this.httpContext = httpContext;
        }

        public void Login(ClaimsPrincipal claim)
        {
            httpContext.SignInAsync(claim);

        }

        public Claim ObtenerClaim()
        {
            var claim = httpContext.User.Claims.FirstOrDefault();
            return claim;
        }
    }
}