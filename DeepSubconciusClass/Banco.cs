using MySql.Data.MySqlClient;

namespace DeepSubconciusClass
{
    public static class Banco
    {
        public static string StrConn { get; set; }

        public static MySqlCommand Abrir(string strconn="")
        {
            MySqlCommand cmd = new MySqlCommand();
            StrConn = strconn;
            if (StrConn == string.Empty)
            StrConn = $@"server=127.0.0.0;database=deepconcius;user=root;password=";

            MySqlConnection cn = new MySqlConnection(StrConn);
            try
            {
                cn.Open();
                cmd.Connection = cn;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return cmd;
        }
    }
}
