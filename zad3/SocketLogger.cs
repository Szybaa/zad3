using System.Net;
using System.Net.Sockets;
using zad3.Logger;
using System;


public class SocketLogger : ILogger
{

    private ClientSocket clientSocket;


    public SocketLogger(string host, int port)
    {
        clientSocket = new ClientSocket(host, port);
    }

    ~SocketLogger()
    {
        this.Dispose(false);
    }

    private void Dispose(bool v)
    {
        throw new NotImplementedException();
    }

    public virtual void Log(params string[] messages)
    {

    }






}