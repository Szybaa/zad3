using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace zad3.Logger
{
    public abstract class WriterLogger : ILogger
    {
        protected TextWriter writer;

        public virtual void Log(params string[] messages)
        {
            Log("text 1", "text 2", "text N", "", "", "");


        }

        public abstract void Dispose();
    }
}