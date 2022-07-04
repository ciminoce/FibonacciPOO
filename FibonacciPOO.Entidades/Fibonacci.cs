using System;
using System.Text;

namespace FibonacciPOO.Entidades
{
    public class Fibonacci
    {
        private int n;
        private int[] terminos;
        
        public int GetN => n;

        public Fibonacci():this(10)
        {
            //n = 10;
        }
        public Fibonacci(int cantidad)
        {
            n = cantidad;
        }

        public bool Validar()
        {
            return n >= 2;
        }

        private void GenerarTerminos()
        {
            terminos=new int[n];
            terminos[0] = 0;
            terminos[1] = 1;
            for (int i = 2; i < terminos.Length; i++)
            {
                terminos[i] = terminos[i - 2] + terminos[i - 1];
            }

        }

        public string MostrarSerie()
        {
            GenerarTerminos();
            StringBuilder sb=new StringBuilder();
            foreach (var termino in terminos)
            {
                sb.Append($"{termino} ");
            }

            return sb.ToString();
        }

        public int GetPosicion(int termino)
        {
            return Array.IndexOf(terminos, termino);
        }
        public int GetTermino(int posicion)
        {
            if (posicion<0 || posicion>=n)
            {
                throw new Exception("Posición fuera del rango");
            }

            return terminos[posicion];
        }

        public string MostrarTerminosDecreciente()
        {
            var terminosCopia = new int[n];
            Array.Copy(terminos,terminosCopia,terminos.Length);
            Array.Reverse(terminosCopia);
            return this.MostrarSerie(terminosCopia);
        }

        public string MostrarSerie(int[]array)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var termino in array)
            {
                sb.Append($"{termino} ");
            }

            return sb.ToString();
        }

        public int GetCantidadQueSeRepite(int termino)
        {
            var cantidad = Array.FindAll(terminos, n=>n==termino);
            return cantidad.Length;
        }
    }
}
