using EmptyCMS1.Models.Pages;
using EmptyCMS1.Models.ViewModels;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace EmptyCMS1.Controllers.Pages
{
    public class TagPageController : PageController<TagPage>
    {
        public IActionResult Index(TagPage currentContent)
        {
            var viewModel = new TagPageViewModel(currentContent);

            return View(viewModel);
        }
    }
}
