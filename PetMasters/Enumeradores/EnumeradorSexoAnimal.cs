using System.ComponentModel.DataAnnotations;

namespace PetMasters.Enumeradores
{
    public enum EnumeradorSexoAnimal
    {
        Macho = 0,
        [Display(Name = "Fêmea")]
        Femea = 10
    }
}
