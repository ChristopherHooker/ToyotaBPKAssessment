using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToyotaBPKAssessment.EFObjects;

namespace ToyotaBPKAssessment.Pages
{
    public class Index1Model : PageModel
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
        public string showNotification { get; set; }

        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            BPKContext ctx = new BPKContext();
            var user = new User(uName, uEmail, uPhone, new MailAddress());
            user.MailAddress = new MailAddress(maAddr1, maAddr2, maCity, maState, maZip);
            ctx.Users.Add(user);
            ctx.SaveChanges();
            showNotification = "User saved Successfully!";
            return RedirectToPage("./UserManagement");
        }
    }
}
