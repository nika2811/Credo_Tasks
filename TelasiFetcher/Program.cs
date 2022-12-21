using System.Globalization;
using System.IO;
using System.Text.Json;

namespace TelasiFetcher
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            TelasiFetcherService telasiFetcherService = new TelasiFetcherService();
            telasiFetcherService.ExecuteAsync();
        }
    }
}