namespace TCMBApi.Dtos
{
    /// <summary>
    /// Initializes a new instance of the OrderByOption class.
    /// </summary>
    public class OrderByOption
    {
        public string Field { get; set; }
        public OrderType OrderType { get; set; }
    }
}