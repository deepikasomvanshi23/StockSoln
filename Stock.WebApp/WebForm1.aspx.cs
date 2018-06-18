using System;
using System.IO;
using System.Linq;
using System.Web.UI.WebControls;
using Stock.BLL;

namespace Stock.WebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
                BindFilesDropDown();
        }

       private void BindFilesDropDown()
        {
           var directoryPath= Server.MapPath("~/DataFiles");

            if (Directory.Exists(directoryPath))
            {
                ddlDataSampleFiles.Items.Clear();
                string[] fileEntries = Directory.GetFiles(directoryPath);

                ddlDataSampleFiles.Items.Add(new ListItem("Please Select",""));
                foreach (var file in fileEntries)
                {
                    ddlDataSampleFiles.Items.Add(new ListItem(Path.GetFileName(file), file));
                }
            }
        }

        protected void ddlDataSampleFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlDataSampleFiles.SelectedIndex > 0 && !string.IsNullOrEmpty(ddlDataSampleFiles.SelectedValue))
            {
                IGetStockValues stockVals = new GetStockValues(ddlDataSampleFiles.SelectedValue);
                var maxGainDays = stockVals.GetMaxGain();
                if (maxGainDays != null && maxGainDays.Count > 0)
                {
                    var buySellDays = maxGainDays.FirstOrDefault();
                    lblResults.Text =
                        string.Format(
                            " Buy Day: {0} , Buy Value: {1} , Sell Day: {2} ,Sell Value: {3} for maximum profit.",
                            buySellDays.BuyDay, buySellDays.BuyValue.ToString("c"), buySellDays.SellDay, buySellDays.SellValue.ToString("c"));
                }
            }
        }
    }
}