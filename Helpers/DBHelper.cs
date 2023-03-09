using Microsoft.Data.SqlClient;
using Dapper;

namespace BurulasWebApi.Helpers
{
    public static class DBHelper
    {
        private static String ConnectionString = "Server=.;Database=BURULASEGITIMAPI;Trusted_Connection=True;";
        public static T GetQuery<T>(string _sql, object _prms = null)
        {
            using (var con = new SqlConnection(ConnectionString))
            {
                con.Open();
                try
                {
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
                con.Open();
                try
                {
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
