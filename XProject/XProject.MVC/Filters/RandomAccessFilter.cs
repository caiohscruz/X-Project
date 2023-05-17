using Microsoft.AspNetCore.Mvc.Filters;
using System.Runtime.InteropServices;

namespace XProject.MVC.Filters
{
    public class RandomAccessFilter : ActionFilterAttribute, IActionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var rand = new Random();

            if (rand.NextDouble() >= 0.5)
            {
                context.HttpContext.Response.Redirect("Error");
            }
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            
        }
    }
}
