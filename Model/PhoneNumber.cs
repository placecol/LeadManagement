using System;

namespace Kaiser.LeadManagement.Model
{
    public class PhoneNumber
    {
        private readonly string phone;

        private PhoneNumber(string phone)
        {
            if (phone == null) throw new ArgumentNullException("phone");

            this.phone = phone;
        }

        public static PhoneNumber Parse(string phone)
        {
            return new PhoneNumber(phone);
        }

        public override string  ToString()
        {
            return phone;
        }

        public override bool Equals(object obj)
        {
            var otherPhone = obj as PhoneNumber;
            return (otherPhone != null && otherPhone.phone == phone);
        }

        public override int GetHashCode()
        {
            return phone.GetHashCode();
        }
    }
}