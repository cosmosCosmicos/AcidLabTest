using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;

namespace WorldIndicator.Connections
{
    public static class Connection
    {
        public static TResult GetSingleData<TResult>(ConnectionNameEnum connectionName, string storeProcedureName,
            object parameters)
        {
            using (
                SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings.Get(connectionName.ToString())))
            {
                var flag = false;

                try
                {
                    conn.Open();
                    TResult result =
                        conn.Query<TResult>(storeProcedureName, parameters, commandType: CommandType.StoredProcedure)
                            .SingleOrDefault();
                    conn.Close();

                    flag = true;

                    return result;
                }
                catch
                {
                    conn.Close();

                    return (TResult) Convert.ChangeType(null, typeof (TResult));
                }
                finally
                {
                    if (!flag)
                    {
                        conn.Close();
                    }
                }
            }
        }

        public static List<TResult> GetListData<TResult>(ConnectionNameEnum connectionName, string storeProcedureName,
            object parameters)
        {
            using (
                SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings.Get(connectionName.ToString())))
            {
                var flag = false;

                try
                {
                    conn.Open();
                    List<TResult> result =
                        conn.Query<TResult>(storeProcedureName, parameters, commandType: CommandType.StoredProcedure)
                            .ToList();
                    conn.Close();

                    flag = true;

                    return result;
                }
                catch
                {
                    conn.Close();

                    return (List<TResult>) Convert.ChangeType(null, typeof (TResult));
                }
                finally
                {
                    if (!flag)
                    {
                        conn.Close();
                    }
                }
            }
        }
    }
}