namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class Privilege
    {
        public bool CanBeBasic { get; set; }
        public bool CanBeDeep { get; set; }
        public bool CanBeGlobal { get; set; }
        public bool CanBeLocal { get; set; }
        public bool CanBeEntityReference { get; set; }
        public bool CanBeParentEntityReference { get; set; }
        public string Name { get; set; }
        public string PrivilegeId { get; set; }
        public string PrivilegeType { get; set; }
    }

}
