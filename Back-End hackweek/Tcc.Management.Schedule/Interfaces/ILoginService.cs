using Tcc.Management.Schedule.Models;

namespace Tcc.Management.Schedule.Interfaces
{
    public interface ILoginService 
    {
        bool ValidateLogin(User user);
        bool CreateUser(User user);
    }
}
