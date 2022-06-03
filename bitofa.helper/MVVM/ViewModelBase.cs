using System.Threading.Tasks;

namespace BitOfA.Helper.MVVM
{
    public abstract class ViewModelBase : IViewModel
    {
        public virtual Task OnAppearing() { 
        return Task.CompletedTask;
        }
        public virtual Task OnDisappearing()
        {
            return Task.CompletedTask;
        }
        public virtual Task OnAppeared()
        {
            return Task.CompletedTask;
        }
        public virtual Task OnDispeared()
        {
            return Task.CompletedTask;
        }
    }
}
