using System;
using System.Configuration;

using CluedIn.Core;
using CluedIn.Server.Common.WebApi.OAuth;
using CluedIn.Crawling.Dynamics365.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;

namespace CluedIn.Provider.Dynamics365.WebApi
{
    [Route("api/" + Dynamics365Constants.ProviderName + "/oauth")]
    public class Dynamics365OAuthController : OAuthCluedInApiController
    {
        private const string NoStateFoundInCluedIn = "No state found in CluedIn";
        private const string NoStateWasReturnedFromAuthenticator = "No state was returned from authenticator";

        public Dynamics365OAuthController([NotNull] Dynamics365ProviderComponent component)
          : base(component)
        {
        }

        // This method will be invoked as a call-back from an authentication service (e.g., https://login.windows.net/).
        // It is not intended to be called directly, only as a redirect from the authorization request.
        // On completion, the method will cache the refresh token and access tokens, and redirect to the URL
        // specified in the state parameter.
        public IActionResult Get(string code, string state)
        {
            using (var system = CreateRequestSystemExecutionContext())
            {
                // NOTE: In production, OAuth must be done over a secure HTTPS connection.
                if (this.Request.Scheme != "https" && Url.IsLocalUrl(this.Request.GetDisplayUrl()))
                    return Get("Endpoint is not HTTPS");

                // Ensure there is a state value on the response.  If there is none, stop OAuth processing and display an error.
                if (state == null)
                    Get(NoStateWasReturnedFromAuthenticator);

                if (code == null)
                    Get("No code was returned from authenticator");

                var stateObject = ValidateState(system, state);

                if (stateObject == null)
                {
                    using(system.Log.BeginScope(new { code, state }))
                    {
                        system.Log.LogError(NoStateFoundInCluedIn);
                    }
                    return Get(NoStateFoundInCluedIn);
                }

                throw new NotImplementedException("TODO: Implement this");
            }
        }

        /// <summary>Gets the specified error.</summary>
        /// <param name="error">The error.</param>
        /// <returns></returns>
        public IActionResult Get([NotNull] string error)
        {
            if (error == null)
                throw new ArgumentNullException(nameof(error));

            using (var system = CreateRequestSystemExecutionContext())
            {
                system.Log.LogWarning("Dynamics365 received an error on OAuth : {error}", error);


                //I am not passed the state back, so I have nowhere to know where I came from, hence the redirection to app.cluedin.net
                var redirect = $"<script>window.location = \"https://app.{ConfigurationManager.AppSettings["Domain"]}/admin/#/administration/integration/error/dynamics365\";</script>";

                var response = this.Content(redirect, "text/html");
                response.StatusCode = StatusCodes.Status417ExpectationFailed;

                // Ensure there is a state value on the response.  If there is none, stop OAuth processing and display an error.
                return response;
            }
        }
    }
}
