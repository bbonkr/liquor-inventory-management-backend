using System;
namespace Liquro.Inventory.Management.Entities
{
    public class AlcoholSupplier
    {
        public string AlcoholId { get; set; }

        public string SupplierId { get; set; }

        [ForeignKey("AlcoholId")]
        public virtual Alcohol Alcohol { get; set; }

        [ForeignKey("SupplierId")]
        public virtual Supplier Supplier { get; set; }

        /// <summary>
        /// 단위 가격
        /// </summary>
        public double UnitPrice { get; set; }

        public string Note { get; set; }

        public string AlcoholName
        {
            get
            {
                return Alcohol?.Name;
            }
        }

        [NotMapped]
        public string SupplierName
        {
            get
            {
                return Supplier.NameOfCompany;
            }
        }

        [NotMapped]
        public string AlcholAndSupplierDisplayName
        {
            get { return $"{Alcohol.DisplayName} {Supplier?.NameOfCompany}"; }
        }

        [NotMapped]
        public string SupplierDisplayName
        {
            get { return Supplier?.NameOfCompany; }
        }

        [NotMapped]
        public string SupplierNameAndUnitPrice
        {
            get
            {
                return $"[{Supplier?.NameOfCompany}]: {UnitPrice:n0}";
            }
        }

        [NotMapped]
        public string UnitPriceString
        {
            get
            {
                return $"{UnitPrice:n0}";
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    double tmp = 0;
                    if (double.TryParse(value, out tmp))
                    {
                        UnitPrice = tmp;
                    }
                }
            }
        }
    }
}
