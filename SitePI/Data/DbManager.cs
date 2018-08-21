using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using SitePI.Models.CarServicesViewModels;

namespace SitePI.Data
{
    public static class DbManager
    {

        public static MySqlConnection GetConn()
        {
            //Connection string precisa ser mudada
            MySqlConnection conn = new MySqlConnection("Server=localhost;Database=testdb;Uid=root;Pwd=1234;SslMode=none;");
            return conn;
        }

        public static void InsertItem(MySqlConnection Connection)
        {
            //String Query = "INSERT INTO Funcionario (Matricula, Nome, Salario, DiaAdm, MesAdm, AnoAdm, Setor, Equipe) VALUES ('" + pessoa.Matricula + "', '" + pessoa.Nome + "', '" + pessoa.Salario + "', '" + pessoa.DiaAdm + "', '" + pessoa.MesAdm + "', '" + pessoa.AnoAdm + "', '" + pessoa.Setor + "', '" + pessoa.Equipe + "')";
            String Query = "SO PRA NAO BUGAR";
            MySqlCommand cmd = new MySqlCommand(Query, Connection);

            cmd.ExecuteNonQuery();
        }

        public static void UpdateItem(MySqlConnection c)
        {
            try
            {
                c.Open();
                //String Query = "UPDATE Funcionario SET Salario=Salario*1.05 WHERE Matricula='" + Matricula + "' AND Equipe='Globalization'";
                String Query = "SO PRA NAO BUGAR";
                MySqlCommand cmd = new MySqlCommand(Query, c);

                cmd.ExecuteNonQuery();
                c.Close();
            }
            catch (MySqlException ex)
            {

                c.Close();
            }
        }

        public static List<DbModel> ReadItem(MySqlConnection Connection)
        {
            String Query = "SELECT * FROM user";

            List<DbModel> List = new List<DbModel>();

            Connection.Open();

            MySqlCommand cmd = new MySqlCommand(Query, Connection);
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                List.Add(new DbModel
                {
                    id = dr.GetInt32("id"),
                    Nome = dr["Nome"].ToString(),
                    Sobrenome = dr["Sobrenome"].ToString(),
                    Local = dr["Local"].ToString(),
                    HorarioCadastro = dr.GetDateTime("HorarioCadastro")
                });
                Debug.WriteLine(dr["Nome"].ToString());
            }

            return List;
        }
    }
}
