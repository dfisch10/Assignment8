using System;
using System.Collections.Generic;

namespace Assignment8
{
    /// <summary>
    /// The Broker class contains the methods to handle the placing, removing, and taking of orders (PlaceOrder(), RemoveOrder(), and TakeOrder()). 
    /// Along with the OrderList field which is a list of type IOrders, which utilizes the IOrder interface for keeping track of taken and removed orders to be placed.
    /// </summary>
    public class Broker
    {
        #region Fields
        /// <summary>
        /// List of type IOrder that tracks all the bought and sold orders takes
        /// </summary>
        public List<IOrder> OrderList = new List<IOrder>();
        #endregion

        #region Methods
        /// <summary>
        /// Adds either a purchased or sold order record to the list.
        /// </summary>
        /// <param name="order">The bought/sold order that is being made of type IOrder.</param>
        public void TakeOrder(IOrder order)
        {
            if (order is null)
            {
                Console.WriteLine("You may not have a null order, please enter in an order and try again.");
            }
            OrderList?.Add(order);
        }

        /// <summary>
        /// Removes an Order from the list
        /// </summary>
        /// <param name="order">The bought/sold order that is being made of type IOrder.</param>
        public void RemoveOrder(IOrder order)
        {
            OrderList?.Remove(order);
        }

        /// <summary>
        /// Executes all of the orders that are in the orderList, 
        /// returning the name and quantity of the order, as well as if the item/qty was "bought" or "sold".
        /// </summary>
        /// <returns>Returns the name and quantity of an order, and whether that order was bought or sold.</returns>
        public string PlaceOrders()
        {
            var result = "";

            if (OrderList is null || OrderList.ToString() == "")
            {
                return "You may not place an order on an empty/null list, please take an order and try again.";
            }


            foreach (var order in OrderList)
            {
                result += (order?.Execute() + "\n"); 
            }

            OrderList.Clear();

            return result;
        }
        #endregion
    }

}
