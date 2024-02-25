using System.ComponentModel.DataAnnotations;


namespace Application.Viewmodels
{
    public class DispensingViewModel
    {
        [Display(Name = "Modo de Dispensacion")]
        public int ModoDispensacion { get; set; }
    }
}
