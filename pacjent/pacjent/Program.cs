using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pacjent
{
    class Program
    {
        static void Main(string[] args)
        {
            Pacjent pacjent1 = new Pacjent("Adam", "po", 19);
            pacjent1.WypiszInfo();
            Console.ReadKey();

        }
    }
}
