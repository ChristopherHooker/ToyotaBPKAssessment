using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace ToyotaBPKAssessment.EFObjects
{


    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public virtual MailAddress MailAddress { get; set; }

        public User(string name, string email, string phoneNumber, MailAddress mailAddress)
        {
            Id = Guid.NewGuid();
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            MailAddress = mailAddress;
        }

        public string getMailAddressString()
        {
            return MailAddress.Addr1 + " " + MailAddress.Addr2 + ", " + MailAddress.City + ", " + MailAddress.State + " " + MailAddress.ZipCode;
        }

        public User()
        {
            Id = new Guid();
            Name = "Undefined User";
        }
    }

    
    
}
