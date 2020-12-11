using System.Collections.Generic;
using LinqToDB;
using MySql.Data.MySqlClient;

namespace CarApplication.Core
{
    public static class Db
    {
        private static MySqlConnection conn;
        public static DataContext Dc;
        private static string connStr = "server=localhost;user=root;database=medicine;password=root;";

        static Db()
        {
            //  string connStr = "server=fojvtycq53b2f2kx.chr7pe7iynqr.eu-west-1.rds.amazonaws.com;user=qjilv65nwl5bpnpb;database=lhy9s8a8721ec9zw;password=qa7r09glzv88xfnz;";



            Dc = new DataContext("MySql", connStr);
        }


        public static string Scalar(string sql)
        {
            var command = new MySqlCommand(sql, conn);
            var data = command
                .ExecuteScalar();
            if (data != null) return data.ToString();
            return "";
        }

        public static Dictionary<string, string> Row(string sql)
        {
            var command = new MySqlCommand(sql, conn);

            var data = command.ExecuteReader();
            if (data.HasRows)
            {
                data.Read();
                var row = new Dictionary<string, string>();
                for (int i = 0; i < data.FieldCount; i++)
                {
                    row.Add(data.GetName(i), data.GetValue(i).ToString());
                }

                data.Close();
                return row;
            }

            return new Dictionary<string, string>();
        }

        public static List<Dictionary<string, string>> All(string sql)
        {
            conn = new MySqlConnection(connStr);
            conn.Open();

            var command = new MySqlCommand(sql, conn);

            var data = command.ExecuteReader();
            if (data.HasRows)
            {
                var dataSet = new List<Dictionary<string, string>>();
                while (data.Read())
                {
                    var row = new Dictionary<string, string>();
                    for (int i = 0; i < data.FieldCount; i++)
                        row.Add(data.GetName(i), data.GetValue(i).ToString());

                    dataSet.Add(row);
                }

                data.Close();

                return dataSet;
            }

            return new List<Dictionary<string, string>>();
        }

        public static bool Execute(string sql)
        {
            MySqlCommand command = new MySqlCommand(sql, conn);
            var res = command.ExecuteNonQuery();
            return res > 0;
        }


        private sealed class Destructor
        {
            ~Destructor()
            {
                conn.Close();
            }
        }
    }
}
