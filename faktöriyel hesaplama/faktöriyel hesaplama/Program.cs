using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faktöriyel_hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                {
                    int i = 1;
                    Console.Write(" Faktöriyelini hesaplamak istediğiniz sayıyı gir: ");
                    double sayi = Convert.ToInt32(Console.ReadLine());
                    double faktoriyel = 1;
                    while (i <= sayi)
                    {
                        faktoriyel = faktoriyel * i;
                        i++;
                    }
                    Console.WriteLine(sayi + faktoriyel);
                    Console.ReadKey();
                }
            }
        }
    }
}
    
