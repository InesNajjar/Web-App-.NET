using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GrowX.Pages
{   [Authorize]
    public class IndexModel : PageModel
    {
        public void OnGet()
        {

        }
    }
}
