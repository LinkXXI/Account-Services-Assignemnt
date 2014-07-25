using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using AccountLib;

namespace AccountSvc
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost selfhost = null;

            try
            {
                selfhost = new ServiceHost(typeof(ServiceAccount));

                selfhost.Open();

                Console.WriteLine("The Service is Running!");
            }
            catch (EndpointNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Press any key to end service");
            Console.ReadKey();

            selfhost.Close();
        }
    }
}
