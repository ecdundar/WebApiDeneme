using Microsoft.AspNetCore.Mvc;

namespace BurulasWebApi.Controllers
{
    [ApiController]
    [Route("api/employee")]
    public class EmployeeController : ControllerBase
    {
        public String Ping()
        {
            return "Hello World";
        }
    }
}
