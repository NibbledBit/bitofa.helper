using BitOfA.Helper.DDD;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BitOfA.Helper.Persistence
{
    public abstract class DomainContext : DbContext
    {
        private readonly DbContextOptions<DbContext> options;
        private readonly INotifyDispatcher dispatcher;

        public DomainContext(DbContextOptions<DbContext> options, INotifyDispatcher dispatcher)
        {
            this.options = options;
            this.dispatcher = dispatcher;
        }


    }
}
