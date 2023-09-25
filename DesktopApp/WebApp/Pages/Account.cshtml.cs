using Classes;
using DAL;
using LL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{
    public class AccountModel : PageModel
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ILogger<IndexModel> _logger;
        private readonly UserManager _userManager = new UserManager(new UserDAO());

        [BindProperty]
        public User user { get; set; }

        public AccountModel(ILogger<IndexModel> logger, IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;

        }

        public IActionResult OnGet()
        {
            string email = null;
            if (HttpContext.Session.GetString("Email") != null)
            {
                email = HttpContext.Session.GetString("Email");
                ViewData["User"] = HttpContext.Session.GetString("Email");
            }
            else if (Request.Cookies["Email"] != null)
            {
                email = Request.Cookies["Email"];
                ViewData["User"] = Request.Cookies["Email"];
            }

            int id = _userManager.GetIdOfEmployeeByEmail(email);

            user = _userManager.GetUserByID(id);

            if (user == null)
            {
                return RedirectToPage("/Login");
            }
            else
                return Page();

        }
    }
}
