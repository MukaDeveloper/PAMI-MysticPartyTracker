using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net.Http.Json;
using System.Text.Json;

namespace MysticPartyTracker.Models
{
    public class RestService
    {
        HttpClient _client;
        JsonSerializerOptions _serializerOptions; //pega um json e transforma em um objeto

        public ObservableCollection<Result> Spells { get; set; }

        public RestService()
        {
            _client = new HttpClient();
            _serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true,
            };
        }

        public async Task<ObservableCollection<Result>> GetSpellsAsync()
        {
            Spells = new ObservableCollection<Result>();

            Uri uri = new Uri("https://www.dnd5eapi.co/api/spells");
            try
            {
                Response response = await _client.GetFromJsonAsync<Response>(uri);
                if (response.Results != null)
                {
                    foreach (var spell in response.Results)
                    {
                        Spells.Add(spell);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            return Spells;
        }
    }
}