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
