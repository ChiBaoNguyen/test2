using System;

namespace WebAPI_MVC.Root.Data.Infrastructure
{
    public class Disposable : IDisposable
    {
        private bool _isDisposed;

        ~Disposable()
        {
            Dispose(false);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private void Dispose(bool disposing)
        {
            if(!_isDisposed && disposing)
            {
                DisposeCore();
            }
        }
        protected virtual void DisposeCore() { }
    }
}
