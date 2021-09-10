using System;
using System.ComponentModel.DataAnnotations;

namespace PetMasters.Entidades
{
    public class Animal
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Especie { get; set; }

        [Required]
        public string Raca { get; set; }

        [Required]
        public string Cor { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        public double? Peso { get; set; }

        [Required]
        public Proprietario Proprietario { get; set; }

        //public EnumeradorPelo Pelo { get; set; }

        //public EnumeradorSexoAnimal Sexo { get; set; }

        //public EnumeradorSituacaoCastracao SituacaoCastracao { get; set; }

        //public string Restricoes { get; set; }

        //public string Microchip { get; set; }

        //public bool PossuiMicrochip => !string.IsNullOrEmpty(Microchip);

        //public override string ToString()
        //{
        //    return $"Animal de registro: {Id}, nome: {Nome}, espécie: {Especie}, raça: {Raca}, pelo da cor: {Cor}, nascido na data de {DataNascimento.ToLongDateString()}";
        //}

        public override string ToString()
        {
            return $"Animal de registro: {Id}, nome: {Nome}, espécie: {Especie}, raça: {Raca}, pelo da cor: {Cor}.\nProprietário: {Proprietario?.Nome}";
        }
    }
}
