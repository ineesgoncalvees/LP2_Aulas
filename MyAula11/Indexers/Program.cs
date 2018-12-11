using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            MyVector vetor = new MyVector(1,0);

            Console.WriteLine(vetor.X);
            Console.WriteLine(vetor.Y);

            vetor[0] = 2;
            vetor[1] = 2;

            Console.WriteLine(vetor.X);
            Console.WriteLine(vetor.Y);

            vetor["a"] = 3;
            vetor["y"] = 3;

            Console.WriteLine(vetor.X);
            Console.WriteLine(vetor.Y);
        }
    }
}
