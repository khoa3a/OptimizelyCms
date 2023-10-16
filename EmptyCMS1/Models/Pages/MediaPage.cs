using EmptyCMS1.Models.Blocks;
using System.ComponentModel.DataAnnotations;

namespace EmptyCMS1.Models.Pages
{
    [ContentType(
        GUID = "4a51b099-6a82-4a85-9b37-0d23dd564c3a",
        GroupName = "Media Content",
        DisplayName = "Media Page"
    )]
    public class MediaPage : AbstractPage
    {
        [Display(
            Name = "Body",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual XhtmlString? Body { get; set; }

        [Display(
            Name = "Media Area",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        [AllowedTypes(AllowedTypes = new[] { typeof(MediaBlock) })]
        public virtual ContentArea? MediaArea { get; set; }
    }
}
