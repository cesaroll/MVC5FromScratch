using Microsoft.Practices.Unity;
using Models.Interfaces;
using Models.Models;

namespace Repo.Config
{
    public class UnityConfig
    {
        private static UnityConfig _uniqueInstance { get; set; }
        private IUnityContainer Container { get; set; }

        private UnityConfig()
        {
            Container = new UnityContainer();

            /* ****************************************************** */
            /*               Model Registrations                      */
            /* ****************************************************** */

            Container.RegisterType<IStudent, Student>();
            Container.RegisterType<ISubject, Subject>();

        }

        public static UnityConfig getInstance()
        {
            if(_uniqueInstance == null)
                _uniqueInstance = new UnityConfig();

            return _uniqueInstance;

        }

        public T Resolve<T>()
        {
            T ret = default(T);

            if (Container.IsRegistered(typeof(T)))
            {
                ret = Container.Resolve<T>();
            }

            return ret;
        }

        public T Resolve<T>(string name)
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