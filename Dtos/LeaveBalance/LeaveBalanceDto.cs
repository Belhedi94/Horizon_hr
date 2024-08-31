namespace Horizon_HR.Dtos.LeaveBalance
{
    public class LeaveBalanceDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public int TotalLeaveDays { get; set; }
        public float UsedLeaveDays { get; set; }
        public float RemainingLeaveDays { get; set; }
    }
}
