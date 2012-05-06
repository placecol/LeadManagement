using System.Collections.ObjectModel;
using Kaiser.LeadManagement.Model;

namespace Kaiser.LeadManagement.Web.Models
{
    public class Batch
    {
        public string Id { get; set; }

        public Collection<Response> Responses { get; set; }
    }
}