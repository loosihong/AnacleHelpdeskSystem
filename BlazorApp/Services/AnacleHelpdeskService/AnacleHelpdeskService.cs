using SharedModelLibrary;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

namespace BlazorApp.Services.AnacleHelpdeskService
{
    public partial class AnacleHelpdeskService
    {
        private readonly HttpClient _httpClient;

        public AnacleHelpdeskService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public Task<List<DrawerBindItem>> GetMenuListAsync()
        {
            return GetApiDataAsync<List<DrawerBindItem>>($"api/general/getmenulist");
        }

        protected async Task<T> GetApiDataAsync<T>(string relativeUri)
        {
            HttpResponseMessage response = await this._httpClient.GetAsync(relativeUri);
            T data = default(T);

            response.EnsureSuccessStatusCode();

            //using (Stream responseStream = await response.Content.ReadAsStreamAsync())
            //{
            //    data = await JsonSerializer.DeserializeAsync<T>(responseStream);
            //}
            string json = await response.Content.ReadAsStringAsync();
            data = JsonSerializer.Deserialize<T>(json);

            return data;
        }
    }
}
