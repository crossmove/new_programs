using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *Dependency Injection (DI) is a software design pattern that allow us to develop loosely coupled code.
 *
 * Suppose your Client class needs to use a Service class component, then the best you can do is to 
 * make your Client class aware of an IService interface rather than a Service class. In this way, 
 * you can change the implementation of the Service class at any time (and for how many times you want)
 * without breaking the host code.
 * There are 3 types of Dependency Injection
 * 1. Constructor Injection
 * 2. Property injection or Setter Injection
 * */
namespace DesignPatterns
{

    public interface IService
    {
        void Serve();
    }

    public class Service : IService
    {
        public void Serve()
        {
            Console.WriteLine("Service Called");
            //To Do: Some Stuff
        }
    }

    #region 1ConstructorInjection
    public class ConstructorInjection
    {
        private IService _service;

        public ConstructorInjection(IService service)
        {
            this._service = service;
        }

        public void Start()
        {
            Console.WriteLine("Service Started");
            this._service.Serve();
            //To Do: Some Stuff
        }
    }
    class Program
    {
        static void Method(string[] args)
        {
            ConstructorInjection client = new ConstructorInjection(new Service());
            client.Start();

            Console.ReadKey();
        }
    }

    #endregion 1ConstructorInjection

    #region 2ProperyInjection
    public class Client_PropertyInjection
    {
        private IService _service;

        public IService Service
        {
            set
            {
                this._service = value;
            }
        }

        public void Start()
        {
            Console.WriteLine("Service Started");
            this._service.Serve();
            //To Do: Some Stuff
        }
    }
    
#endregion 2ProperyInjection

    #region 3MethodInjection
    public class Client_MethodInjection
    {
        private IService _service;

        public void Start(IService service)
        {
            this._service = service;
            Console.WriteLine("Service Started");
            this._service.Serve();
            //To Do: Some Stuff
        }
    }
    class Program1
    {
        static void Method(string[] args)
        {
            Client_MethodInjection client = new Client_MethodInjection();
            client.Start(new Service());

            Console.ReadKey();
        }
    }
    #endregion 3MethodInjection
}
