using System;
using PetMasters.Entidades;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace PetMasters.AulasEntity
{
    public class AnimalDAO : IDisposable, IAnimalDAO
    {
        private readonly SqlConnection conexao;

        private readonly string StringConexao = "Server=(localdb)\\mssqllocaldb;Database=PetMastersDB;Trusted_Connection=true;";

        public AnimalDAO()
        {
            conexao = new SqlConnection(StringConexao);
            conexao.Open();
        }

        public void Dispose()
        {
            conexao.Close();
        }

        public void AdicioneAnimal(Animal animal)
        {
            try
            {
                SqlCommand comandoInsert = conexao.CreateCommand();

                comandoInsert.CommandText = @"INSERT INTO Animal (Nome, Especie, Raca, Cor, DataNascimento) 
                                                          VALUES (@nome, @especie, @raca, @cor, @dataNascimento)";

                var paramNome = new SqlParameter("nome", animal.Nome);
                comandoInsert.Parameters.Add(paramNome);
                
                var paramEspecie = new SqlParameter("especie", animal.Especie);
                comandoInsert.Parameters.Add(paramEspecie);
                
                var paramRaca = new SqlParameter("raca", animal.Raca);
                comandoInsert.Parameters.Add(paramRaca);
                
                var paramCor = new SqlParameter("cor", animal.Cor);
                comandoInsert.Parameters.Add(paramCor);
                
                var paramDataNascimento = new SqlParameter("dataNascimento", animal.DataNascimento);
                comandoInsert.Parameters.Add(paramDataNascimento);

                comandoInsert.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new SystemException(ex.Message, ex);
            }
        }

        public void AtualizeAnimal(Animal animal)
        {
            try
            {
                SqlCommand comandoUpdate = conexao.CreateCommand();

                comandoUpdate.CommandText = @"UPDATE Animal SET Nome = @nome, 
                                                                Especie = @especie, 
                                                                Raca = @raca, 
                                                                Cor = @cor, 
                                                                DataNascimento = @dataNascimento 
                                                                WHERE Id = @id";

                var paramNome = new SqlParameter("nome", animal.Nome);
                comandoUpdate.Parameters.Add(paramNome);

                var paramEspecie = new SqlParameter("especia", animal.Especie);
                comandoUpdate.Parameters.Add(paramEspecie);

                var paramRaca = new SqlParameter("raca", animal.Raca);
                comandoUpdate.Parameters.Add(paramRaca);

                var paramCor = new SqlParameter("cor", animal.Cor);
                comandoUpdate.Parameters.Add(paramCor);

                var paramDataNascimento = new SqlParameter("dataNascimento", animal.DataNascimento);
                comandoUpdate.Parameters.Add(paramDataNascimento);

                var paramId = new SqlParameter("id", animal.Id);
                comandoUpdate.Parameters.Add(paramId);

                comandoUpdate.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new SystemException(ex.Message, ex);
            }
        }

        public void RemovaAnimal(Animal animal)
        {
            try
            {
                SqlCommand comandoDelete = conexao.CreateCommand();
                comandoDelete.CommandText = "DELETE FROM Animal WHERE Id = @id";

                var paramId = new SqlParameter("id", animal.Id);
                comandoDelete.Parameters.Add(paramId);

                comandoDelete.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new SystemException(ex.Message, ex);
            }
        }

        public List<Animal> ObtenhaAnimais()
        {
            var animais = new List<Animal>();

            using (SqlCommand comandoSelect = conexao.CreateCommand())
            {
                comandoSelect.CommandText = "SELECT Id, Nome, Especie, Raca, Cor, DataNascimento FROM Animal";

                SqlDataReader resultSet = comandoSelect.ExecuteReader();

                if (resultSet.HasRows)
                {
                    while (resultSet.Read())
                    {
                        var animal = new Animal()
                        {
                            Id = Convert.ToInt32(resultSet["Id"]),
                            Nome = Convert.ToString(resultSet["Nome"]),
                            Especie = Convert.ToString(resultSet["Especie"]),
                            Raca = Convert.ToString(resultSet["Raca"]),
                            Cor = Convert.ToString(resultSet["Cor"]),
                            DataNascimento = Convert.ToDateTime(resultSet["DataNascimento"])
                        };
                        animais.Add(animal);
                    }
                }
            }

            return animais;
        }

    }
}
