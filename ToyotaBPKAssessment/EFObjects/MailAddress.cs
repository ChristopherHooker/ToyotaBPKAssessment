using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace ToyotaBPKAssessment.EFObjects
{
    public class MailAddress
    {
        public Guid MailAddressID { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public MailAddress()
        {

        }
        public MailAddress(string addr1, string addr2, string city, string state, string zipCode)
        {
            MailAddressID = Guid.NewGuid();
            Addr1 = addr1;
            Addr2 = addr2;
            City = city;
            State = state;
            ZipCode = zipCode;
        }

        public string getMailAddressString()
        {
            return Addr1 + " " + Addr2 + ", " + City + ", " + State + " " + ZipCode;
        }
    }
}
