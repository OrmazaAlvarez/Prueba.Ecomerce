using MediatR;
using System.Collections.Generic;
using static Catalog.Common.Enums;

namespace Catalog.Service.EventHandlers.Commands
{
    public class StockUpdateCommand : INotification
    {
        public IEnumerable<StockUpdateItem> Items { get; set; } = new List<StockUpdateItem>();
    }
    public class StockUpdateItem
    {
        public int ProductId { get; set; }
        public int Stock { get; set; }
        public StockAction Action { get; set; }
    }
}
