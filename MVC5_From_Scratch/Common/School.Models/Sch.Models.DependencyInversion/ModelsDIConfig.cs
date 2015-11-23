using Ces.Sch.Models;
using Ces.Sch.Models.Interfaces;
using Microsoft.Practices.Unity;

namespace Ces.Sch.Models.DependencyInversion
{
    public class ModelsDIConfig
    {
        private static IUnityContainer Container { get; }

        static ModelsDIConfig()
        {
            Container = new UnityContainer();

            /* ****************************************************** */
            /*               Model Registrations                      */
            /* ****************************************************** */

            Container.RegisterType<IStudent, Student>();
            Container.RegisterType<ISubject, Subject>();

        }

        public static T Resolve<T>()
        {
            T ret = default(T);

            if (Container.IsRegistered(typeof(T)))
            {
                ret = Container.Resolve<T>();
            }

            return ret;
        }

        public static T Resolve<T>(string name)
        {
            T ret = default(T);

            if (Container.IsRegistered(typeof(T), name))
            {
                ret = Container.Resolve<T>(name);
            }

            return ret;
        }
    }
}