using EmptyCMS1.Models.Pages;
using EmptyCMS1.Models.ViewModels;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace EmptyCMS1.Controllers.Pages
{
    public class FormPageController :PageController<FormPage>
    {
        public IActionResult Index(FormPage currentContent)
        {
            var viewModel = new FormPageViewModel(currentContent);

            return View(viewModel);
        }
    }
}
