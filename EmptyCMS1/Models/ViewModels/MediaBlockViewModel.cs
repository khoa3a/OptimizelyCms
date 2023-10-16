using EmptyCMS1.Models.Blocks;

namespace EmptyCMS1.Models.ViewModels
{
    public class MediaBlockViewModel : AbstractBlockViewModel<MediaBlock>
    {
        public string? Description { get; set; }
        public ContentReference? Image { get; set; }

        public MediaBlockViewModel(MediaBlock block) : base(block)
        {
            Description = block.Description;
            Image = block.Image;
        }
    }
}
