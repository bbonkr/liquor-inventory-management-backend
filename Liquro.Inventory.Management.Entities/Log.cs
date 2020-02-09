using System;
namespace Liquro.Inventory.Management.Entities
{
    public class Log
    {
        public string Level { get; set; }

        public string Message { get; set; }

        public string Detail { get; set; }

        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
