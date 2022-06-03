using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitOfA.Helper.MVVM
{
    public interface IViewModel
    {
        Task OnAppeared();
        Task OnAppearing();
        Task OnDisappearing();
        Task OnDispeared();
    }
}
