using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Services;
using SHDataService.Entities;


namespace SHDataService.Service {
    public class ServiceHost {
        public static void LaunchService(string baseAddress) {
            //MyDataServiceHost.LaunchDataService("http://localhost:4444/DataService");
            var baseAddresses = new Uri[] { new Uri(baseAddress) };
            using (DataServiceHost host = new DataServiceHost(typeof(DataService), baseAddresses)) {
                try {
                    host.Open();
                    Console.WriteLine("DataService running.....");
                    Console.WriteLine($"Address: {baseAddress}");

                    Console.ReadLine();
                    host.Close();
                } catch (Exception) {
                    host.Abort();
                    throw;
                }
                
            }

        }
    }
}
