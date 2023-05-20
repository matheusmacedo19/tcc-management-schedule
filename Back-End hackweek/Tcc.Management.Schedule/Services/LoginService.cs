using Tcc.Management.Schedule.Data;
using Tcc.Management.Schedule.Models;

namespace Tcc.Management.Schedule.Services
{
    public class LoginService
    {
        public readonly AppDataContext _context;

        public LoginService(AppDataContext context)
        {
            _context = context;
        }
        public bool ValidateLogin(User user)
        {
            try
            {
               User? foundUser = _context.Users.Where(x => x.Email == user.Email && x.Password == user.Password).FirstOrDefault();
           
                if(foundUser != null)
                {
                    return true;
                }else
                    return false;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool CreateUser(User user)
        {
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
