using EmptyCMS1.Models.Pages;
using System.ComponentModel.DataAnnotations;

namespace EmptyCMS1.Models.Blocks
{
    [ContentType(
        DisplayName = "Tag Block",
        GUID = "cce54b35-209a-4e23-8688-0ca19d8c7856")]
    public class TagBlock : BlockData
    {
        [Display(
            Name = "Tag Area",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        [AllowedTypes(AllowedTypes = new[] { typeof(AbstractPage) })]
        public virtual ContentArea? TagArea { get; set; }
    }
}
