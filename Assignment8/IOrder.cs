namespace Assignment8
{
    public interface IOrder
    {
        #region Methods
        /// <summary>
        /// This method will execute a command/string of logic that is to be carried out on the order, 
        /// or stock that implements that interface.
        /// </summary>
        /// <returns>Returns a string of information concerning the order/stock. (I.E. if a stock was purchased or sold.</returns>
        string Execute();
        #endregion
    }
}
