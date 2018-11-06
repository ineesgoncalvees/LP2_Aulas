using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTest
{
    class Program
    {
        static void Main(string[] args)
        {            try {
                Console.Write("Insere um numero inteiro:");
                int i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Numero inserido:{i}");
            }
            catch (FormatException e)
            {
                Console.WriteLine(" Ocorreu o seguinte problema: " + e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(" Ocorreu o seguinte problema: " + e.Message);
            }            catch (Exception e)
            {
                Console.WriteLine(" Ocorreu o seguinte problema: " + e.Message);
            }            finally
            {
                Console.WriteLine("Obrigada por ter utilizado este programa.");
            }
        }
    }
}
