using System;
namespace _Patrones05.Paquetes
{
    public interface Timer : Paquetes
    {
        Timer timer = new Timer(1000);
        timer.Elapsed += async(sender, e ) => await HandleTimer();
        timer.Start();
      Console.Write("Press any key to exit... ");
      Console.ReadKey();
    }
}
