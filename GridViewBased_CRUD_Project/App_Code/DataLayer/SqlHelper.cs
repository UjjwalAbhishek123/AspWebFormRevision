using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GridViewBased_CRUD_Project.App_Code.DataLayer
{
    public static class SqlHelper
    {
        public static string ConnectionString { get { return ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString; } }

        //Execute non query command (insert/update/delete => return no data)
        public static int ExecuteNonQuery(string connectionString, CommandType commandType, string commandText, SqlParameter[] commandParameter)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(commandText, con))
                {
                    cmd.CommandType = commandType;
                    if (commandParameter != null)
                    {
                        cmd.Parameters.AddRange(commandParameter);
                    }
                    con.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        //Execute dataset (select / update returning datatable)
        public static DataSet ExecuteDataSet(string connectionString, CommandType commandType, string commandText, SqlParameter[] commandParameter)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(commandText, con))
                {
                    cmd.CommandType = commandType;
                    if (commandParameter != null)
                    {
                        cmd.Parameters.AddRange(commandParameter);
                    }
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        return ds;
                    }
                }
            }
        }
    }
}