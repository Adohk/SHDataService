using System;
using System.Collections.Generic;
using System.Data.Services;
using System.Data.Services.Common;
using System.Data.Services.Providers;
using System.Linq;
using System.ServiceModel;
using System.Web;
using SHDataService.Entities;

namespace SHDataService.Service {

    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class DataService : EntityFrameworkDataService<FtestDbEntities> {

        protected override void HandleException(HandleExceptionArgs args) => base.HandleException(args);

        public static void InitializeService(DataServiceConfiguration config) {
            // TODO: set rules to indicate which entity sets and service operations are visible, updatable, etc.
            // Examples:
            config.UseVerboseErrors = true;
            config.SetEntitySetAccessRule("Contact", EntitySetRights.All);
            config.SetServiceOperationAccessRule("*", ServiceOperationRights.All);
            config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V3;
        }
    }
}
