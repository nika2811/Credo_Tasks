namespace TelasiFetcher.Models;

public class TelasiAccount
{
    public int Id { get; set; }
    public string Number { get; set; }
    public string Name { get; set; }
    public string Status { get; set; }
    public double CleaningDept { get; set; }
    public double WaterDept { get; set; }
    public string LastReceipt { get; set; }
    public DateTime LastReceiptDate { get; set; }
    public DateTime PaymentDeadline { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}