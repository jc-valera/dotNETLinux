using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Crud.Core.BLL;
using Crud.Core.Common.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CrudMVCLinux.Controllers
{
    [Route("[controller]")]
    public class EmployeesController : Controller
    {
        public RequestBLL RequestBLL;

        public EmployeesController()
        {
            RequestBLL = new RequestBLL();
        }

        public async Task<IActionResult> Index()
        {
            var employees = await RequestBLL.GetAllEmployees();
            
            return View(employees);
        }
    }
}