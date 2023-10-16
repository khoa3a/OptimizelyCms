using EmptyCMS1.Models.Pages;
using EmptyCMS1.Models.ViewModels;
using EPiServer.Framework.Localization;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace EmptyCMS1.Controllers.Pages
{
    public class HomePageController : PageController<HomePage>
    {
        public IActionResult Index(HomePage currentContent)
        {
            var viewModel = new HomePageViewModel(currentContent);

            return View(viewModel);
        }
    }
}
