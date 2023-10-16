using EmptyCMS1.Models.Pages;
using EmptyCMS1.Models.ViewModels;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace EmptyCMS1.Controllers.Pages
{
    public class AboutPageController : PageController<AboutPage>
    {
        public IActionResult Index(AboutPage currentContent)
        {
            var viewModel = new AboutPageViewModel(currentContent);

            return View(viewModel);
        }
    }
}
