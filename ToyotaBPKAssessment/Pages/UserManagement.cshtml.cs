using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToyotaBPKAssessment.EFObjects;

namespace ToyotaBPKAssessment.Pages
{
    public class UserManagementModel : PageModel
    {
        public IList<User> UserList { get; set; }
        public void OnGet()
        {
            BPKContext ctx = new BPKContext();
            UserList = ctx.Users.ToList();
            
        }
    }
}
