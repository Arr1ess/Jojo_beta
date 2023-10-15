using System.ComponentModel.DataAnnotations;

namespace Startup_School_Jojo.Db.Modeks
{
    public class Plugin
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Icon { get; set; }
        public string BackgroundImage { get; set; }
        public string Description { get; set; }
        public string StateScheme { get; set; }
    }
}
