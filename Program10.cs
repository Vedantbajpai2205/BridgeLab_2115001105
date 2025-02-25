using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflection
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Method)]
    public class InjectAttribute : Attribute
    {
    }

    public interface IDatabaseService
    {
        void Connect();
    }

    public class DatabaseService : IDatabaseService
    {
        public void Connect()
        {
            Console.WriteLine("Connected to Database!");
        }
    }

    public interface IUserService
    {
        void CreateUser(string username);
    }

    public class UserService : IUserService
    {
        private readonly IDatabaseService _databaseService;

        public UserService(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public void CreateUser(string username)
        {
            _databaseService.Connect();
            Console.WriteLine($"User {username} created!");
        }
    }

    public class SimpleDIContainer
    {
        private readonly Dictionary<Type, object> _services = new Dictionary<Type, object>();
        private readonly Dictionary<Type, Func<object>> _factories = new Dictionary<Type, Func<object>>();

        public void Register<TService, TImplementation>()
            where TImplementation : TService
        {
            _factories[typeof(TService)] = () =>
            {
                var constructor = typeof(TImplementation).GetConstructors().First();
                var parameters = constructor.GetParameters();
                var parameterInstances = parameters
                    .Select(p => Resolve(p.ParameterType))
                    .ToArray();
                return constructor.Invoke(parameterInstances);
            };
        }

        public T Resolve<T>()
        {
            return (T)Resolve(typeof(T));
        }

        public object Resolve(Type serviceType)
        {
            if (_factories.ContainsKey(serviceType))
            {
                return _factories[serviceType]();
            }

            throw new Exception($"Service {serviceType} is not registered.");
        }

        public void InjectDependencies(object obj)
        {
            var properties = obj.GetType()
                                 .GetProperties()
                                 .Where(p => p.IsDefined(typeof(InjectAttribute), true));

            foreach (var property in properties)
            {
                var dependency = Resolve(property.PropertyType);
                property.SetValue(obj, dependency);
            }

            var methods = obj.GetType()
                             .GetMethods()
                             .Where(m => m.IsDefined(typeof(InjectAttribute), true));

            foreach (var method in methods)
            {
                var parameters = method.GetParameters();
                var parameterInstances = parameters
                    .Select(p => Resolve(p.ParameterType))
                    .ToArray();

                method.Invoke(obj, parameterInstances);
            }
        }
    }

    public class Application
    {
        [Inject]
        public IUserService UserService { get; set; }

        public void Run()
        {
            UserService.CreateUser("Yash");
        }
    }

    class Program11
    {
        static void Main()
        {
            var container = new SimpleDIContainer();

            container.Register<IDatabaseService, DatabaseService>();
            container.Register<IUserService, UserService>();

            var app = new Application();
            container.InjectDependencies(app);

            app.Run();
        }
    }


}
