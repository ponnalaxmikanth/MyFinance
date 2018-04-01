using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessAccess;
using BusinessEntity;
using System.Web.Http;
using System.Text;
using System.Net.Http;
using System.Net;

namespace IndianStocks.Areas.Investment.Controllers
{
    public class StocksController : ApiController
    {
        //
        // GET: /Investment/Stocks/

        public HttpResponseMessage post(StocksRequest request)
        {
            StocksBusinessAccess fs = new StocksBusinessAccess();
            List<StockPurchases> lsp = new List<StockPurchases>();
            lsp = fs.ToGetStocks(request.FromDate, request.ToDate);
            return Request.CreateResponse(HttpStatusCode.OK, lsp);
        }

       // public ActionResult StocksSold()
       // {
       // return null;
       // }        
       // public ActionResult PurchaseStocks()
       // {
       //  return null;
       // }
       // public ActionResult DividendStocks()
       //{
       //  return null;
       //}
       
    }
}
