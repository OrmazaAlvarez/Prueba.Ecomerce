using System;

namespace Catalog.Service.EventHandlers.Exceptions
{
    public class UpdateStockCommandException : Exception
    {
        public UpdateStockCommandException(string message) : base(message) { }
    }
}
