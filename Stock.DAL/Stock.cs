using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.DAL
{
    public class Stock
    {
        public int Day { get; set; }
        public decimal Value { get; set; }
    }

    public class StockData
    {
        public int BuyDay { get; set; }
        public int SellDay { get; set; }
        public decimal BuyValue { get; set; }
        public decimal SellValue { get; set; }
        public decimal PriceDiff { get; set; }
    }
}
