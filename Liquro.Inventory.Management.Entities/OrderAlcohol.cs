using System;
namespace Liquro.Inventory.Management.Entities
{
    public class OrderAlcohol : BaseIdentifierModel
    {
        /// <summary>
        /// 주문일자
        /// </summary>
        //[Required]
        public DateTimeOffset OrderDate { get; set; }

        /// <summary>
        /// 주류
        /// </summary>
        [Obsolete("AlcoholSupplier 엔티티로 이동되었습니다. 제거될 예정이므로 사용하지 않습니다.")]
        public string AlcoholId { get; set; }

        /// <summary>
        /// 주류-공급업체
        /// </summary>
        public string AlcoholSupplierId { get; set; }

        /// <summary>
        /// 도수
        /// </summary>
        public double Frequency { get; set; }

        /// <summary>
        /// 용량
        /// </summary>
        public double Volume { get; set; }

        /// <summary>
        /// 수량
        /// </summary>
        //[Required]
        public int Quantity { get; set; }

        /// <summary>
        /// 단위 가격
        /// </summary>
        public double UnitPrice { get; set; }

        /// <summary>
        /// 공급업체
        /// </summary>
        [Obsolete("AlcoholSupplier 엔티티로 이동되었습니다. 제거될 예정이므로 사용하지 않습니다.")]
        public string SupplierId { get; set; }

        /// <summary>
        /// 금액
        /// </summary>
        public double Amounts { get; set; }

        /// <summary>
        /// 지급방법
        /// </summary>
        public string PaymentId { get; set; }

        /// <summary>
        /// 세금계산서 구분
        /// </summary>
        public string TaxBillId { get; set; }

        public string Note { get; set; }

        //[ForeignKey("AlcoholId")]
        [Obsolete("AlcoholSupplier 엔티티로 이동되었습니다. 제거될 예정이므로 사용하지 않습니다.")]
        public virtual Alcohol Alcohol { get; set; }

        //[ForeignKey("PaymentId")]
        public virtual CommonCode Payment { get; set; }

        //[ForeignKey("TaxBillId")]
        public virtual CommonCode TaxBill { get; set; }

        //[ForeignKey("SupplierId")]
        [Obsolete("AlcoholSupplier 엔티티로 이동되었습니다. 제거될 예정이므로 사용하지 않습니다.")]
        public virtual Supplier Supplier { get; set; }

        //[ForeignKey(nameof(AlcoholSupplierId))]
        public virtual AlcoholSupplier AlcoholSupplier { get; set; }

        //[NotMapped]
        public string AlcoholName
        {
            get => AlcoholSupplier?.Alcohol?.Name;
        }

        //[NotMapped]
        public string KindsText
        {
            get => AlcoholSupplier?.Alcohol?.KindsText;
        }

        //[NotMapped]
        public string SupplierName
        {
            get => AlcoholSupplier?.Supplier?.NameOfCompany;
        }

        //[NotMapped]
        public string PaymentText
        {
            get => Payment?.Text;
        }

        //[NotMapped]
        public string TaxBillText
        {
            get => TaxBill?.Text;
        }

        //[NotMapped]
        public string OrderDateString
        {
            get => String.Format("{0:yyyy-MM-dd}", OrderDate);
        }

        public string Test { get; set; }
    }
}
