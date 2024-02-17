using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TC3004B_M4_T01_E1.Pages
{
    public class ResultModel : PageModel
    {
        public void OnGet(string Message1, string Message2)
        {
            ViewData["ResultMessage1"] = Message1;
            ViewData["ResultMessage2"] = Message2;
        }
    }
}
