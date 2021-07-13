using Company.Template.Identity.API;
using Company.Template.Identity.API.Models;
using Service2.IntegrationTest.Config;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace Service2.IntegrationTest
{
    public class IdentityIntegrationTest: BaseIntegerationTest
    {

        public IdentityIntegrationTest(IdentityFixture<Startup> testFixture)
            : base(testFixture)
        {

        }

        [Fact]
        public async Task Test()
        {
            TokenRequestViewModel model = new TokenRequestViewModel { Username = "shawn@wildermuth.com", Password = "P@ssw0rd!" };

            var httpResponse = await PostRequest($"auth/Connect", model);
            Assert.Equal((int)HttpStatusCode.Created,(int) httpResponse.StatusCode);
        }
    }
}
