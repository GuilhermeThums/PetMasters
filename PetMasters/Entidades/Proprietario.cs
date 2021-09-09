using System;
using System.ComponentModel.DataAnnotations;

namespace PetMasters.Entidades
{
    public class Proprietario
    {
        public int Id { get; set; }
        
        [Required]
        public string CPF { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Telefone { get; set; }

        public string Identidade { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Email { get; set; }
    }
}
