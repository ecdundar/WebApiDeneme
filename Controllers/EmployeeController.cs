using BurulasWebApi.Models;
using BurulasWebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BurulasWebApi.Controllers
{
    [ApiController]
    [Route("api/employee")]
    public class EmployeeController : ControllerBase
    {
        //[HttpGet("GetList")]
        public async Task<ActionResult<ListResponse<Models.Employee>>> GetList()
        {
            var employees = await Task.FromResult(EmployeeService.Instance.GetList());
            if (employees == null)
            {
                return NotFound();
            }
            return employees;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<StandardResponse<Models.Employee>>> Get(int id)
        {
            var employees = await Task.FromResult(EmployeeService.Instance.Get(id));
            if (employees == null)
            {
                return NotFound();
            }
            return employees;
        }
    }
}
