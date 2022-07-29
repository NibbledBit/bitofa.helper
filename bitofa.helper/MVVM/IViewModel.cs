using System.Threading.Tasks;

namespace BitOfA.Helper.MVVM {
    public interface IViewModel {
        Task OnAppeared();
        Task OnAppearing();
        Task OnDisappearing();
        Task OnDispeared();
    }
}
