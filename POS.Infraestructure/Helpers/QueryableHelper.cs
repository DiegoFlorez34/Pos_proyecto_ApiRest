using POS.Infraestructure.Commons.Bases.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Infraestructure.Helpers
{
    public static class QueryableHelper
    {
        //public static IQueryable<T> Paginate<T>(this IQueryable<T> queryable, BasePaginationRequest request)
        //{
        //   return queryable.Skip((request.NumPage -1)* request.Records).Take(request.Records);

        //}
        public static IQueryable<T> Paginate<T>(this IQueryable<T> queryable, BasePaginationRequest request)
        {
            // Si NumPage es <=0, lo ponemos en 1
            var pageNumber = request.NumPage <= 0 ? 1 : request.NumPage;

            // Si Records es <=0, lo ponemos en 10
            var records = request.Records <= 0 ? 10 : request.Records;

            return queryable
                .Skip((pageNumber - 1) * records)
                .Take(records);
        }
    }
}
