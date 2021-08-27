using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using PetMasters.AulasEntity;

namespace PetMasters.Migrations
{
    [DbContext(typeof(PetShopContext))]
    [Migration("20210827020112_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PetMasters.Entidades.Animal", b =>
                {
                    b.Property<int>("NumeroRegistro")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cor");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Especie");

                    b.Property<string>("Nome");

                    b.Property<string>("Raca");

                    b.HasKey("NumeroRegistro");

                    b.ToTable("Animal");
                });
        }
    }
}
