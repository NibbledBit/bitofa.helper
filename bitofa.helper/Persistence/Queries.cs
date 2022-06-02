using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BitOfA.Helper.Persistence;

public static class GenericQueries
{
    public static Task<T> ByIdAsync<T>(this IQueryable<T> entities, int id)
    where T : IIntKeyedRecord
    {
        return entities.FirstOrDefaultAsync(x => x.Id == id);
    }
    public static Task<T> ByIdAsync<T>(this IQueryable<T> entities, long id)
    where T : ILongKeyedRecord
    {
        return entities.FirstOrDefaultAsync(x => x.Id == id);
    }
    public static Task<T> ByIdAsync<T>(this IQueryable<T> entities, Guid id)
    where T : IGuidKeyedRecord
    {
        return entities.FirstOrDefaultAsync(x => x.Id == id);
    }
}
