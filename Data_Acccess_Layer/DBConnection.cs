using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Data_Acccess_Layer
{
    public class DBConnection
    {
        string ConnStr =
            "Data Source=OCEAN;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataAdapter da = null;

        private SqlDataAdapter myAdapter;
        public DBConnection()
        {
            conn = new SqlConnection(ConnStr);
            myAdapter = new SqlDataAdapter();
            comm = conn.CreateCommand();
        }
        public DataSet ExecuteQueryDataSet(
            string strSQL,
            CommandType ct,
            params SqlParameter[] p)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();

            comm.CommandType = ct;
            comm.CommandText = strSQL;

            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }


        public bool MyExecuteNonQuery(
            string strSQL,
            CommandType ct,
            ref string error,
            params SqlParameter[] param)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();

            comm.Parameters.Clear();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            foreach (SqlParameter p in param)
                comm.Parameters.Add(p);

            try
            {
                comm.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }

        //bs//////////////////////
        private SqlConnection openConnection()
        {
            if (conn.State == ConnectionState.Closed || conn.State ==
                        ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }
        public bool executeInsertQuery(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();
            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParameter);
                myAdapter.InsertCommand = myCommand;
                myCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeInsertQuery - Query: "
                    + _query + " \nException: \n" + e.StackTrace.ToString());
                return false;
            }
            finally
            {
            }
            return true;
        }
        public DataTable executeSelectQuery(String _query, SqlParameter sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();
            DataTable dataTable = new DataTable();
            dataTable = null;
            DataSet ds = new DataSet();
            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _query;
                myCommand.CommandType = CommandType.StoredProcedure;

                //myCommand.Parameters.AddRange(sqlParameter);
                myCommand.Parameters.Add(sqlParameter);
                myCommand.ExecuteNonQuery();
                myAdapter.SelectCommand = myCommand;
                myAdapter.Fill(ds);
                dataTable = ds.Tables[0];
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeSelectQuery - Query: "
                    + _query + " \nException: " + e.StackTrace.ToString());
                return null;
            }
            finally
            {

            }
            return dataTable;
        }
        public DataTable executeSelectQueryParamArray(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();
            DataTable dataTable = new DataTable();
            dataTable = null;
            DataSet ds = new DataSet();
            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _query;
                myCommand.CommandType = CommandType.StoredProcedure;

                myCommand.Parameters.AddRange(sqlParameter);
                myCommand.ExecuteNonQuery();
                myAdapter.SelectCommand = myCommand;
                myAdapter.Fill(ds);
                dataTable = ds.Tables[0];
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeSelectQuery - Query: "
                    + _query + " \nException: " + e.StackTrace.ToString());
                return null;
            }
            finally
            {

            }
            return dataTable;
        }

        public DataTable executeSelectQueryNoParam(String _query)
        {
            SqlCommand myCommand = new SqlCommand();
            DataTable dataTable = new DataTable();
            dataTable = null;
            DataSet ds = new DataSet();
            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _query;
                //myCommand.Parameters.AddRange(sqlParameter);
                myCommand.ExecuteNonQuery();
                myAdapter.SelectCommand = myCommand;
                myAdapter.Fill(ds);
                dataTable = ds.Tables[0];
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeSelectQuery - Query: "
                    + _query + " \nException: " + e.StackTrace.ToString());
                return null;
            }
            finally
            {

            }
            return dataTable;
        }
        //goi procedure lay table
        public DataTable executeGetTable(String _query)
        {
            SqlCommand myCommand = new SqlCommand();
            DataTable dt = new DataTable();
            try
            {
                myCommand = new SqlCommand(_query,conn);
                myCommand.CommandType= CommandType.StoredProcedure;
                myAdapter = new SqlDataAdapter(myCommand);
                myAdapter.Fill(dt);
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeSelectQuery - Query: "
                    + _query + " \nException: " + e.StackTrace.ToString());
                return null;
            }
            finally
            {

            }
            return dt;
        }
        /*
        //goi procedure lay table bang ma(co parameter)
        public DataTable executeGetTableByID(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();
            DataTable dataTable = new DataTable();
            dataTable = null;
            DataSet ds = new DataSet();
            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParameter);
                myCommand.ExecuteNonQuery();
                myAdapter.SelectCommand = myCommand;
                myAdapter.Fill(ds);
                dataTable = ds.Tables[0];
            }




            SqlCommand myCommand = new SqlCommand();
            DataTable dt = new DataTable();
            try
            {

                myCommand = new SqlCommand(_query, conn);
    
                myCommand.CommandType = CommandType.StoredProcedure;
                myAdapter = new SqlDataAdapter(myCommand);
                myAdapter.Fill(dt);
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeSelectQuery - Query: "
                    + _query + " \nException: " + e.StackTrace.ToString());
                return null;
            }
            finally
            {

            }
            return dt;
        }
         */
        //chinh sua, lay datatable tu function sql
        public int MyExecuteQueryReturnInt(
            string strSQL,
            CommandType ct,
            ref string error)
        {
            comm = new SqlCommand("select dbo."+strSQL+"()", conn);
            da = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int soluong = Convert.ToInt32(dt.Rows[0][0]); //ở đây giá trị trả về là so luong             
            return soluong;
        }
    }
}
