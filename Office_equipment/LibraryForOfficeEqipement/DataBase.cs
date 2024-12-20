using System.Data;
using System.Data.SqlClient;
using System.Net.Sockets;
namespace LibraryForOfficeEqipement
{
    public class DataBase
    {
        private static string connectionString = "Server=192.168.188.11;Database=Mironova_EP;Trusted_Connection=True;";
        public static string ConnectionString { get { return connectionString; } }

        public static string GetAvgTime(DataTable request)
        {
            TimeSpan diff1 = new TimeSpan();
            int count = 0;
            for (int i = 0; i < request.Rows.Count; i++)
            {
                if (request.Rows[i][6].ToString() != string.Empty && request.Rows[i][7].ToString() != string.Empty)
                {
                    diff1 += DateTime.Parse(request.Rows[i][6].ToString()).Subtract(DateTime.Parse(request.Rows[i][7].ToString()));
                    count++;
                }
            }
            TimeSpan diff2 = diff1 / count;
            return diff2.Days.ToString().Remove(0, 1) + " дн.";
        }

        public static int Login(string login, string password)
        {
            using (SqlConnection connection = new SqlConnection(DataBase.ConnectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter($"EXEC login '{login}', '{password}'", connection);
                DataTable profile = new DataTable();
                adapter.Fill(profile);
                if (profile.Rows.Count > 0)
                {
                    return int.Parse(profile.Rows[0][1].ToString());
                }
                else return -1;
            }
        }

        public static DataTable GetTable()
        {
            DataTable request;
            using (SqlConnection connection = new SqlConnection(DataBase.ConnectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter($"EXEC get_request", connection);
                request = new DataTable();
                adapter.Fill(request);
            }
            return request;
        }

        public static void AddRequest(int id, string model, string problem)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"EXEC add_request {id}, '{model}', '{problem}';", connection);
                command.ExecuteReader();
            }
        }
    }
}
