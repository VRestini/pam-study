using MauiApp1.MVVM.Models;
using System.Collections.ObjectModel;
using System.Diagnostics;

using System.Text.Json;


namespace MauiApp1.Service
{
    public class MonitorService
    {
        private HttpClient _httpClient;
        private JsonSerializerOptions _serializerOptions;
        private MVVM.Models.Monitor monitor;
        private ObservableCollection<MVVM.Models.Monitor> monitores { get; set; }

     
        public MonitorService()
        {
            _httpClient = new HttpClient();
            _serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true,
            };
            
        }
        public async Task<ObservableCollection<MVVM.Models.Monitor>> getAllMonitorsAsync()
        {
            Uri uri = new Uri("http://localhost:8080/monitor");
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    monitores = JsonSerializer.Deserialize<ObservableCollection<MVVM.Models.Monitor>>(content, _serializerOptions);
                }
            }
            catch (Exception ex)
            {
                 Debug.WriteLine(ex.Message);
            }
            return monitores;
        }
    }
}
