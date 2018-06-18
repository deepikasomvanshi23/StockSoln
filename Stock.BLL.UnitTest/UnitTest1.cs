using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Stock.BLL.UnitTest
{
    [TestClass]
    public class GetStockValuesTest
    {
        [TestMethod]
        public void GetMinAndMaxValueTest()
        {
            IGetStockValues obj=new GetStockValues();
            var vals = obj.GetMaxGain();
            Assert.IsNotNull(vals);
        }
    }
}
