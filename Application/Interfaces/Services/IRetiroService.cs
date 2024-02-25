using Application.Viewmodels;

namespace Application.Interfaces.Services
{
    public interface IRetiroService
    {
        string Retirar(DispensingViewModel dispensingMode, int monto);
    }
}
