using Application.Viewmodels;

namespace Application.Interfaces.Services
{
    public interface IDispensingService
    {
        void Change(DispensingViewModel vm);
        DispensingViewModel GetModoDispension();
    }
}
