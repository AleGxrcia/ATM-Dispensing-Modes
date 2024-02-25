using Application.Validations;
using System.ComponentModel.DataAnnotations;

namespace Application.Viewmodels
{
    public class RetiroViewModel
    {
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MontoEntero]
        public int Monto { get; set; }
        public string? Resultado { get; set; }
    }
}
