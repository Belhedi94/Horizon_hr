namespace Horizon_HR.Dtos.BankAccount
{
    public class BankAccountDto
    {
        public Guid Id { get; set; }

        public string BankName { get; set; }

        public string AccountNumber { get; set; }

        public string Rib { get; set; }

        public string HolderName { get; set; }
    }
}
