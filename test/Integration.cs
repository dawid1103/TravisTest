using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Api;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
using Xunit;

namespace Integration
{
    public class Integration
    {
        protected readonly TestServer Server;
        protected readonly HttpClient Client;

        public Integration()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        public StringContent GetPayload(object data)
        {
            var json = JsonConvert.SerializeObject(data);
            return new StringContent(json, Encoding.UTF8, "application/json");
        } 

        [Fact]
        public async void Test1()
        {
            var response = await Client.GetAsync("person/5");
            var responseString = await response.Content.ReadAsStringAsync();
            // var result = JsonConvert.DeserializeObject<string>(responseString);
            Assert.Equal(responseString, "value");
        }
    }
}
