using HtmlAgilityPack;
using System.Xml;
using System.Xml.Linq;
using TelasiFetcher.Extensions;
using TelasiFetcher.Models;
using TelasiFetcher.Models;

namespace TelasiFetcher.App.Services;

public class TelasiAccountParser
{
    public TelasiAccount Parse(int id, string html)
    {
        var doc = new HtmlDocument();
        doc.LoadHtml(html);
        
        var node = doc.DocumentNode.SelectSingleNode("//*[@id=\"content\"]/div/div[1]/h2/code");
        
        var account = new TelasiAccount();
        account.Id = id;
        account.Number = ReadNumber(node);
        account.Name = ReadName(node);

        node = doc.DocumentNode.SelectSingleNode("//*[@id=\"content\"]/div/div[2]/div[1]/ul/li[1]/div/code/span");
        account.Status = ReadInnerText(node);
        
        node = doc.DocumentNode.SelectSingleNode("//*[@id=\"content\"]/div/div[2]/div[1]/ul/li[2]/div/code");
        account.CleaningDept = ReadInnerText(node).ToDouble();
        node = doc.DocumentNode.SelectSingleNode("//*[@id=\"content\"]/div/div[2]/div[1]/ul/li[3]/div/code");
        account.WaterDept = ReadInnerText(node).ToDouble();

        node = doc.DocumentNode.SelectSingleNode("//*[@id=\"content\"]/div/div[2]/div[1]/ul/li[4]/div/code");
        account.LastReceipt = ReadInnerText(node);
        account.LastReceiptDate = new DateTime();

        node = doc.DocumentNode.SelectSingleNode("//*[@id=\"content\"]/div/div[2]/div[1]/ul/li[5]/div");
        account.PaymentDeadline = ReadInnerText(node).ToDate("dd/MM/yyyy");
        account.CreatedAt = DateTime.Now;
        account.UpdatedAt = DateTime.Now;
        return account;
    }

    private string ReadInnerText(HtmlNode node)
    {
        return node.InnerText.Trim();
    }

    private string ReadName(HtmlNode node)
    {
        var nodeParts = ReadInnerText(node).Split(' ', StringSplitOptions.RemoveEmptyEntries);
        if (nodeParts.Length < 2)
        {
            return string.Empty;
        }
        return string.Join(' ', nodeParts.Skip(1));
    }

    private string ReadNumber(HtmlNode node)
    {
        var nodeParts = ReadInnerText(node).Split(' ', StringSplitOptions.RemoveEmptyEntries);
        if (nodeParts.Length == 0)
        {
            return string.Empty;
        }
        return nodeParts[0].TrimStart('#');
    }


}