using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_7_pag192
{
    class Program
    {
        // Esta es la funcion principal de programa
        // Aqui inica la aplicacion
        static void Main(string[] args)
        {
            int cantidad = 0; // Cant de alumnos
            int n = 0; // Variable de control de ciclo
            String valor = "";

            // Variables para el promedio

            float suma = 0.0f;
            float promedio = 0.0f;

            float minima = 10.0f; // Variable para la clasificacion minima
            float maxima = 0.0f; // Variable pata la clasificacion maxima

            // Pedimos la cantidad de alumnos

            Console.WriteLine("Dame la cantidad de alumnos");
            valor = Console.ReadLine();
            cantidad = Convert.ToInt32(valor);

            // Creamos el arreglo

            float[] calif = new float[cantidad];

            // Capturamos la enformacion
            for (n = 0; n < cantidad; n++)
            {
                Console.WriteLine("Dame la calificacion");
                valor = Console.ReadLine();
                calif[n] = Convert.ToSingle(valor);
            }

            // Encontramos el promedio

            for (n = 0; n < cantidad; n++)
            {
                suma += calif[n];
            }
            promedio = suma / cantidad;

            // Encontramos la calificacion minima

            for (n = 0; n < cantidad; n++)
            {
                if (calif[n] < minima)
                    minima = calif[n];
            }

            // Encontramos la calificacion maxima

            for (n = 0; n < cantidad; n++)
            {
                if (calif[n] > maxima)
                    maxima = calif[n];
            }
            
            // Deplegamos los resultados

            Console.WriteLine("El promedio es {0}", promedio);
            Console.WriteLine("La calificacion minima es {0}", minima);
            Console.WriteLine("La calificacion maxima es {0}", maxima);
            Console.ReadKey();

        } // Cierre de main
    } // Cierre de la clase 
}
