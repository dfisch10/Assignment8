using Microsoft.Extensions.DependencyInjection;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Authentication.ExtendedProtection;
using Xunit;

namespace Assignment8.tests
{
    [ExcludeFromCodeCoverage]
    public class UnitTest1
    {
        #region Stock Class Tests
        [Fact]
        public void Buy_InitializeAStockAndEnsureOutput_ReturnsValid()
        {
            var sut = new Stock();
       
            Assert.Equal("Stock [ Name: ABC, Quantity: 10 ] bought", sut.Buy());
        }

        [Fact]
        public void Sell_InitializeAStockAndEnsureOutput_ReturnsValid()
        {
            var sut = new Stock();

            Assert.Equal("Stock [ Name: ABC, Quantity: 10 ] sold", sut.Sell());
        }
        #endregion

        #region BuyStock Class Test
        [Fact]
        public void BuyStock_ImplementingABuyStockObjectAndTestingExecute_ReturnsValid()
        {
            var stock = new Stock();
            var sut = new BuyStock(stock);

            Assert.Equal(sut.Execute(), stock.Buy());
        }
        #endregion

        #region SellStock Class Test
        [Fact]
        public void SellStock_ImplementingASellStockObjectAndTestingExecute_ReturnsValid()
        {
            var stock = new Stock();
            var sut = new SellStock(stock);

            Assert.Equal(sut.Execute(), stock.Sell());
        }
        #endregion

        #region Broker Class Test
        [Fact]
        public void PlaceOrders_InitializingABrokerAndPassingBuyStockValues_ReturnsValid()
        {
            Broker sut = new Broker();
            var stock = new Stock();
            var buyStock = new BuyStock(stock);

            sut.TakeOrder(buyStock);
            sut.TakeOrder(buyStock);
            sut.RemoveOrder(buyStock);

            Assert.Equal(stock.Buy() + "\n", sut.PlaceOrders());
        }

        [Fact]
        public void PlaceOrders_InitializingABrokerAndPassingSellStockValues_ReturnsValid()
        {
            Broker sut = new Broker();
            var stock = new Stock();
            var sellStock = new SellStock(stock);

            sut.TakeOrder(sellStock);
            sut.TakeOrder(sellStock);
            sut.RemoveOrder(sellStock);

            Assert.Equal(stock.Sell() + "\n", sut.PlaceOrders());
        }
        #endregion
    }
}
