namespace BandMerchShop.Domain.Model
{
    public class Address
    {
        public int Id { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}