using Tcc.Management.Schedule.Enums;

namespace Tcc.Management.Schedule.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public UserTypeEnum Type { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
