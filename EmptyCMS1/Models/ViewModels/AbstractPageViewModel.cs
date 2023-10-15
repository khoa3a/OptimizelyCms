using EmptyCMS1.Models.Pages;
using EPiServer.Framework.Localization;
using EPiServer.ServiceLocation;

namespace EmptyCMS1.Models.ViewModels
{
    public abstract class AbstractPageViewModel
    {
        public string? PageTitle { get; set; }
        public string? PageHeader { get; set; }
        public XhtmlString? PageBody { get; set; } 
    }

    public class AbstractPageViewModel<T> : AbstractPageViewModel
    {
        public AbstractPageViewModel(T page)
        {
            Page = page;

            if (page is AbstractPage abstractPage)
            {
                UpdatePageContent(abstractPage.PageTypeName);
            }
        }

        public T Page { get; }

        protected virtual void UpdatePageContent(string pageName)
        {
            var path = $"/contenttypes/page/title";
            var text = ServiceLocator.Current.GetInstance<LocalizationService>().GetString(path);
            PageTitle = text;

            path = $"/contenttypes/{pageName}/properties/header";
            text = ServiceLocator.Current.GetInstance<LocalizationService>().GetString(path);
            PageHeader = text;

            path = $"/contenttypes/{pageName}/properties/body";
            text = ServiceLocator.Current.GetInstance<LocalizationService>().GetString(path);
            PageBody = new XhtmlString(text);
        }
    }
}
