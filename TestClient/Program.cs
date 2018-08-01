using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SHDataService.Service;

namespace TestClient {
    class Program {
        static void Main(string[] args) {
            ServiceHost.LaunchService("http://localhost:4444/DataService");
        }
    }
}
