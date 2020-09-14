using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class ClientUpdateVocabulary : SimpleVocabulary
    {
        public ClientUpdateVocabulary()
        {
            VocabularyName = "Dynamics365 ClientUpdate";
            KeyPrefix = "dynamics365.clientupdate";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("ClientUpdate", group =>
            {
                this.ClientUpdateId = group.Add(new VocabularyKey("ClientUpdateId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the client update.")
                    .WithDisplayName("Client update Id")
                    .ModelProperty("clientupdateid", typeof(Guid)));

                this.Description = group.Add(new VocabularyKey("Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(512))
                    .WithDescription(@"Description of the client update.")
                    .WithDisplayName("Description")
                    .ModelProperty("description", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("VersionNumber")
                    .ModelProperty("versionnumber", typeof(int)));

                this.SqlScript = group.Add(new VocabularyKey("SqlScript", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Contents of the client update.")
                    .WithDisplayName("SQL Script")
                    .ModelProperty("sqlscript", typeof(string)));

                this.WhenExecute = group.Add(new VocabularyKey("WhenExecute", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only. Values are: 1 - Before SchemaChanges; 2 - After SchemaChanges but before Download data; 3 - After download data.")
                    .WithDisplayName("WhenExecute")
                    .ModelProperty("whenexecute", typeof(string)));

                this.WasExecuted = group.Add(new VocabularyKey("WasExecuted", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only. Should be set by client to 1 after action was executed.")
                    .WithDisplayName("WasExecuted")
                    .ModelProperty("wasexecuted", typeof(bool)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only. Date and time when the ClientUpdate script was created on server.")
                    .WithDisplayName("CreatedOn")
                    .ModelProperty("createdon", typeof(DateTime)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey ClientUpdateId { get; private set; }

        public VocabularyKey Description { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey SqlScript { get; private set; }

        public VocabularyKey WhenExecute { get; private set; }

        public VocabularyKey WasExecuted { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }


    }
}

