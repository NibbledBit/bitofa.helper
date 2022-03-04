using Microsoft.EntityFrameworkCore;

namespace BitOfA.Helper.Persistence {
    public interface IContextFactory {
        DbContext CreateContext();
    }
}
