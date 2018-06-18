using System.Collections.Generic;
using System.Linq;
using Stock.DAL;
using Stock = Stock.DAL.Stock;

namespace Stock.BLL
{
    public class GetStockValues : IGetStockValues
    {
        private readonly string _filePath;

        public GetStockValues(string FilePath)
        {
            _filePath = FilePath;
        }

        private List<DAL.Stock> GetStockData()
        {
            Data data = new Data();
            List<DAL.Stock> stockData = data.GetDataFromFile(_filePath);
            return stockData;
        }

        public List<DAL.StockData> GetMaxGain()
        {
            var stockData = GetStockData();
            List<DAL.StockData> diffStocks = new List<DAL.StockData>();

            StockData stock;
            foreach (var i in stockData)
            {
                var val = stockData.FirstOrDefault(v => v.Day == i.Day);

                for (int j=i.Day+1;j<=stockData.Count;j++)
                {
                    var itVal = stockData.FirstOrDefault(k => k.Day==j);
                    var diff = val.Value - itVal.Value;

                    stock = new DAL.StockData();
                    stock.SellDay = j;
                    stock.BuyDay = i.Day;
                    stock.PriceDiff = diff;
                    stock.BuyValue = i.Value;
                    stock.SellValue = itVal.Value;
                    diffStocks.Add(stock);
                }
            }
            stock = diffStocks.OrderBy(m => m.PriceDiff).FirstOrDefault();
            return new List<StockData> {stock};
        }
    }
}
