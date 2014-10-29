using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuritas
{
   public abstract class Figura
    {
       public String Nombre { get; set; }
       public String Descripcion { get; set; }

       protected Figura()
       {
       }

       protected Figura(String nombre, String descripcion)
       {
           Nombre = nombre;
           Descripcion = descripcion;
       }

       public abstract double Area();
       public abstract double Perimetro();

    }
}
