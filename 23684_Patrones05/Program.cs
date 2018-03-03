using System;

namespace _Patrones05
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Client1 client1 = new Client1();
            Client2 client2 = new Client2();
            Client3 client3 = new Client3();

            dhlData DHLData = new dhlData();
            fedexData FEDEXData = new fedexData();
            CorreosDeMexico CORREOSDEMexico = new CorreosDeMexico();

            DHLData.add(client1);
            DHLData.add(client2);
            DHLData.add(client3);

            FEDEXData.add(client1);
            FEDEXData.add(client2);

            CORREOSDEMexico.add(client2);

            DHLData.updatePackageInfo();
            FEDEXData.updatePackageInfo();
            CORREOSDEMexico.updatePackageInfo();
        }
    }
}