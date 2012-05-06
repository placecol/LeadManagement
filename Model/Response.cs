namespace Kaiser.LeadManagement.Model
{
    public class Response
    {
        public string Id { get; set; }

        public string CampaignId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public PhoneNumber HomePhone { get; set; }

        public PhoneNumber WorkPhone { get; set; }

        public PhoneNumber MobilePhone { get; set; }

        public Address Address { get; set; }

        public Quality Quality { get; set; }
    }
}
