using TelasiFetcher.App.Repositories;
using TelasiFetcher.App.Services;
using TelasiFetcher.Models;

public class TelasiFetcherService
{
    private HttpService _http;
    private TelasiAccountParser _parser;
    private TelasiAccountRepository _repository;
    private List<TelasiAccount> _accounts;

    private const int _limit = 900000;
    private const int _saveChunkSize = 10;
    private const string _directoryPath = "C:\\Users";

    private static object _lockObject = new object();
    public async Task ExecuteAsync()
    {
        _http = new HttpService();
        _parser = new TelasiAccountParser();
        _repository = new TelasiAccountRepository();
        _accounts = new List<TelasiAccount>(_saveChunkSize);

        var indexes = new int[900000];
        for (int i = 1; i <= 900000; i++)
        {
            indexes[i - 1] = i;
        }

        var options = new ParallelOptions();
        options.MaxDegreeOfParallelism = 2;
        Parallel.ForEach(indexes, options, FetchAccount);
    }

    private void FetchAccount(int i)
    {
        var url = $"https://my.telasi.ge/customers/info/{i}";
        var html = _http.DownloadHtml(url);
        var account = _parser.Parse(i, html);
        _accounts.Add(account);
        var fileName = GetFileName(i);
        var filePath = Path.Combine(_directoryPath, fileName);
        lock (_lockObject)
        {
            _repository.SaveToFile(filePath, FileFormat.Json, account);
        }
    }

    private string GetFileName(int i)
    {
        var index = (int)Math.Ceiling(i / 100.0) * 100;
        return $"accounts_{index}.json";
    }
}