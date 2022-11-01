using Catalog.Domain;
using Catalog.Service.EventHandlers;
using Catalog.Service.EventHandlers.Commands;
using Catalog.Service.EventHandlers.Exceptions;
using Catalog.Test.Config;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using static Catalog.Common.Enums;

namespace Catalog.Test
{
    public class StockUpdateEnventHandlerTest
    {
        //dynamic _context; 

        private ILogger<StockUpdateEnventHandler> GetLogger {
            get { return new Mock<ILogger<StockUpdateEnventHandler>>().Object; }
        }

        //[SetUp]
        //public void Setup()
        //{
          //  _context = ApplicationDbContextInMemory.Get();
        //}

        [TestCase(5, 2, 7)]
        public void AddStockWhenProductExists(int count, int reduceCount, int expected)
        {
            var _context = ApplicationDbContextInMemory.Get();
            var stock = new Stock()
            {
                StockId = 1,
                ProductId = 1,
                Count = count
            };
            _context.Stocks.Add(stock);
            _context.SaveChanges();
            var handler = new StockUpdateEnventHandler(_context, GetLogger);
            handler.Handle(new StockUpdateCommand()
            {
                Items = new List<StockUpdateItem>() {
                    new StockUpdateItem() {
                        ProductId = stock.ProductId, Stock = reduceCount, Action = StockAction.Add
                    }
                }
            }, new CancellationToken()).Wait();
            Assert.AreEqual(_context.Stocks.Single(s => s.ProductId == stock.ProductId).Count, expected);
        }

        [TestCase(2, 1)]
        public void SubtractStockWhenThereIsStock(int count, int reduceCount)
        {
            var _context = ApplicationDbContextInMemory.Get();
            var stock = new Stock() {
                StockId = 2,
                ProductId = 2,
                Count = count
            };
            _context.Stocks.Add(stock);
            _context.SaveChanges();
            var handler = new StockUpdateEnventHandler(_context, GetLogger);
            handler.Handle(new StockUpdateCommand() { 
                Items = new List<StockUpdateItem>() {
                    new StockUpdateItem() {
                        ProductId = stock.ProductId,
                        Stock = reduceCount,
                        Action = StockAction.Substract
                    }
                }
            }, new CancellationToken()).Wait();
            Assert.Pass();
        }
        
        [TestCase(1, 2)]
        public void SubtractStockWhenOutOfStock(int count, int reduceCount)
        {
            var _context = ApplicationDbContextInMemory.Get();
            var stock = new Stock()
            {
                StockId = 3,
                ProductId = 3,
                Count = count
            };
            _context.Stocks.Add(stock);
            _context.SaveChanges();
            var handler = new StockUpdateEnventHandler(_context, GetLogger);
            Assert.Throws<UpdateStockCommandException>(() =>{
                try {
                    handler.Handle(new StockUpdateCommand() { 
                        Items = new List<StockUpdateItem>() {
                            new StockUpdateItem() { ProductId = stock.ProductId, Stock = reduceCount, Action = StockAction.Substract }
                        }
                    }, new CancellationToken()).Wait();
                } catch (AggregateException ae) {
                    if (ae.GetBaseException() is UpdateStockCommandException) 
                        throw new UpdateStockCommandException(ae.GetBaseException()?.InnerException?.Message);
                }
            });
        }
    }
}