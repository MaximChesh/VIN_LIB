using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIN_LIB;

namespace VIN_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Console.WriteLine(class1.CheckVIN("JHMCM56557C404453"));
            Console.WriteLine(class1.GetVINCountry("JHMCM55557CJ04453"));
            Console.ReadKey();
        }
    }
}
