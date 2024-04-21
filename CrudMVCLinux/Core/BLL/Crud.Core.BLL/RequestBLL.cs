using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Crud.Core.Common.Entities;
using Newtonsoft.Json;

namespace Crud.Core.BLL
{
    public class RequestBLL
    {
        public string ServiceUrlApi { get; set; }

        public async Task GetUrlApi()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            ServiceUrlApi = config.GetValue<string>("AppConfig:TestSolApi");
        }

        public async Task<List<Employee>> GetAllEmployees()
        {
            var employees = new List<Employee>();

            var url = $"{ServiceUrlApi}/getAllEmployees";

            HttpResponseMessage response;

            using(var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();

                response = await client.GetAsync(url).ConfigureAwait(false);

                employees = JsonConvert.DeserializeObject<List<Employee>>(await response.Content.ReadAsStringAsync().ConfigureAwait(false));
            }

            return employees;

        }
    }
}