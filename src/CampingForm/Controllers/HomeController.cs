using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CampingForm.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Boot()
        {
            return View();
        }

        public IActionResult duplicateEntryWarning(name)
        {
            public List<string> campNames = new List<string> { "Skokomish Park", "Silver Falls" };

            for (let i = 0; i < campNames.length; i++)
            {
                if (campNames[i].toLowerCase().includes(name.toLowerCase())
                {
                    alert("please check that the " name " campsite has not already been entered.");
                }
                else 
                {
                    alert("looks good");
                }
            }
        }
        
    }
}

showCharityByName(searchTerm)
{

    this.charities = [];

    this.database.getCharities().subscribe(response => {

        for (let i = 0; i < response.length; i++)
        {

            if (response[i].charityName.toLowerCase().includes(searchTerm.toLowerCase()))
            {

                this.charities.push(response[i]);

            }

        }

    });

}