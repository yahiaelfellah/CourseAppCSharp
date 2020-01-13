using Microsoft.AspNetCore.Mvc;

namespace CourseProjectApp.ViewComponents
{
    public class LoginViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
