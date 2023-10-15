using System.ComponentModel.DataAnnotations;

namespace Startup_School_Jojo.Db.Modeks
{
    public class Sample
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string PluginId { get; set; }
        public int UserId { get; set; }
        public string State { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
    }
}
