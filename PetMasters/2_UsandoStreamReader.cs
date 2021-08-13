using System;
using System.IO;
using PetMasters.Entidades;

namespace PetMasters
{
    partial class Program
    {
        static void UtilizandoStreamReader()
        {
            var enderecoArquivo = "animais.txt";

            using (var fluxoArquivo = new FileStream(enderecoArquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxoArquivo))
            {
                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();
                    Animal animal = ConverteStringParaAnimal(linha);

                    Console.WriteLine(animal);
                }
            }
        }


        static Animal ConverteStringParaAnimal(string linha)
        {
            string[] campos = linha.Split(';');

            var nome = campos[0];
            var especie = campos[1];
            var raca = campos[2];
            var cor = campos[3];
            var dataNascimentoString = campos[4];
            var diaDataNascimento = int.Parse(dataNascimentoString.Substring(0, 2));
            var mesDataNascimento = int.Parse(dataNascimentoString.Substring(3, 2));
            var anoDataNascimento = int.Parse(dataNascimentoString.Substring(6, 4));

            var dataNascimento = new DateTime(anoDataNascimento, mesDataNascimento, diaDataNascimento);

            return new Animal(nome, especie, raca, cor, dataNascimento);
        }
    }
}
