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
          //  Message = Musikschule.Modelle.TeacherRepository.GetallTeachers(); 
           Message = Musikschule.Modelle.Controller.DBConnect("Select * From dbo.Teacher INNER JOIN dbo.Users ON dbo.teacher.fk_user = dbo.Users.id INNER JOIN dbo.Person ON dbo.Users.fk_person = dbo.Person.ID");
        }



        
    }
}
