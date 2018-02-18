using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecard.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ecard.Pages
{
    public class formModel : PageModel
    {
        [BindProperty]
        public Greetings bridgeGreetings { get; set; }
        private Iconfiguration myConfiguration { get; set; }
        //CONNECT TO MY DATABASE
        private myDB _myDB;
        public FormModel(myDB myDB, Iconfiguration myConfiguration)
        {

        }

        public void OnGet()
        {

        }
    }
}
