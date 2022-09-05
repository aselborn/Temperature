using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualBasic.CompilerServices;
using TempCoreApi.Models;

namespace Temperature.Pages
{
    public class StationModel : PageModel, IBootstrap
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

            using var client = new HttpClient();
            string path = string.Concat(Setup().ApiPath, "/station");
            var content = await client.GetStringAsync(path);

            var info = JsonSerializer.Deserialize<StationInformation>(content);
        }

        public ApplicationConfig Setup()
        {
            var services = this.HttpContext.RequestServices;
            var boot = (IBootstrap)services.GetService(typeof(IBootstrap));

            return boot.Setup();
        }
    }
}
