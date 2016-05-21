using MEP.Logic;
using MEP.Logic.Contracts;
using Microsoft.Practices.Unity;

namespace MEP.ServiceLib.Util
{
    internal static class DependencyFactory
    {
        public static IUnityContainer UnityContainer { get; set; }

        static DependencyFactory()
        {
            var container = new UnityContainer();
            
            container.RegisterType<IEmailLogic, EmailLogic>();

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