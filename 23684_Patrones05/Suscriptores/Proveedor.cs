using System;
namespace _Patrones05.Suscriptores
{
    public class Proveedor
    {
        public Proveedor()
        {
            Paquete1 DHL = new Paquete1();
            Paquete2 FEDEX = new Paquete2();
            Paquete3 CoMex = new Paquete3();
        }
    }
}
