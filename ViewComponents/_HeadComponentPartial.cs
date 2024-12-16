using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.NewComponents
{
    public class _HeadComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
