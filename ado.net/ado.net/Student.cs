using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ado.net
{
   public class Student
    {
        public SqlHelper sqlHelper;
        public string sqlQuery;
        public Student()
        {
            sqlHelper = new SqlHelper();
        }
        public void GetDataSet()
        {
            sqlQuery = "select * from [Table]";
            DataTable dt = sqlHelper.GetDataSet(sqlQuery);
            foreach(DataRow dr in dt.Rows)
            {
                Console.WriteLine(string.Format("Roll number: {0}\n Student Name:{1}\n", dr[0].ToString(), dr[1].ToString()));
            }
            dt.WriteXml("student.xls");
        }
        public void Getdata()
        {
            sqlQuery = "select * from [Table]";
            var sqlReader= sqlHelper.ExecuteQuery(sqlQuery);
            while(sqlReader.Read())
            {
               
                Console.WriteLine(string.Format("Roll number: {0}\n Student Name:{1}\n", sqlReader[0].ToString(), sqlReader[1].ToString()));
                //sqlReader.NextResult();
                
            }
            sqlReader.Close();
            //scalar method
            sqlQuery = "select count(*) from [Table]";
            var count = sqlHelper.ExecuteScalar(sqlQuery);
            Console.WriteLine("No of rows:{0}", count);
        }
        public void Savedata()
        {
            Console.WriteLine("Enter the Roll number:");
            int Rno = Convert.ToInt32(Console.ReadLine());
            sqlQuery = string.Format(@"insert into [Table] values ({0},'{1}',{2},'{3}')",Rno,"Shruti",45,"9424785");
            sqlHelper.ExecuteNonQuery(sqlQuery);
        }
        public void update()
        {
            Console.WriteLine("Enter the roll_no to insert:");
            int roll_no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the name to insert:");
            string name = Convert.ToString(Console.ReadLine());
            sqlHelper.update(roll_no,name);
        }
      
    }
}
