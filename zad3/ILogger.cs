using System;
using System.Collections.Generic;
using System.Text;

namespace zad3.Logger
{
    public interface ILogger : IDisposable
    {
        void Log(params String[] messages);
    }
}