using Application.Repositories;
using Application.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface IDispensingService
    {
        void Change(DispensingViewModel vm);
        DispensingViewModel GetModoDispension();
    }

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
