using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualBasic.CompilerServices;

namespace Temperature.Pages
{
    public class StationModel : PageModel
    {
        private void GetServiceManual()
        {
            //var services = this.HttpContext.RequestServices;
            //var boot = (IBootstrap) services.GetService(typeof(IBootstrap));
            //boot.Setup();
        }
        public void OnGet()
        {

        }
    }
}
