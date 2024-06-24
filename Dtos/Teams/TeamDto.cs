namespace Horizon_HR.Dtos.Teams
{
    public class TeamDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid DepartmentId { get; set; }
    }
}
