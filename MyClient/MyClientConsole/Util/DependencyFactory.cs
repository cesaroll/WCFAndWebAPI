using Microsoft.Practices.Unity;
using MyClientConsole.MySrvRefOnIIS;

namespace MyClientConsole.Util
{
    internal static class DependencyFactory
    {
        public static IUnityContainer UnityContainer { get; set; }

        static DependencyFactory()
        {
            var container = new UnityContainer();

            container.RegisterType<IMyService, MyServiceClient>(new InjectionConstructor());

            UnityContainer = container;
        }

        public static T Resolve<T>()
        {
            T ret = default(T);

            if (UnityContainer.IsRegistered(typeof(T)))
            {
                ret = UnityContainer.Resolve<T>();
            }

            return ret;

        }

    }
}