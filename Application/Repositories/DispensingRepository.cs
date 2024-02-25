using Application.Viewmodels;

namespace Application.Repositories
{
    public sealed class DispensingRepository
    {
        private DispensingRepository()
        {

        }

        public static DispensingRepository Instance { get; } = new();

        public DispensingViewModel ModoDispension { get; set; } = new DispensingViewModel() { ModoDispensacion = (int)Enum.DispensingMode.MODO_EFICIENTE };
    }
}
