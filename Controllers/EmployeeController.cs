using BurulasWebApi.Models;
using BurulasWebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BurulasWebApi.Controllers
{
    [ApiController]
    [Route("api/employee")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet()]
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

        [HttpPost]
        public async Task<ActionResult<StandardResponse<Models.Employee>>> Post(Employee employee)
        {
            var employees = await Task.FromResult(EmployeeService.Instance.Add(employee));
            if (employees == null)
            {
                return NotFound();
            }
            return employees;
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<StandardResponse<bool>>> Delete(int id)
        {
            var employees = await Task.FromResult(EmployeeService.Instance.Delete(id));
            if (employees == null)
            {
                return NotFound();
            }
            return employees;
        }



        [HttpPut]
        public async Task<ActionResult<StandardResponse<Models.Employee>>> Put(Employee employee)
        {
            var employees = await Task.FromResult(EmployeeService.Instance.Put(employee));
            if (employees == null)
            {
                return NotFound();
            }
            return employees;
        }
    }
}
