using Catalog.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Catalog.Persistence.DataBase.Configuration
{
    public class StockConfiguration
    {
        public StockConfiguration(EntityTypeBuilder<Stock> entityBuilder)
        {
            entityBuilder.HasIndex(x => x.StockId);

            //Data for test
            var stocks = new List<Stock>();
            var random = new Random();
            for (int c = 1; c <= 100; c++)
            {
                stocks.Add(new Stock
                {
                    StockId = c,
                    ProductId = c,
                    Count = random.Next(1, 100)
                });
            }
            entityBuilder.HasData(stocks);
        }
    }
}
