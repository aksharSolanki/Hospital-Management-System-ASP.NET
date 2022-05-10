using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HospitalMS.Controllers
{
    // this will check if the user is in the session
    public class AuthController : Controller
    {
        // called before every action
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            // check if session has a key, if not found (user not logged-in), redirect back to login
            if (Session["username"] == null)
            {
                filterContext.Result = new RedirectToRouteResult(
                new RouteValueDictionary
                {
                     {"controller", "Users"},
                     {"action", "Index"}
                 }
                );
            }
        }
    }
}