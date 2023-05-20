namespace Tcc.Management.Schedule.Models
{
    public class Student:User
    {
        public int StudentId { get; set; }
        public List<Meeting> Meetings { get; set; }
        public List<Goals> Goals { get; set; }
        public Supervisor Supervisor { get; set; }
        public Supervisor? CoSupervisor { get; set; }
    }
}
