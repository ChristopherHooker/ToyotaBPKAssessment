using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToyotaBPKAssessment.EFObjects;

namespace ToyotaBPKAssessment.Pages
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public string uName { get; set; }
        [BindProperty]
        public string uEmail { get; set; }
        [BindProperty]
        public string uPhone { get; set; }
        [BindProperty]
        public string maAddr1 { get; set; }
        [BindProperty]
        public string maAddr2 { get; set; }
        [BindProperty]
        public string maCity { get; set; }
        [BindProperty]
        public string maState { get; set; }
        [BindProperty]
        public string maZip { get; set; }
        [BindProperty]
        public Guid editUserID { get; set; }

        [HttpGet("{id}")]
        public void OnGet(Guid id)
        {
            editUserID = id;
            Console.WriteLine(id);
            if (id == null)
            {
                Console.WriteLine("No ID Specified");
                return;
            }
            BPKContext ctx = new BPKContext();
            User editUser = ctx.Users.Where(x => x.Id == id).FirstOrDefault();
            uName = editUser.Name;
            uEmail = editUser.Email;
            uPhone = editUser.PhoneNumber;
            maAddr1 = editUser.MailAddress.Addr1;
            maAddr2 = editUser.MailAddress.Addr2;
            maCity = editUser.MailAddress.City;
            maState = editUser.MailAddress.State;
            maZip = editUser.MailAddress.ZipCode;


        }
        public void OnPost()
        {
            Console.WriteLine(editUserID.ToString());
            BPKContext ctx = new BPKContext();
            var updatedUser = ctx.Users.Where(x => x.Id == editUserID).First();
            updatedUser.Name = uName;
            updatedUser.Email = uEmail;
            updatedUser.PhoneNumber = uPhone;
            updatedUser.MailAddress.Addr1 = maAddr1;
            updatedUser.MailAddress.Addr2 = maAddr2;
            updatedUser.MailAddress.City = maCity;
            updatedUser.MailAddress.State = maState;
            updatedUser.MailAddress.ZipCode = maZip;
            ctx.SaveChanges();
            Console.WriteLine("User Saved: " + ctx.Database.Connection.ConnectionString);
        }
    }
}
