using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            customException dobj = new customException();
            dobj.divide();
        }
    }
}
