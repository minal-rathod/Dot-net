using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ado.net
{
    public class SqlHelper
    {
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        public string sqlQuery = null;
        private SqlDataAdapter sqlDataAdapter;

        public string conString = @"Data Source=.\SQLExpress;Initial Catalog=SampleDatabase;User ID=sa;Password=xoriant123#;Pooling=False";
        public SqlHelper()
        {
            sqlConnection = new SqlConnection(conString);
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open(); //connection to database
            Console.WriteLine("Connection is open");
        }

        public DataTable GetDataSet(string sqlQuery)
        {
            var ds = new DataSet();
            sqlDataAdapter = new SqlDataAdapter(sqlQuery, conString);
            sqlDataAdapter.Fill(ds, "student");// table_name-->student
            return ds.Tables[0];
        }
        public void update(int rno, string sname)
        {
            sqlQuery = @"select * from [Table]";
            var ds = new DataSet();
            sqlDataAdapter = new SqlDataAdapter(sqlQuery, conString);
            SqlCommandBuilder sb = new SqlCommandBuilder(sqlDataAdapter);
            sqlDataAdapter.Fill(ds, "student");

            DataTable dt = ds.Tables[0];
            dt.Rows[0][0] = rno;
            dt.Rows[0][1] = sname;
            sqlDataAdapter.Update(dt);
        }


        // Execute query
        public SqlDataReader ExecuteQuery(string sqlQuery)
        {
            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            //sqlCommand.CommandText = sqlQuery;
            //sqlCommand.Connection = sqlConnection; // setting connection
            return sqlCommand.ExecuteReader();
        }
        public string ExecuteScalar(string sqlQuery)
        {
            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            return sqlCommand.ExecuteScalar().ToString();
        }
        public bool ExecuteNonQuery(string sql)
        {
            var result = false;
            sqlCommand = new SqlCommand(sql, sqlConnection);
            var count = sqlCommand.ExecuteNonQuery();
            result = count > 0 ? true : false;
            return result;
        }
    }  
    
}
