using System.ComponentModel.DataAnnotations;

namespace EmptyCMS1.Models.Pages
{
    public abstract class AbstractPage : PageData
    {
        [Display(
            Name = "Page Title",
            GroupName = "SEO",
            Order = 10)]
        public virtual string? PageTitle { get; set; }        
    }
}
