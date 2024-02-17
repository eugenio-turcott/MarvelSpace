using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace TC3004B_M4_T01_E1.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Total { get; set; }
        [BindProperty]
        public string Order { get; set; }

        public void OnGet()
        {
            Total = "";
            Order = "";
        }

        public void OnPost()
        {
            string result = "";
            string result2 = "";

            string total = Total;
            string order = Order;

            System.Console.WriteLine(total, order);

            result = total;
            result2 = order;

            Response.Redirect("Payment?Total=" + result + "&Order=" + result2);
        }
    }
}