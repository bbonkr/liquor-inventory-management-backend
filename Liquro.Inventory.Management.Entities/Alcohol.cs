using System;

namespace Liquro.Inventory.Management.Entities
{
    public class Alcohol : ModelBase
    {
        public string Name { get; set; }

        /// <summary>
        /// 종류
        /// </summary>
        public string KindsId { get; set; }

        /// <summary>
        /// 도수
        /// </summary>
        public double Frequency { get; set; }

        /// <summary>
        /// 용량
        /// </summary>
        public double Volume { get; set; }

        /// <summary>
        /// 단위 가격 
        /// </summary>
        [Obsolete("AlcoholSupplier 엔티티로 이동되었습니다. 제거될 예정이므로 사용하지 않습니다.")]
        public double UnitPrice { get; set; }

        /// <summary>
        /// 공급처
        /// </summary>
        [Obsolete("AlcoholSupplier 엔티티로 이동되었습니다. 제거될 예정이므로 사용하지 않습니다.")]
        public string SupplierId { get; set; }

        /// <summary>
        /// 비고
        /// </summary>
        public string Note { get; set; }

        [ForeignKey("KindsId")]
        public virtual CommonCode Kinds { get; set; }

        [ForeignKey("SupplierId")]
        [Obsolete("AlcoholSupplier 엔티티로 이동되었습니다. 제거될 예정이므로 사용하지 않습니다.")]
        public virtual Supplier Supplier { get; set; }

        [NotMapped]
        public string KindsText
        {
            get => Kinds?.Text;
        }

        //[NotMapped]
        //public string SupplierDisplayName
        //{
        //    get => $"{ Supplier?.NameOfCompany }";
        //}

        [NotMapped]
        public string DisplayName
        {
            get
            {
                string name = Name;
                if (!String.IsNullOrWhiteSpace(Id) && !Id.Equals(Guid.Empty.ToString("n")))
                {
                    name = $"{Name} [도수: {(Frequency == 0 ? "-" : $"{Frequency:f1}")} / 용량: {(Volume == 0 ? "-" : $"{Volume:n0}")}]";
                }
                return name;
            }
        }

        //public string Test1 { get; set; }

        //public string Test2 { get; set; }
    }
}
