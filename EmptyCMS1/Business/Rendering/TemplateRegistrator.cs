using EmptyCMS1.Models.Blocks;
using EmptyCMS1.Models.Pages;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;

namespace EmptyCMS1.Business.Rendering
{
    [ServiceConfiguration]
    public class TemplateRegistrator: IViewTemplateModelRegistrator
    {
        public void Register(TemplateModelCollection viewTemplateModelRegistrator)
        {
            viewTemplateModelRegistrator.Add(typeof(TagBlock), new TemplateModel
            {
                Name = "TagBlock-Default",
                AvailableWithoutTag = true,
                TemplateTypeCategory = EPiServer.Framework.Web.TemplateTypeCategories.MvcPartialView,
                Path = "~/Views/TagBlock/Index.cshtml"
            });

            viewTemplateModelRegistrator.Add(typeof(AbstractPage), new TemplateModel
            {
                Name = "AbstractPage-Default",
                AvailableWithoutTag = false,
                Tags = new[] { "TagContent" },
                Inherit = true,
                TemplateTypeCategory = EPiServer.Framework.Web.TemplateTypeCategories.MvcPartialView,
                Path = "~/Views/AbstractPage/TagContent.cshtml"
            });
        }
    }
}
