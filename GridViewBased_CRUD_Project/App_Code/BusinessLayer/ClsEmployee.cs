using GridViewBased_CRUD_Project.App_Code.AbstractLayer;
using GridViewBased_CRUD_Project.App_Code.DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GridViewBased_CRUD_Project.App_Code.BusinessLayer
{
    public class ClsEmployee : ClsAbsEmployee, IDisposable
    {
        public void Dispose()
        {
            //Dispose any resource if needed
        }

        public DataSet GetAllEmployees()
        {
            try
            {
                SqlParameter[] Param = new SqlParameter[0];

                DataSet ds = SqlHelper.ExecuteDataSet(SqlHelper.ConnectionString, CommandType.StoredProcedure, "usp_GetAllEmployee", Param);

                return ds;
            }
            catch (Exception ex)
            {
                //Handle exception as needed
                throw ex;
            }
        }

        //INSERT - (void method)
        public void InsertEmployeeDetails()
        {
            try
            {
                SqlParameter[] Param = new SqlParameter[3];
                Param[0] = new SqlParameter("@EmpName", EmpName);
                Param[1] = new SqlParameter("@Department", Department);
                Param[2] = new SqlParameter("@Salary", Salary);

                SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "usp_InsertEmployee", Param);
            }
            catch (Exception ex)
            {
                //Handle exception as needed
                throw ex;
            }
        }

        //UPDATE - (returns DataTable)
        public DataTable UpdateEmployeeDetails()
        {
            try
            {
                SqlParameter[] Param = new SqlParameter[4];
                Param[0] = new SqlParameter("@EmpId", EmpId);
                Param[1] = new SqlParameter("@EmpName", EmpName);
                Param[2] = new SqlParameter("@Department", Department);
                Param[3] = new SqlParameter("@Salary", Salary);

                DataTable dt = SqlHelper.ExecuteDataSet(SqlHelper.ConnectionString, CommandType.StoredProcedure, "usp_UpdateEmployee", Param).Tables[0];

                return dt;
            }
            catch (Exception ex)
            {
                //Handle exception as needed
                throw ex;
            }

        }

        //DELETE - (void method)
        public void DeleteEmployeeDetails()
        {
            try
            {
                SqlParameter[] Param = new SqlParameter[1];
                Param[0] = new SqlParameter("@EmpId", EmpId);

                SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "usp_DeleteEmployee", Param);
            }
            catch (Exception ex)
            {
                //Handle exception as needed
                throw ex;
            }
        }
    }
}