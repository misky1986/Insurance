using Insurance.API;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Insurance.Tests.IntegrationTest
{
    class InsuranceControllerIntegrationTest
    {
        private readonly TestServer _server;
        private readonly HttpClient _client;

        public InsuranceControllerIntegrationTest()
        {
            // Arrange
            _server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            _client = _server.CreateClient();
        }

        
        //public async Task Test_Get_All_Members()
        //{
        //    // Act
        //    var response = await _client.GetAsync("/api/insurance");
        //    response.EnsureSuccessStatusCode();
        //    var responseString = await response.Content.ReadAsStringAsync();
            
        //    // Assert
        //    var members = JsonConvert.DeserializeObject<IEnumerable<Insurance>>(responseString);
        //    members.Count().Should().Be(50);
        //}

        
        //public async Task Test_Get_Specific_Member()
        //{
        //    // Act
        //    var response = await _client.GetAsync("/api/Members/8");
        //    response.EnsureSuccessStatusCode();
        //    var responseString = await response.Content.ReadAsStringAsync();

        //    // Assert
        //    var members = JsonConvert.DeserializeObject<Member>(responseString);
        //    members.Id.Should().Be(8);
        //}
    }
}
