using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace UniPoo.DAO
{
    class UnicornDAO
    {
        private static UnicornDAO instance;
        private MySqlConnection cnn;

        public static UnicornDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UnicornDAO();
                }
                return instance;
            }
        }

        private UnicornDAO()
        {
            // TODO: secure this
            string connectionString = "server=localhost;userid=root;password=root;database=unicorn";
            this.cnn = new MySqlConnection(connectionString);
            cnn.Open();
            
        }

        public List<Unicorn> GetUnicornList()
        {
            List<Unicorn> list = new List<Unicorn>();
            string stm = "SELECT id, name, birthday, color, description FROM Unicorns";
            MySqlCommand cmd = new MySqlCommand(stm, cnn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Trace.WriteLine(rdr.GetInt32(0) + ": "
                    + rdr.GetString(1) + " " + rdr.GetDateTime(2)  +" " + rdr.GetString(4));

                list.Add(new Unicorn(rdr.GetString(1), rdr.GetDateTime(2), rdr.GetString(3), rdr.GetString(4)));
            }
            return list ;
        }
        
    }
}
