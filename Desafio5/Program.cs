using System;
namespace Desafio5
{
    class Program
    {
        static void Main(string[] args)
        {
                    

    


            double n1, n2;
            n1 = Convert.ToDouble(Console.ReadLine());
            n2 = Convert.ToDouble(Console.ReadLine());
          


                double m = (n1 / 11 * 3.5) + (n2 / 11 *7.5 );
                
                Console.Write("MEDIA = "+m.ToString("0.00000"));
                Console.WriteLine();
                

            }
        }
    }
