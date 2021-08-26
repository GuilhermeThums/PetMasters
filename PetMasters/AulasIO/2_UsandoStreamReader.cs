using System;
using System.IO;
using System.Globalization;
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
            var dataNascimento = DateTime.Parse(dataNascimentoString, new CultureInfo("pt-BR"));

            return new Animal()
            {
                Nome = nome,
                Especie = especie,
                Raca = raca,
                Cor = cor,
                DataNascimento = dataNascimento
            };
        }
    }
}
