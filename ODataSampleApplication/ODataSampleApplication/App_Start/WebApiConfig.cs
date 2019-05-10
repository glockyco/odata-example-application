using System.Web.Http;
using System.Web.OData.Extensions;
using Microsoft.Restier.Publishers.OData;
using Microsoft.Restier.Publishers.OData.Batch;

namespace ODataSampleApplication
{
    public static class WebApiConfig
    {
        public static async void Register(HttpConfiguration config)
        {
            config.Filter().Expand().Select().OrderBy().MaxTop(null).Count();
            await config.MapRestierRoute<AdventureWorksApi>(
                "AdventureWorksLT",
                "api/AdventureWorksLT",
                new RestierBatchHandler(GlobalConfiguration.DefaultServer));
        }
    }
}
