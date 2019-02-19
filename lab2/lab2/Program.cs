using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int key, a, b, res;
            Console.WriteLine("Vvedite nomer komandi:\n1. Vvedite A \n2. Vvedite B\n3. Vvedite +\n4. Vvedite -\n5. Vvedite *\n6. Vvedite /");
            key = Console.Read();
            switch (key)
            {
                case 1: break;
                case 2: break;
                case 3: res = a + b; break;
                case 4: break;
                case 5: break;
                case 6: break;
                default: break;
            }
            Console.ReadKey();
        }
    }
}
