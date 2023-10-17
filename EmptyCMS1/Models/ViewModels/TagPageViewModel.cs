using EmptyCMS1.Models.Pages;

namespace EmptyCMS1.Models.ViewModels
{
    public class TagPageViewModel : AbstractPageViewModel<TagPage>
    {
        public ContentArea? TagArea { get; set; }

        public TagPageViewModel(TagPage page) : base(page)
        {
            TagArea = page.TagArea;
        }
    }
}
