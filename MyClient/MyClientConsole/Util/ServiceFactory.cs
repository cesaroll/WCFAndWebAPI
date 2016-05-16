namespace MyClientConsole.Util
{
    internal static class ServiceFactory
    {
        public static MySrvRefOnIIS.CountriesServiceClient GetMainService()
        {
            return new MySrvRefOnIIS.CountriesServiceClient();
        }

        public static MyServiceReference.CountriesServiceClient GetDebugService()
        {
            return new MyServiceReference.CountriesServiceClient();
        }
         
    }
}