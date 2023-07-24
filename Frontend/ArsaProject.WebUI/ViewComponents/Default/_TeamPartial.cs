﻿using ArsaProject.WebUI.Dtos.StaffDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;

using System.Net.Http;

using System.Threading.Tasks;

namespace ArsaProject.WebUI.ViewComponents.Default
{
    public class _TeamPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _TeamPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:65043/api/Staff");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultStaffDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
