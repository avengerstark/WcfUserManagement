using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfTesting.ServiceReference;

namespace WcfTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            
            User user = new User {id=4, FirstName="Tony1f", LastName="Stark1df", DOB=DateTime.Now, Gender="Male"};
            UserServiceClient client = new UserServiceClient();
            try
            {
                var x = client.Get(4).FirstName;
                Console.WriteLine(x.Length);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                client.Close();
            }
            Console.ReadKey();
        }
    }
}
