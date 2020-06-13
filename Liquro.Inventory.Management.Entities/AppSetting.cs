using System;
namespace Liquro.Inventory.Management.Entities
{
    public class AppSetting : BaseIdentifierModel
    {
        /// <summary>
        /// Key
        /// </summary>
        //[Required]
        public string key { get; set; }

        /// <summary>
        /// Value
        /// </summary>
        //[Required]
        public string Value { get; set; }

        /// <summary>
        /// Value's type description.
        /// <para>Type must be string that defines in AppSettingTypes</para>
        /// </summary>
        //public string Type { get; set; }

        public string Note { get; set; }
    }
}
