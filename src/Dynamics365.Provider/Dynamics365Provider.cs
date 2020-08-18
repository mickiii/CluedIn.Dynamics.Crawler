using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using CluedIn.Core;
using CluedIn.Core.Configuration;
using CluedIn.Core.Crawling;
using CluedIn.Core.Data.Relational;
using CluedIn.Core.Providers;
using CluedIn.Core.Webhooks;
using CluedIn.Crawling.Dynamics365.Core;
using CluedIn.Crawling.Dynamics365.Infrastructure.Factories;
using CluedIn.Providers.Models;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Newtonsoft.Json;

namespace CluedIn.Provider.Dynamics365
{
    public class Dynamics365Provider : ProviderBase, IExtendedProviderMetadata
    {
        private readonly IDynamics365ClientFactory _dynamics365ClientFactory;

        public Dynamics365Provider([NotNull] ApplicationContext appContext, IDynamics365ClientFactory dynamics365ClientFactory)
            : base(appContext, Dynamics365Constants.CreateProviderMetadata())
        {
            _dynamics365ClientFactory = dynamics365ClientFactory;
        }

        public override async Task<CrawlJobData> GetCrawlJobData(
            ProviderUpdateContext context,
            IDictionary<string, object> configuration,
            Guid organizationId,
            Guid userId,
            Guid providerDefinitionId)
        {
            if (configuration == null)
                throw new ArgumentNullException(nameof(configuration));

            var dynamics365CrawlJobData = new Dynamics365CrawlJobData();
            if (configuration.ContainsKey(Dynamics365Constants.KeyName.Url))
            { dynamics365CrawlJobData.Url = configuration[Dynamics365Constants.KeyName.Url].ToString(); }
            if (configuration.ContainsKey(Dynamics365Constants.KeyName.DeltaCrawlEnabled))
            { dynamics365CrawlJobData.DeltaCrawlEnabled = bool.Parse(configuration[Dynamics365Constants.KeyName.DeltaCrawlEnabled].ToString()); }
            if (configuration.ContainsKey(Dynamics365Constants.KeyName.UserName))
            { dynamics365CrawlJobData.UserName = configuration[Dynamics365Constants.KeyName.UserName].ToString(); }
            if (configuration.ContainsKey(Dynamics365Constants.KeyName.Password))
            { dynamics365CrawlJobData.Password = configuration[Dynamics365Constants.KeyName.Password].ToString(); }
            dynamics365CrawlJobData.ClientId = ConfigurationManager.AppSettings.GetValue<string>("Providers.Dynamics365ClientId", null);
            dynamics365CrawlJobData.ClientSecret = ConfigurationManager.AppSettings.GetValue<string>("Providers.Dynamics365ClientSecret", null);

            string apiVersion = "9.1";
            string webApiUrl = $"{dynamics365CrawlJobData.Url}/api/data/v{apiVersion}/";

            if (dynamics365CrawlJobData.UserName != null && dynamics365CrawlJobData.Password != null)
            {
                Crawling.Dynamics365.Infrastructure.Dynamics365Client.RefreshToken(dynamics365CrawlJobData);
            }
            else
            {
                var clientCredential = new ClientCredential(dynamics365CrawlJobData.ClientId, dynamics365CrawlJobData.ClientSecret);
                var authParameters = await AuthenticationParameters.CreateFromResourceUrlAsync(new Uri(webApiUrl));
                var authContext = new AuthenticationContext(authParameters.Authority);
                var authResult = authContext.AcquireTokenAsync(authParameters.Resource, clientCredential).Result;
                dynamics365CrawlJobData.TargetApiKey = authResult.AccessToken;
            }

            return await Task.FromResult(dynamics365CrawlJobData);
        }

        public override Task<bool> TestAuthentication(
            ProviderUpdateContext context,
            IDictionary<string, object> configuration,
            Guid organizationId,
            Guid userId,
            Guid providerDefinitionId)
        {
            throw new NotImplementedException();
        }

        public override Task<ExpectedStatistics> FetchUnSyncedEntityStatistics(ExecutionContext context, IDictionary<string, object> configuration, Guid organizationId, Guid userId, Guid providerDefinitionId)
        {
            throw new NotImplementedException();
        }

        public override async Task<IDictionary<string, object>> GetHelperConfiguration(
            ProviderUpdateContext context,
            [NotNull] CrawlJobData jobData,
            Guid organizationId,
            Guid userId,
            Guid providerDefinitionId)
        {
            if (jobData == null)
                throw new ArgumentNullException(nameof(jobData));

            var dictionary = new Dictionary<string, object>();

            if (jobData is Dynamics365CrawlJobData dynamics365CrawlJobData)
            {
                //TODO add the transformations from specific CrawlJobData object to dictionary
                // add tests to GetHelperConfigurationBehaviour.cs
                dictionary.Add(Dynamics365Constants.KeyName.Url, dynamics365CrawlJobData.Url);
            }

            return await Task.FromResult(dictionary);
        }

        public override Task<IDictionary<string, object>> GetHelperConfiguration(
            ProviderUpdateContext context,
            CrawlJobData jobData,
            Guid organizationId,
            Guid userId,
            Guid providerDefinitionId,
            string folderId)
        {
            throw new NotImplementedException();
        }

        public override async Task<AccountInformation> GetAccountInformation(ExecutionContext context, [NotNull] CrawlJobData jobData, Guid organizationId, Guid userId, Guid providerDefinitionId)
        {
            if (jobData == null)
                throw new ArgumentNullException(nameof(jobData));

            if (!(jobData is Dynamics365CrawlJobData dynamics365CrawlJobData))
            {
                throw new Exception("Wrong CrawlJobData type");
            }

            var client = _dynamics365ClientFactory.CreateNew(dynamics365CrawlJobData);
            return await Task.FromResult(client.GetAccountInformation());
        }

        public override string Schedule(DateTimeOffset relativeDateTime, bool webHooksEnabled)
        {
            return webHooksEnabled && ConfigurationManager.AppSettings.GetFlag("Feature.Webhooks.Enabled", false) ? $"{relativeDateTime.Minute} 0/23 * * *"
                : $"{relativeDateTime.Minute} 0/4 * * *";
        }

        public override Task<IEnumerable<WebHookSignature>> CreateWebHook(ExecutionContext context, [NotNull] CrawlJobData jobData, [NotNull] IWebhookDefinition webhookDefinition, [NotNull] IDictionary<string, object> config)
        {
            if (jobData == null)
                throw new ArgumentNullException(nameof(jobData));
            if (webhookDefinition == null)
                throw new ArgumentNullException(nameof(webhookDefinition));
            if (config == null)
                throw new ArgumentNullException(nameof(config));

            throw new NotImplementedException();
        }

        public override Task<IEnumerable<WebhookDefinition>> GetWebHooks(ExecutionContext context)
        {
            throw new NotImplementedException();
        }

        public override Task DeleteWebHook(ExecutionContext context, [NotNull] CrawlJobData jobData, [NotNull] IWebhookDefinition webhookDefinition)
        {
            if (jobData == null)
                throw new ArgumentNullException(nameof(jobData));
            if (webhookDefinition == null)
                throw new ArgumentNullException(nameof(webhookDefinition));

            throw new NotImplementedException();
        }

        public override IEnumerable<string> WebhookManagementEndpoints([NotNull] IEnumerable<string> ids)
        {
            if (ids == null)
            {
                throw new ArgumentNullException(nameof(ids));
            }

            if (!ids.Any())
            {
                throw new ArgumentException(nameof(ids));
            }

            throw new NotImplementedException();
        }

        public override async Task<CrawlLimit> GetRemainingApiAllowance(ExecutionContext context, [NotNull] CrawlJobData jobData, Guid organizationId, Guid userId, Guid providerDefinitionId)
        {
            if (jobData == null)
                throw new ArgumentNullException(nameof(jobData));


            //There is no limit set, so you can pull as often and as much as you want.
            return await Task.FromResult(new CrawlLimit(-1, TimeSpan.Zero));
        }

        // TODO Please see https://cluedin-io.github.io/CluedIn.Documentation/docs/1-Integration/build-integration.html
        public string Icon => Dynamics365Constants.IconResourceName;
        public string Domain { get; } = Dynamics365Constants.Uri;
        public string About { get; } = Dynamics365Constants.CrawlerDescription;
        public AuthMethods AuthMethods { get; } = Dynamics365Constants.AuthMethods;
        public IEnumerable<Control> Properties => null;
        public string ServiceType { get; } = JsonConvert.SerializeObject(Dynamics365Constants.ServiceType);
        public string Aliases { get; } = JsonConvert.SerializeObject(Dynamics365Constants.Aliases);
        public Guide Guide { get; set; } = new Guide
        {
            Instructions = Dynamics365Constants.Instructions,
            Value = new List<string> { Dynamics365Constants.CrawlerDescription },
            Details = Dynamics365Constants.Details

        };

        public string Details { get; set; } = Dynamics365Constants.Details;
        public string Category { get; set; } = Dynamics365Constants.Category;
        public new IntegrationType Type { get; set; } = Dynamics365Constants.Type;
    }
}
