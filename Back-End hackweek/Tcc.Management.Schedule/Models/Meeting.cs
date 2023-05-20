namespace Tcc.Management.Schedule.Models
{
    public class Meeting
    {
        public TimeOnly Time { get; set; }
        public DateOnly Date { get; set; }
        public Supervisor Supervisor { get; set; }
        public Supervisor? CoSupervisor { get; set; }
        public Student Student{ get; set; }
        public string Local { get; set; }
        public string Discussion { get; set; }
        public string Deliverable { get; set; }

    }
}
