using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using PetMasters.AulasEntity;

namespace PetMasters.Migrations
{
    [DbContext(typeof(PetShopContext))]
    partial class PetShopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PetMasters.Entidades.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cor")
                        .IsRequired();

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Especie")
                        .IsRequired();

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<double?>("Peso");

                    b.Property<int>("ProprietarioId");

                    b.Property<string>("Raca")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ProprietarioId");

                    b.ToTable("Animal");
                });

            modelBuilder.Entity("PetMasters.Entidades.Proprietario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CPF")
                        .IsRequired();

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Email");

                    b.Property<string>("Identidade");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("Telefone")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Proprietario");
                });

            modelBuilder.Entity("PetMasters.Entidades.Animal", b =>
                {
                    b.HasOne("PetMasters.Entidades.Proprietario", "Proprietario")
                        .WithMany()
                        .HasForeignKey("ProprietarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
