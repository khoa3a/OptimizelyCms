using EmptyCMS1.Models.Blocks;
using System.ComponentModel.DataAnnotations;

namespace EmptyCMS1.Models.Pages
{
    [ContentType(
        GUID = "af34c9d9-04a2-4de5-a35f-727bc2115dd6",
        GroupName = "Tag Content",
        DisplayName = "Tag Page"
    )]
    public class TagPage : AbstractPage
    {
        [Display(
            Name = "Tag Area",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        [AllowedTypes(AllowedTypes = new[] { typeof(TagBlock) })]
        public virtual ContentArea? TagArea { get; set; }
    }
}
