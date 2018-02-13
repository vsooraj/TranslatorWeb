namespace Ivedix.Translator.Web.Models
{
    public class Platformkey
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int KeyId { get; set; }
        public int PlatformId { get; set; }
        public int FilegroupId { get; set; }
        public bool InApp { get; set; }
        public bool IsActive { get; set; }
    }

}
