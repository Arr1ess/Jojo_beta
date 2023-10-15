using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Startup_School_Jojo.Db.Modeks
{
    [PrimaryKey(nameof(User1Id), nameof(User2Id))]
    public class Friend
    {
        public int User1Id { get; set; }
        public int User2Id { get; set; }
    }
}
