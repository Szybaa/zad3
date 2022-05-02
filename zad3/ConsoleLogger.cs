using System;
using System.Collections.Generic;
using System.Text;
using zad3;
using zad3.Logger;

public class ConsoleLogger : WriterLogger
{
    public ConsoleLogger()
    {
        writer = Console.Out;
    }
    public void consolelog()
    {

    }

    public override void Dispose()
    {
        throw new NotImplementedException();
    }
}
