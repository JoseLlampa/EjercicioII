using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioII
{
    class Program
    {
        static void Main(string[] args)
        {
            int registro = 1;
            int divisor;
            int count = 0;
            bool primo;
            bool divisible;

            while (registro < 321)
            {
                for (divisor = 1; divisor <= registro; divisor++)
                {
                    if (registro % divisor == 0)
                    {
                        count++;
                    }
                }


                if (count > 2)
                {
                    primo = false;
                }
                else
                {
                    primo = true;
                }

                if (registro % 3 == 0)
                {
                    divisible = true;
                }
                else
                {
                    divisible = false;
                }


                if ((primo == true) && (divisible == true))
                {
                    System.Console.WriteLine(registro + " es primo y divisible por 3");
                }
                else
                {
                    if (primo == true)
                    {
                        System.Console.WriteLine(registro + " es primo");
                    }
                    else
                    {
                        if (divisible == true)
                        {
                            System.Console.WriteLine(registro + " es divisible por 3");
                        }
                    }
                }

                registro++;
            }
        }
    }
}
