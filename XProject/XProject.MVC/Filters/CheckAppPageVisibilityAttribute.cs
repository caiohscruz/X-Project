using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using XProject.Application.Interfaces;
using XProject.Domain;
using XProject.Domain.Enums;

namespace XProject.MVC.Filters
{
    [AttributeUsage(AttributeTargets.Method)]
    public class CheckAppPageVisibilityAttribute : Attribute, IAsyncAuthorizationFilter
    {
        private readonly AppPageEnum _appPage;

        public CheckAppPageVisibilityAttribute(AppPageEnum pagina)
        {
            _appPage = pagina;
        }

        public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            var appPageService = context.HttpContext.RequestServices.GetService<IAppPageService>();

            if (appPageService == null)
            {
                throw new InvalidOperationException();
            }

            bool isVisible = await appPageService.CheckVisibility(_appPage);

            if (!isVisible)
            {
                context.HttpContext.Response.Redirect("Error");
            }
        }
    }
}
