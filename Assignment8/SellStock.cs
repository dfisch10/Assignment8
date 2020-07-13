using System;

namespace Assignment8
{
    /// <summary>
    /// This class contains the constructor for creating SellStock objects of type Stock, as well as the Execute() method.
    /// Which is meant to run the Stock Class command of Sell(), as part of the Command Design Pattern. 
    /// </summary>
    public class SellStock: IOrder
    {
        #region Fields

        private Stock abcStock;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor that takes in a stock object and assigns to the stock field in this class.
        /// </summary>
        /// <param name="abcStock">The stock object that is passed into the constructor to become a "Sellstock".</param>
        public SellStock(Stock abcStock)
        {
            if (abcStock is null)
            {
                Console.WriteLine("You may not have a null stock, please enter in a stock and try again.");
            }
            this.abcStock = abcStock;
        }

        #endregion

        #region Methods

        /// <summary>
        /// This method executes the "Sell()" method on the stock object, and returns that string of information.
        /// </summary>
        /// <returns>Returns the name and quantity of the stock and specifies that it is sold.</returns>
        public string Execute()
        {
            return abcStock?.Sell();
        }

        #endregion
    }
}
