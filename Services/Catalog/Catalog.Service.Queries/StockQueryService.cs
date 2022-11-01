using Catalog.Persistence.DataBase;
using Catalog.Service.Queries.DTOs;
using Microsoft.EntityFrameworkCore;
using Service.Common.Collection;
using Service.Common.Mapping;
using Service.Common.Paging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.Service.Queries
{

    public interface IStockQueryService
    {
        Task<DataCollection<StockDto>> GetAllAsync(int page, int take, IEnumerable<int> products = null);
    }

    public class StockQueryService : IStockQueryService
    {
        private readonly ApplicationDbContext _context;

        public StockQueryService(
            ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<DataCollection<StockDto>> GetAllAsync(int page, int take, IEnumerable<int> products = null)
        {
            var collection = await _context.Stocks
                                           .Where(x => products == null || products.Contains(x.ProductId))
                                           .OrderBy(x => x.ProductId)
                                           .GetPagedAsync(page, take);
            return collection.MapTo<DataCollection<StockDto>>();
        }
    }
}
