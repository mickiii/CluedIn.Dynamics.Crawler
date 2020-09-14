using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class RoleTemplate : DynamicsModel
    {
        [JsonProperty("roletemplateid")]
        public Guid? RoleTemplateId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("upgrading")]
        public bool? Upgrading { get; set; }


    }
}

