using EmptyCMS1.Models.Pages;

namespace EmptyCMS1.Models.ViewModels
{
    public class FormPageViewModel : AbstractPageViewModel<FormPage>
    {
        public ContentArea? FormArea { get; set; }

        public FormPageViewModel(FormPage page) : base(page)
        {
            FormArea = page.FormArea;
        }
    }
}
