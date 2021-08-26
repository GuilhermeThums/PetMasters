using System;
using System.Linq;
using PetMasters.Entidades;
using System.Collections.Generic;

namespace PetMasters.AulasEntity
{
    public class AnimalDAOEntity : IAnimalDAO, IDisposable
    {
        private PetShopContext contexto;

        public AnimalDAOEntity()
        {
            contexto = new PetShopContext();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        public void AdicioneAnimal(Animal animal)
        {
            contexto.Animal.Add(animal);
            contexto.SaveChanges();
        }

        public void AtualizeAnimal(Animal animal)
        {
            contexto.Animal.Update(animal);
            contexto.SaveChanges();
        }

        public List<Animal> ObtenhaAnimais()
        {
            return contexto.Animal.ToList();
        }

        public void RemovaAnimal(Animal animal)
        {
            contexto.Animal.Remove(animal);
            contexto.SaveChanges();
        }
    }
}
