using Enums;

namespace TableManager
{
    public partial class ItemDataTRow : IRow
    {
        /*  */
        public string id { get; set; } 

        /*  */
        public int price { get; set; } 

        /*  */
        public CurrencyType currencyType { get; set; } 


    }
}
