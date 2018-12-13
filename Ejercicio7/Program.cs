using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        const int MAX = 10;
        static void Main(string[] args)
        {
            int[] X = new int[MAX];
            string[] nombres = new string[MAX];

            LEER(X);
            impirmir(X);

            if (buscar(X, 15) == true)
            {
                Console.Write("\n 15 Numero encontrado");
            }
            else
            {
                Console.Write("\n 15 No Existe");
            }
            if (buscar2(X, 20) == true)
            {
                Console.Write("\n 20 Numero encontrado");
            }
            else
            {
                Console.Write("\n 20 No Existe");
            }
            //TRABAJANDO CON EL VECTOR DE NOMBRES 
            Console.Write("\n Ingrese los nombres");
            LEERNOMBRES(nombres);
            impirmirNOMBRES(nombres);

            Console.ReadKey();
        }

        public static void LEER(int[] X)
        {
            for (int i = 0; i < MAX; i++)
            {
                Console.WriteLine("Ingrese el elemento{0}", i + 1);
                X[i] = Int32.Parse(Console.ReadLine());


            }

        }

        public static void impirmir(int[] X)
        {
            foreach (int num in X)
            {
                Console.WriteLine($"Elementos:{num}");

            }
        }

        public static bool buscar(int[] X, int y)
        {
            bool encontrado = false;
            foreach (int num in X)
            {
                if (num == y)
                {
                    encontrado = true;
                    break;
                }
            }
            return encontrado;
        }
        public static bool buscar2(int[] X, int y)
        {
            bool encontado = false;
            int i = 0;
            while (i < MAX && encontado == false)
            {
                if (X[i] == y)
                    encontado = true;
                i++;

            }
            return encontado;
        }
        public static void LEERNOMBRES(string[] X)
        {
            for (int i = 0; i < MAX; i++)
            {
                Console.WriteLine("Ingrese el elemento{0}", i + 1);
                X[i] = Console.ReadLine();


            }

        }
        public static void impirmirNOMBRES(string[] X)
        {
            foreach (string num in X)
            {
                Console.WriteLine($"Elementos:{num}");

            }


        }
    }
}
