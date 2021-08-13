using PetMasters.Enumeradores;
using System;

namespace PetMasters.Entidades
{
    public class Proprietario
    {
        public string Nome { get; set; }

        public string Telefone { get; set; }

        public string CPFCNPJ { get; set; }

        public string Identidade { get; set; }

        public DateTime DataNascimento { get; set; }

        public EnumeradorTipoTelefone TipoTelefone { get; set; }

        public Endereco Endereco { get; set; }

        public string Email1 { get; set; }

        public string Email2 { get; set; }


    }
}
