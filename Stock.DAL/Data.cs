
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Stock.DAL
{
    public class Data
    {
        public List<Stock> GetDataFromFile(string filePath)
        {
            string lines = System.IO.File.ReadAllText(filePath);

            string[] values = lines.Split(',');

            return values.Select((t, i) => new Stock
            {
                Day = i + 1, Value = Convert.ToDecimal(t)
            }).ToList();
        }
    }
}
