using Application.Interfaces.Services;
using Application.Repositories;
using Application.Viewmodels;

namespace Application.Services
{
    public class DispensingService : IDispensingService
    {
        public void Change(DispensingViewModel vm)
        {
            switch (vm.ModoDispensacion) 
            {
                case (int)Enum.DispensingMode.MODO_200Y1000:
                    DispensingRepository.Instance.ModoDispension.ModoDispensacion = vm.ModoDispensacion;
                    break;
                case (int)Enum.DispensingMode.MODO_100Y500:
                    DispensingRepository.Instance.ModoDispension.ModoDispensacion = vm.ModoDispensacion;
                    break;
                case (int)Enum.DispensingMode.MODO_EFICIENTE:
                    DispensingRepository.Instance.ModoDispension.ModoDispensacion = vm.ModoDispensacion;
                    break;
            }
        }

        public DispensingViewModel GetModoDispension()
        {
            return DispensingRepository.Instance.ModoDispension;
        }
    }
}
