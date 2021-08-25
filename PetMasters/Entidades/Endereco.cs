using System.ComponentModel.DataAnnotations;

namespace PetMasters.Entidades
{
    public class Endereco
    {
        [Key]
        public string CEP { get; set; }

        public string Logradouro { get; set; }

        public string Bairro { get; set; }

        public int Numero { get; set; }

        public string Complemento { get; set; }

        public int MyProperty { get; set; }
    }
}
