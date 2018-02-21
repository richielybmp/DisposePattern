using System;
using System.IO;

namespace DisposePattern
{
    class MyClass : IDisposable
    {
        StreamReader reader;
        bool disposed = false;

        public MyClass(string caminho)
        {
            // Pode disparar uma exeção se o não tiver permissão para acessar o caminho.
            reader = new StreamReader(caminho);
        }
        
        //Finalizer / Destructor
        ~MyClass()
        {
            Dispose(false);
        }
        // Flag: Check if dispose method has already been called?
        // type uses unmanaged resource
        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                if (reader != null)
                    reader.Dispose();
                // Free any other managed objects here.
            }
            // Free any unmanaged objects here.
            disposed = true;
        }
    }
}
