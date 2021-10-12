using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TakapoWebSite.Models;

namespace TakapoWebSite.Area.Fa.Controllers
{
    [Area("Fa")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IHttpContextAccessor _httpContextAccessor;
        public HomeController(ILogger<HomeController> logger,
            IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;
            if (Request != null && Request.Cookies["lang"] == null)
            {
                SetCookie("lang", "fa", 1);
            }

        }
        public IActionResult ChangeLanguage(string key, string value)
        {
            SetCookie(key, value, 1);
            string cookieValueFromContext = _httpContextAccessor.HttpContext.Request.Cookies["lang"];
            string cookieValueFromReq = Request.Cookies["lang"];
            return View("Index");
        }
        private void SetCookie(string key, string value, int? expireTime)
        {
            CookieOptions option = new CookieOptions();

            if (expireTime.HasValue)
                option.Expires = DateTime.Now.AddHours(expireTime.Value);
            else
                option.Expires = DateTime.Now.AddHours(1);

            Response.Cookies.Append(key, value, option);
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult OurTeam()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
