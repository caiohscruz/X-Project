using Microsoft.AspNetCore.Mvc;
using XProject.Application.Interfaces;
using XProject.Domain.Entitities;

namespace XProject.MVC.Controllers
{
    public class AppPageController : Controller
    {
        private readonly IAppPageService _appPageService;

        public AppPageController(IAppPageService appPageService)
        {
            _appPageService = appPageService;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<AppPage> pages = await _appPageService.GetAll();

            return View(pages);
        }

        [HttpPost]
        public async Task<IActionResult> ChangeVisibility(string id)
        {
            await _appPageService.ChangeVisibility(id);

            return RedirectToAction("Index");
        }
    }
}
