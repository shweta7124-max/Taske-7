using InterfacesDemo.Interfaces;

namespace InterfacesDemo.Classes;

public class MultiFunctionDevice : IPrinter, IScanner
{
    void IPrinter.Start()
    {
        Console.WriteLine("Printer is starting...");
    }

    void IScanner.Start()
    {
        Console.WriteLine("Scanner is starting...");
    }
}