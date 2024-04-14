using System.Runtime.CompilerServices;
using System.Text.Json;

//[assembly: InternalsVisibleTo("GUI")]
namespace API
{
    public class CatFactApi
    {
        private readonly CatFactsContext _context;
        private readonly HttpClient _client;

        public CatFactApi(CatFactsContext context)
        {
            _context = context;
            _client = new HttpClient();
        }

        public async Task GetDataAndAddToDatabase()
        {
            string call = "https://catfact.ninja/fact";
            string response = await _client.GetStringAsync(call);
            CatFact catFact = JsonSerializer.Deserialize<CatFact>(response);

            _context.CatFacts.Add(catFact);
            await _context.SaveChangesAsync();
            Console.WriteLine("Dodano nowy fakt o kocie do bazy danych.");
        }


        public void addData()
        {

        }
    }
}
