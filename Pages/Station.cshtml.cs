using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualBasic.CompilerServices;

namespace Temperature.Pages
{
    public class StationModel : PageModel
    {
        private IBootstrap bootstrap;
        private void GetServiceManual()
        {
            //var services = this.HttpContext.RequestServices;
            //var boot = (IBootstrap) services.GetService(typeof(IBootstrap));
            //boot.Setup();
        }
        public async Task OnGet()
        {
            //get stations!


            var services = this.HttpContext.RequestServices;
            var boot = (IBootstrap)services.GetService(typeof(IBootstrap));

            using var client = new HttpClient();
            string path = string.Concat(boot.Setup().ApiPath, "/station");
            var content = await client.GetStringAsync(path);

            var ps = content;

        }
    }
}
