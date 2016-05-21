using MEP.Logic.Contracts;
using Microsoft.Practices.Unity;

namespace MEP.Logic.Util
{
    internal static class DependencyFactory
    {
        public static IUnityContainer UnityContainer { get; set; }

        static DependencyFactory()
        {
            var container = new UnityContainer();

            container.RegisterType<IEmailLogic, EmailLogic>();
            container.RegisterType<IErrorLogic, ErrorLogic>();

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