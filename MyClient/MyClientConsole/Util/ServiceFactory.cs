namespace MyClientConsole.Util
{
    public static class ServiceFactory
    {
        public static MySrvRefOnIIS.CountriesServiceClient GetMainService()
        {
            return new MySrvRefOnIIS.CountriesServiceClient();
        }
         
    }
}