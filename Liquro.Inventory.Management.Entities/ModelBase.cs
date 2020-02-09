using System;

namespace Liquro.Inventory.Management.Entities
{
    public class ModelBase
    {
        public string Id { get; set; }

        public string CreatedBy { get; set; }

        public DateTime Created { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime Updated { get; set; }
    }
}
