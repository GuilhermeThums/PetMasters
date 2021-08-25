using PetMasters.Entidades;
using System;

namespace PetMasters
{
    partial class Program
    {
        static void Main(string[] args)
        {
            GravarUsandoEntity();
            Console.ReadLine();
        }


        private static void GravarUsandoEntity()
        {
            var animal = new Animal("Totó", "Cachorro", "Poodle", "Preto", DateTime.Now);

            using (var contexto = new PetShopContext())
            {
                contexto.Animal.Add(animal);
                contexto.SaveChanges();
            }

        }
    }
}
