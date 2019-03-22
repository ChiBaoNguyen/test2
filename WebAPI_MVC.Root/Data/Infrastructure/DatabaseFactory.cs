namespace WebAPI_MVC.Root.Data.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private Test1DBContext _dataContext;

        public Test1DBContext Get()
        {
            return _dataContext ?? (_dataContext = new Test1DBContext());
        }

        protected override void DisposeCore()
        {
            if (_dataContext != null)
            {
                _dataContext.Dispose();
            }
        }
    }
}
