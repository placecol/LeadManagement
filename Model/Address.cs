using System.Collections.ObjectModel;

namespace Kaiser.LeadManagement.Model
{
    public class Address
    {
        public Collection<string> Lines { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }

        public string Province { get; set; }

        public string Country { get; set; }
    }
}