using PetMasters.Entidades;
using System.Collections.Generic;

namespace PetMasters.AulasEntity
{
    public interface IAnimalDAO
    {
        void AdicioneAnimal(Animal animal);

        void AtualizeAnimal(Animal animal);

        void RemovaAnimal(Animal animal);

        List<Animal> ObtenhaAnimais();

    }
}
