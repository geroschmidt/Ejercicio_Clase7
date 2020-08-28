using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_propuesto_profesorArce
{
    class Program
    {
        static void Main(string[] args)


            
        {
            int cantidad = 0;
            int n = 0;
            float promedio = 0.0f;
            float suma = 0.0f;
            float minima = 10.0f;
            float maxima = 0.0f;


            Console.WriteLine("Ingrese la cantidad de alumnos: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            float[] calificaciones = new float[cantidad];

            //Carga de calificaciones
            for(n=0; n < cantidad; n++)
            {
                Console.Clear();


                Console.WriteLine("Ingrese la {0} calificacion.", n+1);
                calificaciones[n] = Convert.ToSingle(Console.ReadLine());

            }

            //Suma de calificaciones
            for (n=0;n<cantidad; n++)
            {
                suma += calificaciones[n];
            }

            //PROMEDIO

            promedio = suma / cantidad;

            n = 0;

            //Calificacion minima y maxima
            for (n = 0; n < cantidad; n++)
            {
                if (calificaciones[n] < minima)
                {
                    minima = calificaciones[n];
                }

                if (calificaciones[n] > maxima)
                {
                    maxima = calificaciones[n];
                }

            }

            //Mostrar promedio minima y maxima
            Console.Clear();
            Console.WriteLine("El promedio de las calificaciones es: " + promedio);
            Console.WriteLine("La calificacion maxima obtenida fue: " + maxima);
            Console.WriteLine("La calificacion minima obtenida fue: " + minima);

            Console.ReadKey();
        }
    }
}
