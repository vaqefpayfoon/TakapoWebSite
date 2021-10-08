using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TakapoWebSite.Helper
{
    public class Utility
    {
        private static HttpContextAccessor _httpContextAccessor;
        public Utility(HttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public static string GetLang()
        {
            return _httpContextAccessor.HttpContext.Request.Cookies["lang"];
        }
    }
}
