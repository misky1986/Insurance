using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using IdentityModel.Client;
using Newtonsoft.Json.Linq;
using Xunit;

namespace Insurance.Tests.integrationtest
{
    public class AuthenticationIntegrationTest
    {
        [Fact]
        public async Task TestThat()
        {
            // Arrange
            // discover endpoints from metadata
            var disco = await DiscoveryClient.GetAsync("http://localhost:5000");
            if (disco.IsError)
            {
                Console.WriteLine(disco.Error);
                return;
            }

            // request token
            var tokenClient = new TokenClient(disco.TokenEndpoint, "clientId", "secret");
            var tokenResponse = await tokenClient.RequestClientCredentialsAsync("api1");

            /*
             if (tokenResponse.IsError)
            {
                Console.WriteLine(tokenResponse.Error);
                return;
            }
            */

            Console.WriteLine("\n\n");
            Console.WriteLine(tokenResponse.Json);

            // Act - Call api
            var client = new HttpClient();
            client.SetBearerToken(tokenResponse.AccessToken);

            var response = await client.GetAsync("http://localhost:5001/api/identity");
            Console.WriteLine(response.StatusCode);
            Console.WriteLine(response.StatusCode.GetHashCode());
            Console.WriteLine(response.StatusCode.ToString());
            
            // Assert
            Assert.Equal(201, response.StatusCode.GetHashCode());
          
        }
    }
}
