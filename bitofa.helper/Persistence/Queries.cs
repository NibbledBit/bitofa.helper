using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace BitOfA.Helper.Persistence
{
    public static class GenericQueries
    {
        public static Task<T> ByIdAsync<T>(this IQueryable<T> entities, int id)
        where T : IStandardRecord
        {
            return entities.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
