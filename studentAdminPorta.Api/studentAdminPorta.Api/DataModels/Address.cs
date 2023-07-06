using System;

namespace studentAdminPorta.Api.DataModels
{
    public class Address
    {
        public Guid Id { get; set; }
        public string PhysicalAddress { get; set; }
        public string PostalAddress { get; set; }
        
        // Navigation property
        public Guid StudentId { get; set; }
    }
}
