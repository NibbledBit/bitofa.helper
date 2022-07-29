using BitOfA.Helper.DDD;
using Microsoft.EntityFrameworkCore;

namespace BitOfA.Helper.Persistence {
    public abstract class DomainContext : DbContext {
        private readonly DbContextOptions<DbContext> options;
        private readonly INotifyDispatcher dispatcher;

        public DomainContext(DbContextOptions<DbContext> options, INotifyDispatcher dispatcher) {
            this.options = options;
            this.dispatcher = dispatcher;
        }


    }
}
