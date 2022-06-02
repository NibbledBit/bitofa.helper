using System.Collections.Generic;

namespace BitOfA.Helper.DDD;

public interface IDomainModel
{
    List<INotification> DomainEvents { get; }
    int Id { get; }
}
