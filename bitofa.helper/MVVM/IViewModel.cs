using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitOfA.Helper.MVVM
{
    public interface IViewModel
    {
        public Task OnAppearing();
        public Task OnAppeared();
        public Task OnDisappearing();
        public Task OnDisappeared();

    }
}
