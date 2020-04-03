using System;

namespace Consolita
{
   

    class multiplicacion
    {
        static void Main(string[] args)
        {
            int n2 = 0;
            int n = 0;
            int resultado = 0;
            int valor = 0;


            Console.Write("Diga el numero: ");
            n = int.Parse(Console.ReadLine());


            Console.WriteLine("Calculando el valor para {0}", n);


            for (n2 = 1; n2 <= 10; n2++)
                {
             
                    resultado = n * n2;

                    Console.WriteLine("{0} x {1} = {2}", n, n2, resultado);


                }
                    
                       

        }
    }
}
