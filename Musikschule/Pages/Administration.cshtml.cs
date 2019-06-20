using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Musikschule.Pages
{
    public class AdministrationModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Bitte wählen Sie eine der folgenden Funktionen aus.";
        }
    }
}
