using Ces.Sch.Data;
using Ces.Sch.Data.Interfaces;
using Microsoft.Practices.Unity;

namespace Ces.Sch.Data.DependencyInversion
{
    public class DataDIConfig
    {
        private static IUnityContainer Container { get; }

        static DataDIConfig()
        {
            Container = new UnityContainer();

            /* ****************************************************** */
            /*            Repository Registrations                    */
            /* ****************************************************** */

            Container.RegisterType<IStudentRepository, StudentRepository>();
            Container.RegisterType<ISubjectRepository, SubjectRepository>();

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