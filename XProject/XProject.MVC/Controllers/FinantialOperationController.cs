using Microsoft.AspNetCore.Mvc;
using XProject.Application.DTOs;
using XProject.Application.Interfaces;
using XProject.Domain.Entitities;
using XProject.MVC.Models;

namespace XProject.MVC.Controllers
{
    public class FinantialOperationController : Controller
    {
        private readonly IFinantialOperationService _finantialOperationService;

        public FinantialOperationController(IFinantialOperationService finantialOperationService)
        {
            _finantialOperationService = finantialOperationService;
        }
        public async Task<IActionResult> Index()
        {
            List<FinantialOperation> operations = await _finantialOperationService.GetAll();
            ViewBag.FinantialOperations = operations.OrderByDescending(o => o.CreatedAt).ToList();

            FinantialOperationDTO newOperation = new();

            return View(newOperation);
        }

        [HttpPost]
        public async Task<IActionResult> Create(FinantialOperationDTO newOperation)
        {
            await _finantialOperationService.Create(newOperation);

            return RedirectToAction("Index");
        }
    }
}
