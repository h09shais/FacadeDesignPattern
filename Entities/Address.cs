namespace Entities
{
    public class Address
    {
        public Address(string addressLine1, string addressLine2, string zip)
        {
            this.AddressLine1 = addressLine1;
            this.AddressLine2 = addressLine2;
            this.ZipCode = zip;
        }

        public string AddressLine1 { get; }
        public string AddressLine2 { get; }
        public string ZipCode { get; }
    }
}