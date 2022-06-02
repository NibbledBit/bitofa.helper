namespace BitOfA.Helper.DDD;

public interface INotifyDispatcher
{
    void Subscribe<S>()
        where S : INotifySubscriber<INotification>, new();
    void Dispatch(INotification domainEvent);
}
