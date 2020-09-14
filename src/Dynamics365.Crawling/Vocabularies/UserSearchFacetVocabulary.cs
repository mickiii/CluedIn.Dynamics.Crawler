using System;
    using CluedIn.Core.Data;
    using CluedIn.Core.Data.Vocabularies;

    namespace CluedIn.Crawling.Dynamics365.Vocabularies
    {
        public class UserSearchFacetVocabulary : SimpleVocabulary
        {
            public UserSearchFacetVocabulary()
            {
                VocabularyName = "Dynamics365 UserSearchFacet";
                KeyPrefix = "dynamics365.usersearchfacet";
                KeySeparator = ".";
                Grouping = EntityType.Unknown; // TODO: Set value

                this.AddGroup("UserSearchFacet", group =>
                {
                    this.UserSearchFacetId = group.Add(new VocabularyKey("UserSearchFacetId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("UserSearchFacetId")
                        .ModelProperty("usersearchfacetid", typeof(Guid)));
                    
                    this.SystemUserId = group.Add(new VocabularyKey("SystemUserId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("SystemUserId")
                        .ModelProperty("systemuserid", typeof(Guid)));
                    
                    this.EntityName = group.Add(new VocabularyKey("EntityName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(64))
                        .WithDescription(@"")
                        .WithDisplayName("EntityName")
                        .ModelProperty("entityname", typeof(string)));
                    
                    this.AttributeName = group.Add(new VocabularyKey("AttributeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(50))
                        .WithDescription(@"")
                        .WithDisplayName("AttributeName")
                        .ModelProperty("attributename", typeof(string)));
                    
                    this.FacetOrder = group.Add(new VocabularyKey("FacetOrder", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("FacetOrder")
                        .ModelProperty("facetorder", typeof(long)));
                    
                    
                });

                // Mappings
                //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
            }

            public VocabularyKey UserSearchFacetId { get; private set; }
        
        public VocabularyKey SystemUserId { get; private set; }
        
        public VocabularyKey EntityName { get; private set; }
        
        public VocabularyKey AttributeName { get; private set; }
        
        public VocabularyKey FacetOrder { get; private set; }
        
        
        }
    }
    
