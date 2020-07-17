using System;
using System.Collections.Generic;
using System.Text;

namespace Liquro.Inventory.Management.Entities
{
    public class UserBusiness:BaseModel
    {
        public string UserId { get; set; }

        public string BusinessId { get; set; }

        public virtual User User { get; set; }

        public virtual Business Business { get; set; }
    }
}
