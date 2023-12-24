using Microsoft.AspNetCore.Mvc;

namespace StajProje.Components
{
    public class RickFilterMenu : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
