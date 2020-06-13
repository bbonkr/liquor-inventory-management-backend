using System;
namespace Liquro.Inventory.Management.Entities
{
    public class CommonCode:BaseIdentifierModel
    {
        //[Required]
        public string Code { get; set; }

        //[Required]
        public string Text { get; set; }

        /// <summary>
        /// 약어
        /// </summary>
        public string Abbreviation { get; set; }

        public bool Enabled { get; set; } = true;

        //[Required]
        public int Ordinal { get; set; } = 1;

        public string Note { get; set; }

        public string GroupId { get; set; }

        //[ForeignKey("GroupId")]
        public virtual CommonCodeGroup Group { get; set; }
    }
}
