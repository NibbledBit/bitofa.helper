using System.Collections.Generic;

namespace BitOfA.Helper.DDD {
    public abstract class DomainBase : IDomainModel {

        public DomainBase() {
            _domainEvents = new List<INotification>();
        }

        private List<INotification> _domainEvents;
        public List<INotification> DomainEvents => _domainEvents;

        public void AddDomainEvent(INotification eventItem) {
            _domainEvents.Add(eventItem);
        }

        public void RemoveDomainEvent(INotification eventItem) {
            _domainEvents?.Remove(eventItem);
        }

        public virtual int Id { get; protected set; }
    }
}
