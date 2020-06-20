using System;
namespace Liquro.Inventory.Management.Entities
{
    public class Supplier : BaseIdentifierModel
    {
        //[Required]
        public string NameOfCompany { get; set; }

        /// <summary>
        /// 전화번호
        /// </summary>
        public string Phone { get; set; }
        
        /// <summary>
        /// 휴대전화번호
        /// </summary>
        public string Mobile { get; set; }
    
        /// <summary>
        /// 전자우편주소
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 사업자등록번호
        /// </summary>
        public string BusinessRegistrationNumber { get; set; }

        /// <summary>
        /// 법인등록번호
        /// </summary>
        public string CorporationRegistrationNumber { get; set; }
        
        /// <summary>
        /// 업태
        /// </summary>
        public string BusinessType { get; set; }

        /// <summary>
        /// 업종
        /// </summary>
        public string BusinessItem { get; set; }

        public string BusinessZipcode { get; set; }

        public string BusinessAddress { get; set; }

        public string BusinessAddressDetail { get; set; }

        /// <summary>
        /// 대표자 이름
        /// </summary>
        public string RepresentativeName { get; set; }

        public string Note { get; set; }

        //[ForeignKey("Phone1")]
        //public virtual CommonCode Phone1Code { get; set; }

        //[ForeignKey("Mobile1")]
        //public virtual CommonCode Mobile1Code { get; set; }

        
        //public string NoteOnList
        //{
        //    get
        //    {
        //        var noteOnList = Note;
        //        try
        //        {
        //            if (!String.IsNullOrWhiteSpace(noteOnList))
        //            {
        //                if (noteOnList.Contains(Environment.NewLine))
        //                {
        //                    noteOnList = noteOnList?.Replace(Environment.NewLine, " ");
        //                }

        //                if (noteOnList.Length > 30)
        //                {
        //                    noteOnList = $"{noteOnList.Substring(0, 30)} ...";
        //                }
        //            }
        //        }
        //        catch (Exception)
        //        {
        //            noteOnList = Note;
        //        }
        //        return noteOnList;
        //    }
        //}
    }
}
