using System.Collections.Generic;
using System.Linq;

namespace Dinaf.Sismo.Application.Common.ExtensionMethods
{
    public static class PaginationExtensionMethod
    {
        public static IList<T> Paginate<T>(this IList<T> list, int pageSize, int pageNumber)
        {
            if (list == null) return null;

            if (pageSize == 0 || pageNumber == 0) return list;

            return list.Skip(pageSize * (pageNumber - 1))
                .Take(pageSize)
                .ToList();
        }
    }
}