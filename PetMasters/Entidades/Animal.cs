using System;
using PetMasters.Enumeradores;

namespace PetMasters.Entidades
{
    public class Animal
    {
        public string Nome { get; set; }

        public string Especie { get; set; }

        public string Raca { get; set; }

        public string Cor { get; set; }

        public DateTime DataNascimento { get; set; }

        public Proprietario Proprietario { get; set; }

        public EnumeradorPelo Pelo { get; set; }

        public EnumeradorSexoAnimal Sexo { get; set; }

        public EnumeradorSituacaoCastracao SituacaoCastracao { get; set; }

        public double Peso { get; set; }

        public string Restricoes { get; set; }

        public string Microchip { get; set; }

        public bool PossuiMicrochip => !string.IsNullOrEmpty(Microchip);

        public Animal(string nome, string especie, string raca, string cor, DateTime dataNascimento)
        {
            Nome = nome;
            Especie = especie;
            Raca = raca;
            Cor = cor;
            DataNascimento = dataNascimento;
        }

        public override string ToString()
        {
            return $"Animal de nome: {Nome}, espécie: {Especie}, raça: {Raca}, pelo da cor: {Cor}, nascido na data de {DataNascimento.ToLongDateString()}";
        }
    }
}
