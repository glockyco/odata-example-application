namespace ODataSampleApplication
{
    using System;
    using Microsoft.Restier.Providers.EntityFramework;
    using Microsoft.Restier.Publishers.OData.Model;
    using ODataSampleApplication.Models;

    public class AdventureWorksApi : EntityFrameworkApi<AdventureWorksLT>
    {
        public AdventureWorksApi(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
        }

        [Operation(IsBound= true)]
        public string FullName(Customer customer)
        {
            return $"{customer.FirstName} {customer.MiddleName} {customer.LastName}";
        }
    }
}
