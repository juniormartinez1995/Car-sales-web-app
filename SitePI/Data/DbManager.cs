using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SitePI.Data
{
    public static class DbManager
    {

        public static MySqlConnection GetConn()
        {
            //Connection string precisa ser mudada
            MySqlConnection conn = new MySqlConnection("Server=highlander;Database=dbLPIII;Uid=estudante;Pwd=123456;");
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

        public static void ReadItem(String Elemento, String Ordem, String table, MySqlConnection Connection)
        {
            String Query = "SELECT " + Elemento + " FROM" +table +" ORDER BY " + Ordem + "";

            MySqlCommand cmd = new MySqlCommand(Query, Connection);
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine(dr[Elemento].ToString());
            }
        }
    }
}
