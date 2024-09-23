namespace Horizon_HR.Dtos.LeaveBalance
{
    public class UpdateLeaveBalanceDto
    {
        public int? Annual { get; set; }
        public int? Sick { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
