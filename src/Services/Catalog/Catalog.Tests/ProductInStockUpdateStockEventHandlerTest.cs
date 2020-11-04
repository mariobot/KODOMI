using Catalog.Service.EventHandlers;
using Catalog.Service.EventHandlers.Commands;
using Catalog.Tests.Config;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Catalog.Tests
{
    [TestClass]
    public class ProductInStockUpdateStockEventHandlerTest
    {
        private ILogger<ProductInStockUpdateStockEventHandler> GetLogger
        {
            get
            {
                return new Mock<ILogger<ProductInStockUpdateStockEventHandler>>().Object;
            }
        }

        [TestMethod]
        public void TryToSubstractStockWhenProductHasStock()
        {
            var context = ApplicationDbContextInMemory.Get();

            var productInStockId = 1;
            var productId = 1;

            context.Stocks.Add(new Domain.ProductinStock
            {
                ProductId = productId,
                ProductInStockId = productInStockId,
                Stock = 1
            });

            context.SaveChanges();

            var handle = new ProductInStockUpdateStockEventHandler(context, GetLogger);

            handle.Handle(new ProductInStockUpdateStockCommand
            {
                Items = new List<ProductInStockUpdateItem>() {
                    new ProductInStockUpdateItem {
                    ProductId = productId,
                    Action = Common.Enums.ProductInStockAction.Substract,
                    Stock = 1
                    }
                }
            }, new CancellationToken()).Wait();
        }

        [TestMethod]
        public void TryToAddStockWhenProductExist()
        {
            var context = ApplicationDbContextInMemory.Get();

            var productInStockId = 3;
            var productId = 3;

            context.Stocks.Add(new Domain.ProductinStock
            {
                ProductId = productId,
                ProductInStockId = productInStockId,
                Stock = 1
            });

            context.SaveChanges();

            var handle = new ProductInStockUpdateStockEventHandler(context, GetLogger);

            handle.Handle(new ProductInStockUpdateStockCommand
            {
                Items = new List<ProductInStockUpdateItem>() {
                    new ProductInStockUpdateItem {
                    ProductId = productId,
                    Action = Common.Enums.ProductInStockAction.Add,
                    Stock = 2
                    }
                }
            }, new CancellationToken()).Wait();

            var stockInDb = context.Stocks.Single(x => x.ProductId == productId).Stock;

            Assert.AreEqual(stockInDb, 3);
        }

        [TestMethod]
        public void TryToAddStockWhenProductNotExist()
        {
            var context = ApplicationDbContextInMemory.Get();
            
            var productId = 4;

            var handle = new ProductInStockUpdateStockEventHandler(context, GetLogger);

            handle.Handle(new ProductInStockUpdateStockCommand
            {
                Items = new List<ProductInStockUpdateItem>() {
                    new ProductInStockUpdateItem {
                    ProductId = productId,
                    Action = Common.Enums.ProductInStockAction.Add,
                    Stock = 2
                    }
                }
            }, new CancellationToken()).Wait();

            var stockInDb = context.Stocks.Single(x => x.ProductId == productId).Stock;

            Assert.AreEqual(stockInDb, 2);
        }
    }
}
