using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LL.User_related;
using DAL;
using Classes;

namespace WebApp.Pages
{
    public class LoginModel : PageModel
    {
        private readonly LoginManager _loginManager = new LoginManager(new UserDAO());
        private readonly IHttpContextAccessor _httpContextAccessor;

        public LoginModel(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            User user = _loginManager.Login(Request.Form["email"], Request.Form["password"]);
            if (user!= null && user.UserType==UserType.Employee)
            {
                _httpContextAccessor.HttpContext.Session.SetString("Email", Request.Form["email"]);
                ViewData["User"] = HttpContext.Session.GetString("Email");
                
                if (Request.Form["rememberMe"] == "on")
                {
                    _httpContextAccessor.HttpContext.Response.Cookies.Append("Email", Request.Form["email"], new CookieOptions
                    {
                        Expires = DateTime.UtcNow.AddYears(100),
                        IsEssential = true,
                        HttpOnly = true,
                        SameSite = SameSiteMode.None,
                        Secure = true
                    });
                }
                
                return RedirectToPage("Index");
            } 
            else
            {
                if (user == null)
                {
                    TempData["Message1"] = "Please insert corect email and password!";
                    
                }
                else if (user.UserType != UserType.Employee)
                {
                    TempData["Message1"] = "Only employees can log in!";
                }
                    return Page();
            }
        }
    }
}
