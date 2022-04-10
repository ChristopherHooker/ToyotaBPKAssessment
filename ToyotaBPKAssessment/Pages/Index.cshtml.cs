using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToyotaBPKAssessment.EFObjects;

namespace ToyotaBPKAssessment.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            //BPKContext ctx = new BPKContext();
            //var user = new User("Chris", "christopherhooker@outlook.com", "(606)224-3186", new MailAddress());
            //user.MailAddress = new MailAddress(user, "3300 Montavesta Rd", "", "Lexington", "KY", "40502");
            //ctx.Users.Add(user);
            //ctx.SaveChanges();
            //Console.WriteLine("User Saved: " + ctx.Database.Connection.ConnectionString);
        }
        public void OnButtonClick()
        {
        }
    }
}