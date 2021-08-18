using System;

namespace Azar
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int cons = rand.Next(0, 101);
            Console.WriteLine("Ingrese un numero: ");
            int valor = Convert.ToInt32(Console.ReadLine());
            if (cons > valor)
            {
                Console.WriteLine("Es mayor");
            }
            if(valor > cons){
                Console.WriteLine("Es menor");
            }
            if(valor==cons)
            {
                Console.WriteLine("FELICITACIONES");
            }
        }
    }
}
