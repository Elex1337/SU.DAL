using SU.BLL;
using SU.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SU.Online.Web
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.Email = "alexnurbolat@gmail.com";
            client.Password = "asd";
            client.FName = "Zhursinbek";
            client.SName = "Nurbolat";
            

            ServiceClient service = new ServiceClient();
            service.RegisterClient(client);
        }
    }
}
