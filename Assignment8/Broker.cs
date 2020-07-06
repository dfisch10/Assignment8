using System;
using System.Collections.Generic;

namespace Assignment8
{
    public class Broker
    {
        #region Fields
        /// <summary>
        /// List of type IOrder that tracks all the bought and sold orders takes
        /// </summary>
        public List<IOrder> orderList = new List<IOrder>();
        #endregion

        #region Methods
        /// <summary>
        /// Adds either a purchased or sold order record to the list.
        /// </summary>
        /// <param name="order">The bought/sold order that is being made of type IOrder.</param>
        public void TakeOrder(IOrder order)
        {
            orderList.Add(order);
        }

        /// <summary>
        /// Removes an Order from the list
        /// </summary>
        /// <param name="order">The bought/sold order that is being made of type IOrder.</param>
        public void RemoveOrder(IOrder order)
        {
            orderList.Remove(order);
        }

        /// <summary>
        /// Executes all of the orders that are in the orderList, 
        /// returning the name and quantity of the order, as well as if the item/qty was "bought" or "sold".
        /// </summary>
        /// <returns>Returns the name and quantity of an order, and whether that order was bought or sold.</returns>
        public string PlaceOrders()
        {
            var result = "";

            if (orderList is null || orderList.ToString() == "")
            {
                return "You may not place an order on an empty/null list, please take an order and try again.";
            }


            foreach (var order in orderList)
            {
                result += (order.Execute() + "\n"); 
            }

            orderList.Clear();

            return result;
        }
        #endregion
    }

}
