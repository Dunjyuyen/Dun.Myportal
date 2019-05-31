using Microsoft.AspNetCore.Antiforgery;
using Dun.Myportal.Controllers;

namespace Dun.Myportal.Web.Host.Controllers
{
    public class AntiForgeryController : MyportalControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
