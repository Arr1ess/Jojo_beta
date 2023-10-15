using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Startup_School_Jojo.Db.Modeks
{
    [PrimaryKey(nameof(UserId), nameof(WorkspaceId))]
    public class UserWorkspaceRelation
    {
        public int UserId { get; set; }
        public string WorkspaceId { get; set; }
    }
}
