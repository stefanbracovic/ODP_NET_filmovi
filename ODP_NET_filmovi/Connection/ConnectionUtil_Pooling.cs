using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Oracle.ManagedDataAccess.Client;

namespace ODP_NET_filmovi.ConnectionPool
{
    public class ConnectionUtil_Pooling : IDisposable
    {
        private static IDbConnection instance = null;

        public static IDbConnection GetConnection()
        {
            if (instance == null || instance.State == System.Data.ConnectionState.Closed)
            {
                //OracleConnectionStringBuilder ocsb = new OracleConnectionStringBuilder();                             
                //ocsb.Pooling = true;
                //ocsb.MinPoolSize = 1;
                //ocsb.MaxPoolSize = 10;

            }
            return instance;
        }

        public void Dispose()
        {
            //instance.Close();
        }
    }
}
