using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

using CluedIn.Core;
using CluedIn.Server.Common.WebApi.OAuth;
using CluedIn.Crawling.Dynamics365.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CluedIn.Provider.Dynamics365.WebApi
{
    [Authorize(Roles = "Admin, OrganizationAdmin")]
    [Route("api/providers/" + Dynamics365Constants.ProviderName)]
    public class Dynamics365Controller : OAuthCluedInApiController
    {
        public Dynamics365Controller([NotNull] Dynamics365ProviderComponent component) : base(component)
        {
        }

        // GET: Authenticate and Fetch Data
        public IActionResult Get(string authError)
        {
            using (var context = CreateRequestExecutionContext(UserPrincipal))
            {
                if (authError != null)
                {
                    // Tell the OAuth provider where to redirect to once you have the code.
                    var redirectUri = new Uri($"{this.Request.Scheme}://{this.Request.Host}/api/{Dynamics365Constants.ProviderName}/oauth");

                    var state = GenerateState(context, UserPrincipal.Identity.UserId, redirectUri.AbsoluteUri, context.Organization.Id);

                    throw new NotImplementedException($"TODO: Implement state processing... {state}");
                }

                return this.Ok("Dynamics365 Provider Crawled");
            }
        }
    }
}
