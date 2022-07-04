using System;
using FibonacciPOO.Entidades;

namespace FibonacciPOO.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var fibonacci = new Fibonacci();
                if (fibonacci.Validar())
                {
                    Console.WriteLine(fibonacci.MostrarSerie());
                    var index = 5;
                    Console.WriteLine(fibonacci.GetTermino(index));

                    Console.WriteLine(fibonacci.MostrarTerminosDecreciente());
                    var posicion = fibonacci.GetPosicion(1);
                    Console.WriteLine($"1 se encuentra en la posicion {posicion}");
                    var cantidad = fibonacci.GetCantidadQueSeRepite(1);
                    Console.WriteLine($"1 aparece {cantidad} veces");
                }
                else
                {
                    Console.WriteLine("Objeto no válido...");
                }

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
