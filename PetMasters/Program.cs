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
            //GravarAnimais();
            RecuperarAnimais();
            Console.ReadLine();
        }


        private static void GravarAnimais()
        {
            var animal = new Animal()
            {
                Nome = "Totó",
                Especie = "Cachorro",
                Raca = "Poodle",
                Cor = "Preto",
                DataNascimento = DateTime.Now
            };

            using (var contexto = new PetShopContext())
            {
                contexto.Animal.Add(animal);
                contexto.SaveChanges();
            }

        }

        private static void RecuperarAnimais()
        {
            using (var contexto = new PetShopContext())
            {
                List<Animal> animais = contexto.Animal.ToList();

                foreach (Animal animal in animais)
                {
                    Console.WriteLine(animal.ToString());
                }
            }
        }

    }
}
