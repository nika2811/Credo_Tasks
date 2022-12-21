using TelasiFetcher.Models;
using Newtonsoft.Json;
namespace TelasiFetcher.App.Repositories;

public class TelasiAccountRepository
{
    public void SaveToFile(
        string filePath,
        FileFormat format,
        TelasiAccount account)
    {
        switch (format)
        {
            case FileFormat.Json:
                using (var writer = new StreamWriter(filePath))
                {
                    var serializer = new JsonSerializer();
                    serializer.Serialize(writer, account);
                }
                break;
            case FileFormat.Csv:
                using (var writer = new StreamWriter(filePath))
                {
                    writer.WriteLine($"{account.Id},{account.Number},{account.Name},{account.Status},{account.CleaningDept},{account.WaterDept},{account.LastReceipt},{account.LastReceiptDate},{account.PaymentDeadline},{account.CreatedAt},{account.UpdatedAt}");
                }
                break;
        }
    }

}