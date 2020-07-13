using System;

namespace Assignment8
{
    public class Stock
    {
        #region Fields
        /// <summary>
        /// Field for the name of the stock.
        /// </summary>
        public String Name = "ABC";
        /// <summary>
        /// Field for the quanity of the stock to be purchased or sold.
        /// </summary>
        public int Quantity = 10;
        #endregion

        #region Methods
        /// <summary>
        /// Takes the stock object's name and quantity and returns a string specifies that it was bought.
        /// </summary>returns the name and quantity of the stock and specifies that it is bought.
        /// <returns>Returns the name and quantity of the stock and specifies that it is bought.</returns>
        public string Buy()
        {
            return ("Stock [ Name: " + Name + ", Quantity: " + Quantity + " ] bought");
        }

        /// <summary>
        /// Takes the stock object's name and quantity and returns a string specifies that it was sold.
        /// </summary>
        /// <returns>Returns the name and quantity of the stock and specifies that it is sold.</returns>
        public string Sell()
        {
            return ("Stock [ Name: " + Name + ", Quantity: " + Quantity + " ] sold");
        }
        #endregion
    }
}
