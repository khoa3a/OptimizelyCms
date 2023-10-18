using System.ComponentModel.DataAnnotations;

namespace EmptyCMS1.Models.Pages
{
    [ContentType(
        DisplayName = "Form Page",
        GroupName = SystemTabNames.Content,
        GUID = "8c2c8932-c08e-4081-85a7-54a6b9718058"
    )]
    public class FormPage : AbstractPage
    {
        [Display(
            Name = "Form Area",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual ContentArea? FormArea { get; set; }
    }
}
