using System;
using System.Collections.Generic;
using System.Text;

namespace Liquro.Inventory.Management.Entities
{
    /// <summary>
    /// 매장
    /// </summary>
    public class Business : BaseIdentifierModel
    {
        /// <summary>
        /// 명칭
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 사용여부
        /// </summary>
        public bool IsEnabled { get; set; }

        public virtual IList<Alcohol> Alcohols { get; set; }

        public virtual IList<AlcoholSupplier> AlcoholSuppliers { get; set; }
        public virtual IList<CommonCode> CommonCodes { get; set; }

        public virtual IList<CommonCodeGroup> CommonCodeGroups { get; set; }

        public virtual IList<UserBusiness> UserBusinesses { get; set; }
    }
}
