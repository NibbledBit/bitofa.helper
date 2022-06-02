namespace BitOfA.Helper.DDD;

public interface INotifySubscriber<T> where T : INotification
{

    public void Invoke(T notification);
}
