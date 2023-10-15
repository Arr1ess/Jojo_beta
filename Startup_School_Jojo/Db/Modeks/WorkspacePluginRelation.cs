using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Startup_School_Jojo.Db.Modeks
{
    public class WorkspacePluginRelation
    {
        [Key]
        public string WorkspaceId { get; set; } = Guid.NewGuid().ToString();
        public string PluginId { get; set; } = "";
    }
}
