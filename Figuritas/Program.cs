using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuritas
{
    class Program
    {
        static void Main(string[] args)
        {

            Figura[] f;
            Console.Write("Cuantas figuras quieres?");
            int n = 0;
            int.TryParse(Console.ReadLine(), out n);
            f=new Figura[n];

            for (int i = 0; i < f.Length; i++)
            {
                Console.Write("Tipo de figura c/r:");
                var r = Console.ReadLine();

                if (r == "c")
                    f[i] = CrearCirculo();
                else
                    f[i] = CrearRectangulo();

            }


            foreach (var figura in f)
            {
                Console.WriteLine("Un {0} con area {1:N2}",
                   figura.Nombre, figura.Area());
            }

            Console.ReadLine();
        }

        private static Circulo CrearCirculo()
        {
            double r = 0;

            Console.Write("Radio del circulo:");
            double.TryParse(Console.ReadLine(), out r);

            return new Circulo(r);
        }
        private static Rectangulo CrearRectangulo()
        {
            double w = 0,h=0;

            Console.Write("Ancho del rectangulo:");
            double.TryParse(Console.ReadLine(), out w);

            Console.Write("Alto del rectangulo:");
            double.TryParse(Console.ReadLine(), out h);
            return new Rectangulo(h,w);
        }
    }
}
