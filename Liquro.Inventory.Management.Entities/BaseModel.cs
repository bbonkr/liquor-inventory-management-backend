using System;

namespace Liquro.Inventory.Management.Entities
{
    /// <summary>
    /// 엔티티 기본 필드를 제공합니다.
    /// </summary>
    public abstract class BaseModel
    {
        /// <summary>
        /// 작성자 식별자
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// 작성일시
        /// </summary>
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// 수정자 식별자
        /// </summary>
        public string UpdatedBy { get; set; }

        /// <summary>
        /// 수정일시
        /// </summary>
        public DateTimeOffset UpdatedAt { get; set; }
    }

    /// <summary>
    /// 식별자를 갖는 엔티티 기본 필드를 제공합니다.
    /// </summary>
    public abstract class BaseIdentifierModel : BaseModel
    {
        /// <summary>
        /// 식별자
        /// </summary>
        public string Id { get; set; }
    }
}
