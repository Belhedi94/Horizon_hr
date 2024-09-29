namespace Horizon_HR.Dtos.LeaveBalance
{
    public class CreateLeaveBalanceDto
    {
        public double Annual { get; set; }

        public double Sick { get; set; }

        public Guid UserId { get; set; }
    }
}
