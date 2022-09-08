using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using TempCoreApi.Models;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Temperature.Pages
{
    public class StationModel : PageModel, IBootstrap
    {
        [ViewData]
        public List<StationInformation> SmhiStationInformations { get; set; }

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

            SmhiStationInformations= JsonConvert.DeserializeObject<List<StationInformation>>(content);

        }

        public ApplicationConfig Setup()
        {
            var services = this.HttpContext.RequestServices;
            var boot = (IBootstrap)services.GetService(typeof(IBootstrap));

            return boot.Setup();
        }
    }
}
