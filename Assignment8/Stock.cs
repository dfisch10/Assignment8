using System;

namespace Assignment8
{
    public class Stock
    {
        #region Fields
        /// <summary>
        /// Field for the name of the stock.
        /// </summary>
        private String name = "ABC";
        /// <summary>
        /// Field for the quanity of the stock to be purchased or sold.
        /// </summary>
        private int quantity = 10;
        #endregion

        #region Methods
        /// <summary>
        /// Takes the stock object's name and quantity and returns a string specifies that it was bought.
        /// </summary>returns the name and quantity of the stock and specifies that it is bought.
        /// <returns>Returns the name and quantity of the stock and specifies that it is bought.</returns>
        public string Buy()
        {
            return ("Stock [ Name: " + name + ", Quantity: " + quantity + " ] bought");
        }

        /// <summary>
        /// Takes the stock object's name and quantity and returns a string specifies that it was sold.
        /// </summary>
        /// <returns>Returns the name and quantity of the stock and specifies that it is sold.</returns>
        public string Sell()
        {
            return ("Stock [ Name: " + name + ", Quantity: " + quantity +" ] sold");
        }
        #endregion
    }
}
