using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Learning
{
    internal class Methods
    {
        static void Greet(string name)
        {
            Console.WriteLine($"Good Morning" + name);
        }

        static float Average(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum / 3;
        }
        static float Average(int a, int b)
        {
            return (a + b) / 2;
        }

        
        static void Main(string[] args)
        {
            Greet("Harry");
            Greet("lorry");
            Console.WriteLine(Average(2, 4, 6));
            float TempFile = Average(2, 4, 6);
            Console.WriteLine(TempFile);
            Console.WriteLine(Average(4,6));
        }
    }
}
