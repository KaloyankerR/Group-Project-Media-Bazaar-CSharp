using Classes;
using DAL;
using LL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Globalization;
using System.Reflection;
using System.Text;

namespace WebApp.Pages
{
    public class PreferedScheduleModel : PageModel
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ILogger<IndexModel> _logger;
        private readonly ShiftManager shiftManager = new ShiftManager(new ShiftDAO());
        private readonly IUserManager userManager = new UserManager(new UserDAO());
        public Dictionary<DateOnly, Dictionary<ShiftType, bool>> Shifts { get; set; } = new Dictionary<DateOnly, Dictionary<ShiftType, bool>>();
        public string[] DaysOfWeek { get; } = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        public string[] ShiftType { get; } = { "Morning", "Afternoon", "Evening" };
        public int SelectedWeek { get; set; }
        public DateTime SelectedDate { get; set; }
        private readonly CalendarWeekRule calendarWeekRule = CalendarWeekRule.FirstFourDayWeek;
        private readonly DayOfWeek firstDayOfWeek = DayOfWeek.Monday;
        [BindProperty]
        public int CurentWeek { get; set; } 

        [BindProperty]
        public List<int?> Values { get; set; } = new List<int?>();
        [BindProperty]
        public List<int?> Values1 { get; set; } = new List<int?>();
        public PreferedScheduleModel(ILogger<IndexModel> logger, IHttpContextAccessor httpContextAccessor)
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
                var selectedWeekValue = _httpContextAccessor.HttpContext.Session.GetInt32("SelectedWeek");
                if (selectedWeekValue.HasValue)
                {
                    SelectedWeek = selectedWeekValue.Value;
                }
                else
                {
                    SelectedWeek = GetWeekOfYear(DateTime.Now);
                    _httpContextAccessor.HttpContext.Session.SetInt32("SelectedWeek", SelectedWeek);
                }
                CurentWeek = GetWeekOfYear(DateTime.Now);
                SelectedDate = GetFirstDayOfWeekByWeekNumber(DateTime.Now.Year, SelectedWeek);
               
                foreach (var day in DaysOfWeek)
                {
                    int ?values1 = shiftManager.GetPreferedScheduleForUser(user.UserID, day, SelectedDate.Date);
                    Values.Add(values1);
                    Values1.Add(values1);
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
            User user = new User();
            string NameSession = _httpContextAccessor.HttpContext.Session.GetString("Email");
            user.UserID = userManager.GetIdOfEmployeeByEmail(NameSession);
            var selectedWeekValue = _httpContextAccessor.HttpContext.Session.GetInt32("SelectedWeek");
            if (selectedWeekValue.HasValue)
            {
                int inde = 1;
                var firstDayOfWeek = GetFirstDayOfWeekByWeekNumber(DateTime.Now.Year, selectedWeekValue.Value);
                for (int i = 0; i < DaysOfWeek.Length; i++)
                {
                    var day = DaysOfWeek[i];
                    string selectedShift = Request.Form["shift_" + day];
                    
                    if (selectedShift == null)
                    {
                        inde++;
                        bool set = shiftManager.SetPreferedScheduleForUser(user.UserID, day,-1, firstDayOfWeek);
                        if (set)
                        {
                            TempData["Message"] = "Complete!";
                        }
                        else
                        {
                            TempData["Message"] = "Error!";
                        }
                    }
                    else 
                    {
                        bool set = shiftManager.SetPreferedScheduleForUser(user.UserID, day, Convert.ToInt32(selectedShift), firstDayOfWeek);
                        if (set)
                        {
                            TempData["Message"] = "Complete!";
                        }
                        else
                        {
                            TempData["Message"] = "Error!";
                        }
                    }
                    if(inde ==8)
                    {
                        bool set = shiftManager.DeletePreferedScheduleForUser(user.UserID, firstDayOfWeek);
                        if (set)
                        {
                            TempData["Message"] = "Schedule Delete for selected perioad!";
                        }
                        else
                        {
                            TempData["Message"] = "Error!";
                        }
                    }
                }
            }
            

            return RedirectToPage();
        }
        public IActionResult OnPostNextWeek()
        {
            var selectedWeekValue = _httpContextAccessor.HttpContext.Session.GetInt32("SelectedWeek");
            if (selectedWeekValue.HasValue)
            {
                int selectedWeek = selectedWeekValue.Value;
                selectedWeek++;
                SelectedWeek = selectedWeek;
                SelectedDate = GetFirstDayOfWeekByWeekNumber(DateTime.Now.Year, selectedWeek);
                _httpContextAccessor.HttpContext.Session.SetInt32("SelectedWeek", selectedWeek);
            }
            return RedirectToPage();
        }
        public IActionResult OnPostCurrentWeek()
        {
            int currentWeek = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            _httpContextAccessor.HttpContext.Session.SetInt32("SelectedWeek", currentWeek);
            return RedirectToPage();
        }

        public IActionResult OnPostPreviousWeek()
        {
            var selectedWeekValue = _httpContextAccessor.HttpContext.Session.GetInt32("SelectedWeek");
            if (selectedWeekValue.HasValue)
            {
                int selectedWeek = selectedWeekValue.Value;
                selectedWeek--;
                if (selectedWeek <= 0)
                {
                    selectedWeek = GetWeekOfYear(GetFirstDayOfWeekByWeekNumber(DateTime.Now.Year, 1).AddDays(-7));
                }
                SelectedWeek = selectedWeek;
                SelectedDate = GetFirstDayOfWeekByWeekNumber(DateTime.Now.Year, selectedWeek);
                _httpContextAccessor.HttpContext.Session.SetInt32("SelectedWeek", selectedWeek);
            }
            return RedirectToPage();
        }
        private int GetWeekOfYear(DateTime date)
        {
            var calendar = CultureInfo.CurrentCulture.Calendar;
            var weekNumber = calendar.GetWeekOfYear(date, calendarWeekRule, firstDayOfWeek);
            if (weekNumber <= 0)
            {
                var year = date.Year - 1;
                weekNumber = calendar.GetWeekOfYear(date, calendarWeekRule, firstDayOfWeek);
            }
            return weekNumber;
        }

        private DateTime GetFirstDayOfWeekByWeekNumber(int year, int weekNumber)
        {
            var jan1 = new DateTime(year, 1, 1);
            var daysOffset = (int)firstDayOfWeek - (int)jan1.DayOfWeek;
            var firstWeekDay = jan1.AddDays(daysOffset);
            var curCulture = CultureInfo.CurrentCulture;
            var firstWeek = curCulture.Calendar.GetWeekOfYear(jan1, calendarWeekRule, firstDayOfWeek);
            if (firstWeek <= 1)
            {
                weekNumber -= 1;
            }
            return firstWeekDay.AddDays(weekNumber * 7 - 7);
        }

    }
}