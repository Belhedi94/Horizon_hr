namespace Horizon_HR.Dtos.LeaveBalance
{
    public class CreateLeaveBalanceDto
    {
        public int Annual { get; set; }

        public int Sick { get; set; }

        public Guid UserId { get; set; }
    }
}
