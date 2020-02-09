using System;
namespace Liquro.Inventory.Management.Entities
{
    public class CommonCodeGroup
    {
        [Required]
        public string Group { get; set; }

        [Required]
        public string Title { get; set; }

        public string Note { get; set; }

        //[InverseProperty("GroupId")]
        public virtual ICollection<CommonCode> Codes { get; set; }
    }
}
