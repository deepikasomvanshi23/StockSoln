﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.BLL
{
    public interface IGetStockValues
    {
       List<DAL.StockData> GetMaxGain();
    }
}
