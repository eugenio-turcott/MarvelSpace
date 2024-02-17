using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace TC3004B_M4_T01_E1.Pages
{
    public class MinijuegoModel : PageModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [RegularExpression("^[A-Za-z]+$", ErrorMessage = "Please enter only alphabetical characters.")]
        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public string Month { get; set; }

        public void OnGet()
        {
            Name = "";
            Month = "";
        }

        public void OnPost()
        {
            string result = "";
            string result2 = "";

            // Letters
            char[] firstLetter = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            string[] nameasMonth1 = { "Captain ", "Wonder ", "Super ", "Phantom ", "Dark ", "Incredible ", "Professor ", "Iron ", "Hawk ", "Archer ", "Steel ", "Bolt ", "Atomic ", "Torch ", "Space ", "Mega ", "Turbo ", "Fantastic ", "Invisible ", "Night ", "Silver ", "Aqua ", "Amazing ", "Giant ", "Rock ", "Power " };

            Name = Name.ToUpper();

            int index = 0;
            bool equal = false;

            for (int i = 0; i < firstLetter.Length; i++)
            {
                equal = firstLetter[i].Equals(Name[0]);
                if (equal != false)
                {
                    index = i;
                    break;
                }
            }

            // Months
            string[] months = { "JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER" };
            string[] nameasMonth2 = { "Shield", "Arrow", "Justice", "Thunder", "Rider", "Falcon", "Ninja", "Spider", "Beast", "Blade", "Hulk", "Doom" };

            Month = Month.ToUpper();
            int index2 = 0;
            bool equal2 = false;

            for (int i = 0; i < months.Length; i++)
            {
                equal2 = months[i].Equals(Month);
                if (equal2 != false)
                {
                    index2 = i;
                    break;
                }
            }

            System.Console.WriteLine(nameasMonth1[index]);
            System.Console.WriteLine(Month);
            System.Console.WriteLine(nameasMonth2[index2]);

            result = nameasMonth1[index];
            result2 = nameasMonth2[index2];

            Response.Redirect("Result?Message1=" + result + "&Message2=" + result2);
        }
    }
}
