using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ado.net
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var sobj = new Student();
               //sobj.Savedata();
               sobj.update();
               sobj.GetDataSet();
               Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
           

        }
    }
}
