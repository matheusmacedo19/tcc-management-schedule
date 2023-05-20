namespace Tcc.Management.Schedule.Models
{
    public class Supervisor : User
    {
        public int SupervisorId { get; set; }
        public List<Meeting> Meeting { get; set; }
        public List<Goals> Goals { get; set; }
        public List<Student> Students { get; set; }
    }
}
