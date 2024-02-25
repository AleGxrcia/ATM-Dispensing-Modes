using Application.Services;
using Application.Viewmodels;
using Microsoft.AspNetCore.Mvc;

namespace ATM_Dispensing_Modes.Controllers
{
    public class AtmController : Controller
    {
        private readonly IDispensingService dispensingService;
        private readonly IRetiroService retiroService;

        public AtmController(IDispensingService dispensingService, IRetiroService retiroService)
        {
            this.dispensingService = dispensingService;
            this.retiroService = retiroService;
        }

        public IActionResult Retirar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Retirar(RetiroViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }

            try
            {
                var modo = dispensingService.GetModoDispension();
                var monto = vm.Monto;

                vm.Resultado = retiroService.Retirar(modo, monto);

                return View(vm);

            }
            catch (Exception ex)
            {
                ModelState.AddModelError(nameof(vm.Monto), $@"{ex.Message}
                                                            Ajuste la cifra de {vm.Monto} o modifique la configuración de dispensación.");
                return View(vm);
            }

        }
    }
}
