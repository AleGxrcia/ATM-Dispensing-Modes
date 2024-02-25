using System.ComponentModel.DataAnnotations;

namespace Application.Validations
{
    public class MontoEnteroAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return ValidationResult.Success;
            }

            var monto = int.Parse(value.ToString());

            if (monto % 100 != 0)
            {
                return new ValidationResult(@"Por favor, ingrese un monto válido en billetes de 100 o más.
                                            Asegúrese de ingresar un número entero y que cumpla con las denominaciones de billetes disponibles.");
            }

            return ValidationResult.Success;

        }
    }
}
