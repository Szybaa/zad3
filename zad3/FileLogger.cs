using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using zad3.Logger;

using System.IO;



public class FileLogger : WriterLogger
{
    private bool disposed;
    protected FileLogger stream;
    public String path;

    public FileLogger()
    {
        TextWriter writer;
        FileStream stream = new FileStream("plik-1.txt", FileMode.Append);
        writer = new StreamWriter(stream, Encoding.UTF8);
        writer.Write("Wiadomosc do logowania ...");
        writer.Flush();

    }



    ~FileLogger()
    {
        this.Dispose(false);
    }

    protected virtual void Dispose(bool disposing)
    {

    }


    public override void Dispose()
    {
        throw new NotImplementedException();
    }
}

