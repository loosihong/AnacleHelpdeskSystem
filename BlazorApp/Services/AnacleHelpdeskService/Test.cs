using System;
using System.Collections.Generic;
using System.Linq;
using SharedModelLibrary;
using System.Threading.Tasks;

namespace BlazorApp.Services.AnacleHelpdeskService
{
    public partial class AnacleHelpdeskService
    {
        public Task<List<ListBindItem<string>>> GetSelectListStringAsync()
        {
            return GetApiDataAsync<List<ListBindItem<string>>>($"api/test/getselectliststring");
        }

        public Task<List<ListBindItem<int?>>> GetSelectListIntAsync()
        {
            return GetApiDataAsync<List<ListBindItem<int?>>>($"api/test/getselectlistint");
        }

        public Task<DummyView> GetDummyAsync(string textField, string textArea, string select, string radio)
        {
            return GetApiDataAsync<DummyView>($"api/test/getdummy/{textField}/{textArea}/{select}/{radio}");
        }
    }
}
