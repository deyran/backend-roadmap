using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AulaRazorPages.Pages.Movies
{
    public class IndexModel : PageModel
    {
        public string[] MelhoresFilmes2024 = new string[]
        {
            "Robot Dreams",
            "A Different Man",
            "Evil Does Not Exist",
            "Hit Man",
            "Ferrari",
            "Anatomy of a Fall",
            "Fallen Leaves",
            "The Room Next Door",
            "Still Here",
            "Dune: Part Two"
        };


        public void OnGet()
        {
        }
    }
}
