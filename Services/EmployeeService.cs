using BurulasWebApi.Helpers;
using BurulasWebApi.Models;

namespace BurulasWebApi.Services
{
    public class EmployeeService : BaseService<EmployeeService>
    {
        public ListResponse<Employee> GetList()
        {
            var result = new ListResponse<Employee>();
            result.Data = DBHelper.GetList<Employee>("select * from Employee with (nolock)");
            result.Status = true;
            return result;
        }

        public StandardResponse<Employee> Get(int id)
        {
            var result = new StandardResponse<Employee>();
            result.Data = DBHelper.GetQuery<Employee>("select * from Employee with (nolock) where EmployeeID=@ID", new { ID = id });
            result.Status = true;
            return result;
        }
    }
}
