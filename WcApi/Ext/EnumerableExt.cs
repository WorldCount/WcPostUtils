using System.Collections.Generic;
using System.Linq;

namespace WcApi.Ext
{
    public static class EnumerableExt
    {
        public static IEnumerable<IEnumerable<T>> Chunk<T>(this IEnumerable<T> source, int chunksize)
        {
            // ReSharper disable once PossibleMultipleEnumeration
            while (source.Any())
            {
                // ReSharper disable once PossibleMultipleEnumeration
                yield return source.Take(chunksize);
                // ReSharper disable once PossibleMultipleEnumeration
                source = source.Skip(chunksize);
            }
        }
    }
}
