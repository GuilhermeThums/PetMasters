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
            //GravarAnimais();
            //RecuperarAnimais();
            //RemovaTodosAnimais();
            //AtualizarProduto();
            //RecuperarAnimais();
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

                Console.WriteLine($"Foram encontrados {animais.Count} animais salvos.");

                foreach (Animal animal in animais)
                {
                    Console.WriteLine(animal.ToString());
                }
            }
        }

        private static void RemovaAnimal(int numeroRegistro)
        {
            using (var contexto = new PetShopContext())
            {
                var animais = contexto.Animal.ToList();
                contexto.Animal.Remove(new Animal { NumeroRegistro = numeroRegistro });
                
                contexto.SaveChanges();
            }
        }

        private static void RemovaTodosAnimais()
        {
            using (var contexto = new PetShopContext())
            {
                var animais = contexto.Animal.ToList();
                contexto.Animal.RemoveRange(animais);

                contexto.SaveChanges();
            }
        }

        private static void AtualizarProduto()
        {
            using (var contexto = new PetShopContext())
            {
                var primeiroAnimal = contexto.Animal.First();
                primeiroAnimal.Nome = "Totó - alterado";
                contexto.Animal.Update(primeiroAnimal);

                contexto.SaveChanges();
            }

        }

    }
}
