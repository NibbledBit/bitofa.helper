using System.Threading.Tasks;

namespace BitOfA.Helper.MVVM
{
    public abstract class ViewModelBase : IViewModel
    {
        public abstract Task OnAppearing();
        public abstract Task OnDisappearing();
        public abstract Task OnAppeared();
        public abstract Task OnDispeared();
    }
}
