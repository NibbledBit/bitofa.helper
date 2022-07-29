namespace BitOfA.Helper.MVVM;

public interface IView<T> where T : IViewModel {
    IViewModel ViewModel { get; }
}
