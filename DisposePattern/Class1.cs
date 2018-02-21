using System;
using System.IO;

namespace DisposePattern
{
    class myClass : IDisposable
    {
        public myClass()
        {

        }
        // Flag: Check if dispose method has already been called?
        bool disposed = false;
        // type uses unmanaged resource
        StreamReader reader;
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

        //Finalizer a.k.a Destructor
        ~myClass()
        {
            Dispose(false);
        }
    }
}
