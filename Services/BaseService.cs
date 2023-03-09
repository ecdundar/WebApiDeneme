namespace BurulasWebApi.Services
{
    public abstract class BaseService
    {
        //ISmsService
        //TelekomSmsService : ISmsService
        //TurkcellSmsService : ISmsService
    }

    public abstract class BaseService<TD> : BaseService where TD : class, new()
    {
        private static TD _instance = null;
        private static object _objLock = new object();
        public static TD Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_objLock)
                    {
                        if (_instance == null)
                        {
                            _instance = new TD();
                        }
                    }
                }
                return _instance;
            }
        }

    }
}
