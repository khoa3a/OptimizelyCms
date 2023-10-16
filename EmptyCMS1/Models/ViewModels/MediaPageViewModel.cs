using EmptyCMS1.Models.Pages;

namespace EmptyCMS1.Models.ViewModels
{
    public class MediaPageViewModel : AbstractPageViewModel<MediaPage>
    {
        public XhtmlString? Body { get; set; }
        public ContentArea? MediaArea { get; set; }

        public MediaPageViewModel(MediaPage page) : base(page)
        {
            Body = page.Body;
            MediaArea = page.MediaArea;
        }
    }
}
