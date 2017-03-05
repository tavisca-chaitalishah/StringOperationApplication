using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOperationApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            StringOperationController StringOperator = new StringOperationController();
            StringOperator.StringOperation();
            Console.WriteLine("Thankyou\n\nPress any key to Exit the Application....");
            Console.ReadLine();
        }
    }
}
