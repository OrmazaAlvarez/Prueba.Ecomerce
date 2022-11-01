using Catalog.Domain;
using Catalog.Persistence.DataBase;
using Catalog.Service.EventHandlers.Commands;
using Catalog.Service.EventHandlers.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static Catalog.Common.Enums;

namespace Catalog.Service.EventHandlers
{
    public class StockUpdateEnventHandler : INotificationHandler<StockUpdateCommand>
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<StockUpdateEnventHandler> _logger;

        public StockUpdateEnventHandler(ApplicationDbContext context,
            ILogger<StockUpdateEnventHandler> logger)
        {
            _context = context;
            _logger = logger;
        }
        
        public async Task Handle(StockUpdateCommand notification, CancellationToken cancellationToken)
        {
            //Parall el usar servicios de monitoreo 
            _logger.LogInformation("--- Stock Update Command started");

            var products = notification.Items.Select(x => x.ProductId);
            var stocks = await _context.Stocks.Where(x => products.Contains(x.ProductId)).ToListAsync();

            _logger.LogInformation("--- Retrieve products from database");

            foreach (var item in notification.Items)
            {
                var entry = stocks.SingleOrDefault(x => x.ProductId == item.ProductId);

                if (item.Action == StockAction.Substract)
                {
                    if (entry == null || item.Stock > entry.Count)
                    {
                        _logger.LogError($"--- Product {entry.ProductId} -doens't have enough stock");
                        throw new UpdateStockCommandException($"Product {entry.ProductId} - doens't have enough stock");
                    }

                    entry.Count -= item.Stock;

                    _logger.LogInformation($"--- Product {entry.ProductId} decreased its stock by {entry.Count}");
                }
                else
                {
                    if (entry == null)
                    {
                        entry = new Stock
                        {
                            ProductId = item.ProductId
                        };

                        _logger.LogInformation($"--- New stock record was created for {entry.ProductId} because didn't exists before");

                        await _context.AddAsync(entry);
                    }

                    _logger.LogInformation($"--- the stock of product {item.ProductId} increased by {item.Stock}");
                    entry.Count += item.Stock;
                }
            }

            await _context.SaveChangesAsync();
            _logger.LogInformation("--- Stock Update Command finished");
        }
    }
}
