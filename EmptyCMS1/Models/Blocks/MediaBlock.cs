using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace EmptyCMS1.Models.Blocks
{
    [ContentType(
        DisplayName = "Media Block",
        GUID = "548f539d-59b8-4281-bfee-59511002a2d7"
    )]
    public class MediaBlock : BlockData
    {
        [Display(
            Name = "Media Description",
            GroupName = SystemTabNames.Content,
            Order = 10
        )]
        public virtual string? Description { get; set; }

        [Display(
            Name = "Image",
            GroupName = SystemTabNames.Content,
            Order = 20
        )]
        [UIHint(UIHint.Image)]
        public virtual ContentReference? Image { get; set; }
    }
}
