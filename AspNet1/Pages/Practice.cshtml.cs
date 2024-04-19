using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNet1.Pages
{
    public class PracticeModel : PageModel
    {
        public char RandomLetter;
        public void OnGet()
        {
            var random = new Random();
            var randomIndex = random.Next(0, 26);

            RandomLetter = (char)('A' + randomIndex);
        }

    }
}
