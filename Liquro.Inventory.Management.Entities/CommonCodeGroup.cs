using System;
using System.Collections.Generic;

namespace Liquro.Inventory.Management.Entities
{
    public class CommonCodeGroup:BaseIdentifierModel
    {
        //[Required]
        public string Group { get; set; }

        //[Required]
        public string Title { get; set; }

        public string Note { get; set; }

        //[InverseProperty("GroupId")]
        public virtual IList<CommonCode> Codes { get; set; }

        public string businessId { get; set; }

        public virtual Business Business { get; set; }
    }
}
