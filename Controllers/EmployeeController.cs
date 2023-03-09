using BurulasWebApi.Models;
using BurulasWebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BurulasWebApi.Controllers
{
    [ApiController]
    [Route("api/employee")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet("GetList")]
        public async Task<ActionResult<ListResponse<Models.Employee>>> GetList()
        {
            var employees = await Task.FromResult(EmployeeService.Instance.GetList());
            if (employees == null)
            {
                return NotFound();
            }
            return employees;
        }


        [HttpGet("Test")]
        public string Test()
        {
            return "Test";
        }
    }
}
