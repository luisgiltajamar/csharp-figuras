using System;


namespace Figuritas
{
   public class Rectangulo:Figura
    {
       public double H { get; set; }
       public double W { get; set; }

       public Rectangulo()
       {
       }

       public Rectangulo(double h, double w, String nombre = "Rectangulo",
           String descripcion = "Figura rectangular") :
               base(nombre, descripcion)
       {
           H = h;
           W = w;
       }

       public override double Area()
       {
           return H*W;
       }

        public override double Perimetro()
        {
            return 2*H + 2*W;
        }
    }
}
