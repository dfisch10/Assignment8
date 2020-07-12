using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace Assignment8
{
    [ExcludeFromCodeCoverage]
    class Program
    {
        /// <summary>
        /// This is my main method.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Stock abcStock = new Stock();

            BuyStock buyStockOrder = new BuyStock(abcStock);
            SellStock sellStockOrder = new SellStock(abcStock);

            Broker broker = new Broker();
            broker.TakeOrder(buyStockOrder);
            broker.TakeOrder(sellStockOrder);

            Console.WriteLine(broker.PlaceOrders());
        }
    }
}
