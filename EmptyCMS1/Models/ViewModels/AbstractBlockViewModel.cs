using EmptyCMS1.Models.Pages;
using EPiServer.Framework.Localization;

namespace EmptyCMS1.Models.ViewModels
{
    public abstract class AbstractBlockViewModel
    {
    }

    public class AbstractBlockViewModel<T> : AbstractBlockViewModel
    {
        public AbstractBlockViewModel(T block)
        {
            Block = block;
        }

        public T Block { get; }
    }
}
