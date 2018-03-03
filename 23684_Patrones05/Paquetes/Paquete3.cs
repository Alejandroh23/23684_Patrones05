using System;
namespace _Patrones05.Paquetes
{
    public class Paquete3
    {
        private Entrega;
        private Recibe;
        private Actualiza;

        @override

          public void Actualiza(void Entrega, void Recibe, void Actualiza);
            this.Entrega = Entrega;
            this.Recibe = Recibe;
            this.Actualiza = Actualiza;
            this.show();
        }
        override
            public void muestra()
        {
            Console.WriteLine("Paquete3");
            Console.WriteLine(this.Entrega);
            Console.WriteLine(this.Recibe);
            Console.WriteLine(this.Actualiza);

        }
    }
