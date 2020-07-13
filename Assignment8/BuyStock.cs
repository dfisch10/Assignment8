using System;

namespace Assignment8
{
    /// <summary>
    /// This class contains the constructor for creating BuyStock objects of type Stock, as well as the Execute() method.
    /// Which is meant to run the Stock Class command of Buy(), as part of the Command Design Pattern. 
    /// </summary>
    public class BuyStock: IOrder
    {
        #region Fields

        /// <summary>
        /// Field for the stock object that is to be purchased
        /// </summary>
        private Stock abcStock;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor that takes in a stock object and assigns to the stock field in this class.
        /// </summary>
        /// <param name="abcStock">The stock object that is passed into the constructor to become a "buystock".</param>
        public BuyStock(Stock abcStock)
        {
            if(abcStock is null)
            {
                Console.WriteLine("You may not have a null stock, please enter in a stock and try again.");
            }
            this.abcStock = abcStock;
        }

        #endregion

        #region Methods

        /// <summary>
        /// This method executes the "Buy()" method on the stock object, and returns that string of information.
        /// </summary>
        /// <returns>Returns the name and quantity of the stock and specifies that it is bought.</returns>
        public string Execute()
        {
            return abcStock?.Buy();
        }

        #endregion
    }
}
