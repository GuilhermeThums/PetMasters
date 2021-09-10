using Microsoft.EntityFrameworkCore.ChangeTracking;
using PetMasters.AulasEntity;
using PetMasters.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PetMasters
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var AndersonSilva = new Proprietario()
            {
                Nome = "Anderson da Silva",
                CPF = "379.351.390-40",
                Telefone = "55555-4444"
            };

            var tokinho = new Animal()
            {
                Nome = "Tokinho",
                Especie = "Cachorro",
                Raca = "Shihtsu",
                DataNascimento = new DateTime(2010, 9, 9),
                Cor = "Marrom",
                Proprietario = AndersonSilva
            };

            var animais = new List<Animal>();
            var proprietarios = new List<Proprietario>();

            using (var cn = new PetShopContext())
            {
                proprietarios = cn.Proprietario.ToList();
                animais = cn.Animal.ToList();
            }

            foreach (var animal in animais)
            {
                Console.WriteLine(animal);
            }


            Console.ReadLine();
        }

        static void ExibaEntries(IEnumerable<EntityEntry> entradas)
        {
            foreach (EntityEntry entrada in entradas)
            {
                Console.WriteLine($"Estado: {entrada.State} - Entidade: {entrada.Entity}");
            }
        }
    }
}
