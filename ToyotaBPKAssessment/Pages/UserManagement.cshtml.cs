using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToyotaBPKAssessment.EFObjects;

namespace ToyotaBPKAssessment.Pages
{
    public class UserManagementModel : PageModel
    {
        public IList<User> UserList { get; set; }

        [HttpGet("{id}/{action}")]
        public void OnGet(Guid? id, string? action)
        {
            BPKContext ctx = new BPKContext();

            //perform delete before user list is pulled to make data reflect changes. Edit goes to a different page so no need for action
            switch (action)
            {
                case "delete":
                    if (id != null)
                    {
                        User toDelete = ctx.Users.Where(x => x.Id == id).First();
                        ctx.Users.Remove(toDelete);
                        ctx.SaveChanges();
                    }
                    break;

                default:
                    break;
            }


            UserList = ctx.Users.ToList();

        }

    }
}
