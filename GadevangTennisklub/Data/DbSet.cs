

namespace GadevangTennisklub.Data
{
    public class DbSet<T>
    {
        internal object Include(Func<object, object> value)
        {
            throw new NotImplementedException();
        }

        internal object? ToList()
        {
            throw new NotImplementedException();
        }

        internal async Task<string?> ToListAsync()
        {
            throw new NotImplementedException();
        }
    }
}