using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Musikschule.Pages
{
    public class DozentenModel : PageModel
    {
        public string Message { get; set; }
       
        

        //public List<Teacher> Lehrer { get; set; }

        public void OnGet()
        {
            Message = "Your application description page.";
           
        }

        
    }
}
