namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class Associatedmenuconfiguration
    {
        public string Behavior { get; set; }
        public string Group { get; set; }
        public int? Order { get; set; }
        public bool IsCustomizable { get; set; }
        public string Icon { get; set; }
        public string ViewId { get; set; }
        public bool AvailableOffline { get; set; }
        public string MenuId { get; set; }
        public string QueryApi { get; set; }
        public Label Label { get; set; }
    }

}
