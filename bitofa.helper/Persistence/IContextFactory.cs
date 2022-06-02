using Microsoft.EntityFrameworkCore;

namespace BitOfA.Helper.Persistence {
    public interface IContextFactory<T> where T : DbContext
    {
        T CreateContext();
    }
}
