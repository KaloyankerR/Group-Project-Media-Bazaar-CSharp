using System.Linq;
using DAL;
using LL;
using Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;
using System.ComponentModel.DataAnnotations;


namespace WebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ILogger<IndexModel> _logger;
        private readonly ShiftManager shiftManager = new ShiftManager(new ShiftDAO());
        private readonly IUserManager userManager = new UserManager(new UserDAO());
        public Dictionary<DateOnly, Dictionary<ShiftType, bool>> Shifts { get; set; } = new Dictionary<DateOnly, Dictionary<ShiftType, bool>>();
        
        
        public IndexModel(ILogger<IndexModel> logger, IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;

        }

        private bool IsUserLoggedIn()
        {
            if (HttpContext.Session.GetString("Email") != null || Request.Cookies["Email"] != null)
            {
                if (HttpContext.Session.GetString("EmployeeId") != null)
                {
                    _logger.LogInformation("Session EmployeeId: " + HttpContext.Session.GetString("EmployeeId"));
                }
                if (Request.Cookies["EmployeeId"] != null)
                {
                    _logger.LogInformation("Cookie EmployeeId: " + Request.Cookies["EmployeeId"]);

                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public IActionResult OnGet(User user)
        {
            if (HttpContext.Session.GetString("Email") != null)
            {
                ViewData["User"] = HttpContext.Session.GetString("Email");
            }
            else if (Request.Cookies["Email"] != null)
            {
                ViewData["User"] = Request.Cookies["Email"];
            }

            if (IsUserLoggedIn())
            {
                //Take the email from the cookie, and using that email, receive the userId.
                string NameSession = _httpContextAccessor.HttpContext.Session.GetString("Email");
                user.UserID = userManager.GetIdOfEmployeeByEmail(NameSession);
                var employee = user.UserID;

                // Get the start of the current week
                
                var startOfWeek = DateTime.Now;

                // Populate the dictionary with shift data
                for (int i = 0; i < 7; i++)
                {
                    var date = startOfWeek.AddDays(i);
                    Shifts[DateOnly.FromDateTime(date)] = new Dictionary<ShiftType, bool>();

                    for (int j = 0; j < 3; j++)
                    {
                        var type = (ShiftType)j;
                        
                        var isWorking = shiftManager.CheckEmployeeOnShift(DateOnly.FromDateTime(date), (int)type, employee);
                        if (isWorking)
                        {
                            Shifts[DateOnly.FromDateTime(date)][type] = false;
                            
                        }
                        else
                        {
                            Shifts[DateOnly.FromDateTime(date)][type] = true;
                        }
                        
                    }
                }
                //TempData.Remove("User");
                return Page();

               
            } 
            else
            {
                return RedirectToPage("Login");
            }
        }

        

    }
}