using BitOfA.Helper.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace BitOfA.Helper.Persistence {
    public static class GenericQueries {
        public static Task<T> ByIdAsync<T>(this IQueryable<T> entities, long id)
        where T : IAggregateRoot {
            return entities.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
