namespace Assignment8
{
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
            return abcStock.Sell();
        }
        #endregion
    }
}
