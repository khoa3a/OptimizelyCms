using EmptyCMS1.Models.Pages;
using EmptyCMS1.Models.ViewModels;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace EmptyCMS1.Controllers.Pages
{
    public class MediaPageController : PageController<MediaPage>
    {
        public IActionResult Index(MediaPage currentContent)
        {
            var viewModel = new MediaPageViewModel(currentContent);

            return View(viewModel);
        }
    }
}
