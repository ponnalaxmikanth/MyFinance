using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessAccess;
using BusinessEntity;
using System.Web.Http;

namespace IndianStocks.Areas.Investment.Controllers
{
    public class StocksController : ApiController
    {
        //
        // GET: /Investment/Stocks/

        //public ActionResult Index()
        //{
        //    return View();
        //}
        //public List<StockPurchases> GetStocks(DateTime fromdate, DateTime todate)
        //{  
        //    StocksBusinessAccess fs= new StocksBusinessAccess();
        //    List<StockPurchases> lsp = new List<StockPurchases>();
        //    lsp=fs.ToGetStocks(fromdate,todate);
        //    return lsp;          
        //}

        public List<StockPurchases> GetStocks()
        {
            DateTime fromdate = DateTime.Now.AddDays(-30).Date;
            DateTime todate = DateTime.Now.Date;

            StocksBusinessAccess fs = new StocksBusinessAccess();
            List<StockPurchases> lsp = new List<StockPurchases>();
            lsp = fs.ToGetStocks(fromdate, todate);
            return lsp;
        }
        public ActionResult StocksSold()
        {
        return null;
        }        
        public ActionResult PurchaseStocks()
        {
         return null;
        }
        public ActionResult DividendStocks()
       {
         return null;
       }
       
    }
}
