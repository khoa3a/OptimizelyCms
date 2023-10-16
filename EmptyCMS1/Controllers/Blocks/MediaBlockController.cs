using EmptyCMS1.Models.Blocks;
using EmptyCMS1.Models.ViewModels;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace EmptyCMS1.Controllers.Blocks
{
    public class MediaBlockController : AsyncBlockComponent<MediaBlock>
    {
        protected override async Task<IViewComponentResult> InvokeComponentAsync(MediaBlock currentContent)
        {
            //TODO: new MediaBlockViewModel
            //TODO: refactor using IViewTemplateModelRegistrator

            return await Task.FromResult(View("~/Views/MediaBlock/Index.cshtml", currentContent));
        }
    }
}
