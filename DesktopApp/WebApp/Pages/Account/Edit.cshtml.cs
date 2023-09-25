using Classes;
using DAL;
using LL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages.Account
{
    public class EditModel : PageModel
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ILogger<IndexModel> _logger;
        private readonly UserManager _userManager = new UserManager(new UserDAO());

        [BindProperty]
        public User User { get; set; }

        [BindProperty]
        public string Date { get; set; }

        public EditModel(ILogger<IndexModel> logger, IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;

        }

        private bool IsUserLoggedIn()
        {
            if (HttpContext.Session.GetString("Email") != null || Request.Cookies["Email"] != null)
            {
                int id = 0;
                string email;

                if (HttpContext.Session.GetString("Email") != null)
                {
                    email = HttpContext.Session.GetString("Email");
                    _logger.LogInformation("Session EmployeeId: " + email);
                    id = _userManager.GetIdOfEmployeeByEmail(email);
                }
                else if (Request.Cookies["Email"] != null)
                {
                    email = Request.Cookies["Email"];
                    _logger.LogInformation("Cookie Email: " + email);
                    id = _userManager.GetIdOfEmployeeByEmail(email);
                }

                User = _userManager.GetUserByID(id);
                return true;
            }
            else
            {
                return false;
            }
        }

        public IActionResult OnGet()
        {
            if (IsUserLoggedIn())
            {
                if (HttpContext.Session.GetString("Email") != null)
                {
                    ViewData["User"] = HttpContext.Session.GetString("Email");
                }
                else if (Request.Cookies["Email"] != null)
                {
                    ViewData["User"] = Request.Cookies["Email"];
                }
                return Page();
            } 
            else
            {
                return RedirectToPage("Login");
            }
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                User.DateOfBirth = DateOnly.FromDateTime(Convert.ToDateTime(Date));
                _userManager.UpdateUser(User, User.Address);
                return RedirectToPage("/Account");
            }
            else
            {
                return Page();
            }
        }

    }
}
