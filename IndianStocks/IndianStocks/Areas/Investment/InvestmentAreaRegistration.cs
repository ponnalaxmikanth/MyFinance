using System.Web.Mvc;
 //using System.Web.Routing.RouteCollection;
using System.Web.Http;

namespace IndianStocks.Areas.Investment
{
    public class InvestmentAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Investment";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.Routes.MapHttpRoute("Investment_WebApiRoute",
                                       "Investment/Api/{controller}/{id}",
                                   new { id = UrlParameter.Optional });

            context.MapRoute(
              "Investment_default",
               "Investment/api/{controller}/{action}/{id}",
               new { action = "Index", id = UrlParameter.Optional }
           );

          //  context.Routes.MapHttpRoute(
          //     "Admin_default2",
          //     "api/Admin/{controller}/{id}",
          //     new { id = UrlParameter.Optional }
         //  );
         //   context.MapRoute(
         //       "Admin_default",
        //        "Admin/{controller}/{action}/{id}",
        //        new { action = "Index", id = UrlParameter.Optional }
        //    );
        }
    }
}

