using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AulaRazorPages.Pages
{
    public class IndexModel : PageModel
    {
        public string MyFullName { get; set; }

        public void OnGet()
        {
            MyFullName = "Deyvid Rannyere de Moraes Costa - it comes from code behind";
        }
    }
}
