using Dapper;
using System.Configuration;
using System.Data.SqlClient;

namespace EstatisticasBuscaEmprego
{
    public class DBHelper
    {
        private readonly SqlConnection cnx;
        private string strCnx;

        public DBHelper()
        {
            strCnx = ConfigurationManager.ConnectionStrings["local"].ConnectionString;
            cnx = new SqlConnection(strCnx);
        }

        public void AbrirConexao()
        {
            cnx.Open();
        }

        public void FecharConexao()
        {
            cnx.Close();
        }

        public int ExecutarComando(string comando)
        {
            return cnx.Execute(comando);
        }

        public IEnumerable<T> ExecutarComando<T>(string comando)
        {
            return cnx.Query<T>(comando);
        }
    }
}