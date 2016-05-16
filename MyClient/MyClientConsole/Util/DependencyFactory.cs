﻿using Microsoft.Practices.Unity;
using MyClientConsole.MyServiceReference;

namespace MyClientConsole.Util
{
    internal static class DependencyFactory
    {
        public static IUnityContainer UnityContainer { get; set; }

        static DependencyFactory()
        {
            var container = new UnityContainer();

            

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