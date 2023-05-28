using Microsoft.AspNetCore.Mvc;
using XProject.Application.DTOs;
using XProject.Application.Interfaces;
using XProject.Application.ViewModels;
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
            ViewBag.FinantialOperations = GetOrderedFinantialOperationList();

            FinantialOperationViewModel newOperation = new();

            return View(newOperation);
        }       

        [HttpPost]
        public async Task<IActionResult> Create(FinantialOperationViewModel newOperation)
        {
            if (ModelState.IsValid)
            {
                await _finantialOperationService.Create(newOperation);

                return RedirectToAction(nameof(Index));
            }

            ViewBag.FinantialOperations = GetOrderedFinantialOperationList();
            return View(nameof(Index), newOperation);
        }

        private List<FinantialOperationViewModel> GetOrderedFinantialOperationList()
        {
            List<FinantialOperationViewModel> operations = _finantialOperationService.GetAll();
            return operations.OrderByDescending(o => o.CreatedAt).ToList();
        }
    }
}
