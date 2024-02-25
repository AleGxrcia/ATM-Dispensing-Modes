using Application.Interfaces.Services;
using Application.Viewmodels;
using Microsoft.AspNetCore.Mvc;

namespace ATM_Dispensing_Modes.Controllers
{
    public class DispensingController : Controller
    {
        private readonly IDispensingService dispensingService;

        public DispensingController(IDispensingService dispensingService)
        {
            this.dispensingService = dispensingService;
        }

        public IActionResult Setting(string? message, string? alertCss)
        {
            ViewBag.Message = message;
            ViewBag.TypeAlert = alertCss;
            var vm = dispensingService.GetModoDispension();
            return View(vm);
        }

        [HttpPost]
        public IActionResult DispensingChange(DispensingViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }

            try
            {
                dispensingService.Change(vm);
                return RedirectToRoute(new { controller = "Dispensing", action = "Setting", message = "El modo de dispensación cambió correctamente", alertCss = "alert-success" });
            }
            catch (Exception)
            {
                return RedirectToRoute(new { controller = "Dispensing", action = "Setting", message = "Error al cambiar el modo de dispensación", alertCss = "alert-danger" });
            }

        }
    }
}
