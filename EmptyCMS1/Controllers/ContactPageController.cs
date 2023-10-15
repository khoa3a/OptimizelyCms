using EmptyCMS1.Models.Pages;
using EmptyCMS1.Models.ViewModels;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace EmptyCMS1.Controllers
{
    public class ContactPageController : PageController<ContactPage>
    {
        public IActionResult Index(ContactPage currentContent)
        {
            var viewModel = new ContactPageViewModel(currentContent);

            return View(viewModel);
        }
    }
}
