using BurulasWebApi.Helpers;
using BurulasWebApi.Models;


namespace BurulasWebApi.Services
{
    public class UserInfoService : BaseService<UserInfoService>
    {
        public UserInfo Get(string username,string password)
        {
            return DBHelper.GetQuery<UserInfo>("select * from UserInfo with (nolock) where UserName=@UserName and Password=@Password", new { UserName = username, Password = password });
        }
        
    }
}
