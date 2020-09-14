using System;
    using CluedIn.Core.Data;
    using CluedIn.Core.Data.Vocabularies;

    namespace CluedIn.Crawling.Dynamics365.Vocabularies
    {
        public class UnresolvedAddressVocabulary : SimpleVocabulary
        {
            public UnresolvedAddressVocabulary()
            {
                VocabularyName = "Dynamics365 UnresolvedAddress";
                KeyPrefix = "dynamics365.unresolvedaddress";
                KeySeparator = ".";
                Grouping = EntityType.Unknown; // TODO: Set value

                this.AddGroup("UnresolvedAddress", group =>
                {
                    this.UnresolvedAddressId = group.Add(new VocabularyKey("UnresolvedAddressId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"For internal use only.")
                        .WithDisplayName("UnresolvedAddressId")
                        .ModelProperty("unresolvedaddressid", typeof(Guid)));
                    
                    this.FullName = group.Add(new VocabularyKey("FullName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                        .WithDescription(@"For internal use only.")
                        .WithDisplayName("FullName")
                        .ModelProperty("fullname", typeof(string)));
                    
                    this.Telephone = group.Add(new VocabularyKey("Telephone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                        .WithDescription(@"For internal use only.")
                        .WithDisplayName("Telephone")
                        .ModelProperty("telephone", typeof(string)));
                    
                    this.EMailAddress = group.Add(new VocabularyKey("EMailAddress", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                        .WithDescription(@"For internal use only.")
                        .WithDisplayName("EMailAddress")
                        .ModelProperty("emailaddress", typeof(string)));
                    
                    this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("VersionNumber")
                        .ModelProperty("versionnumber", typeof(int)));
                    
                    
                });

                // Mappings
                //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
            }

            public VocabularyKey UnresolvedAddressId { get; private set; }
        
        public VocabularyKey FullName { get; private set; }
        
        public VocabularyKey Telephone { get; private set; }
        
        public VocabularyKey EMailAddress { get; private set; }
        
        public VocabularyKey VersionNumber { get; private set; }
        
        
        }
    }
    
