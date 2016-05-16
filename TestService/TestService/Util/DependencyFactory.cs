using DataLib.Factory;
using Microsoft.Practices.Unity;
using ModelLib.Util;

namespace TestService.Util
{
    public class DependencyFactory
    {
        public static IUnityContainer UnityContainer { get; set; }

        static DependencyFactory()
        {
            var container = new UnityContainer();

            container.RegisterType<ICountryFactory, CountryFactory>();
            
            UnityContainer = container;

        }

        public static T Resolve<T>()
        {
            T ret = default(T);

            if (UnityContainer.IsRegistered(typeof (T)))
            {
                ret = UnityContainer.Resolve<T>();
            }

            return ret;

        }

    }
}