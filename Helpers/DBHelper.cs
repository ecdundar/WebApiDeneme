using Microsoft.Data.SqlClient;
using Dapper;

namespace BurulasWebApi.Helpers
{
    public static class DBHelper
    {
        private static String ConnectionString
        {
            get
            {
                if (Environment.MachineName == "ECDTRMO1")
                {
                    return "Server=ECDTRM01;Database=BURULASEGITIMAPI;User Id=sa;Password=123456;Integrated Security=SSPI;TrustServerCertificate=True;";
                }
                return "Server=ECDTRM01;Database=BURULASEGITIMAPI;User Id=sa;Password=123456;Integrated Security=SSPI;TrustServerCertificate=True;";
            }
        }
        public static T GetQuery<T>(string _sql, object _prms = null)
        {
            using (var con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                    return con.Query<T>(_sql, _prms).FirstOrDefault();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
        }
        public static List<T> GetList<T>(string _sql, object _prms = null)
        {
            using (var con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                    return con.Query<T>(_sql, _prms).ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
