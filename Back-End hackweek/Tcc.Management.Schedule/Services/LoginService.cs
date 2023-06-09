﻿using Tcc.Management.Schedule.Data;
using Tcc.Management.Schedule.Interfaces;
using Tcc.Management.Schedule.Models;

namespace Tcc.Management.Schedule.Services
{
    public class LoginService : ILoginService
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
           
                return (foundUser != null);

            }
            catch (Exception ex)
            {
                return false;
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
                return false;
            }
        }
    }
}
