using System;
namespace Liquro.Inventory.Management.Entities
{
    public class Supplier : BaseIdentifierModel
    {
        //[Required]
        public string NameOfCompany { get; set; }

        public string Phone1 { get; set; }

        public string Phone2 { get; set; }

        public string Phone3 { get; set; }

        public string Mobile1 { get; set; }

        public string Mobile2 { get; set; }

        public string Mobile3 { get; set; }

        public string Email { get; set; }

        /// <summary>
        /// 사업자 등록번호
        /// </summary>
        public string BusinessRegisterationNumber1 { get; set; }

        public string BusinessRegisterationNumber2 { get; set; }

        public string BusinessRegisterationNumber3 { get; set; }

        /// <summary>
        /// 법인등록번호
        /// </summary>
        public string CoperationRegisterationNumber1 { get; set; }

        public string CoperationRegisterationNumber2 { get; set; }

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
        public virtual CommonCode Phone1Code { get; set; }

        //[ForeignKey("Mobile1")]
        public virtual CommonCode Mobile1Code { get; set; }

        //[NotMapped]
        public string Phone
        {
            get
            {
                string phone = String.Empty;

                if (Phone1Code != null)
                {
                    phone = $"{Phone1Code.Abbreviation}-{Phone2}-{Phone3}";
                }

                return phone;
            }
        }

        //[NotMapped]
        public string Mobile
        {
            get
            {
                string mobile = String.Empty;

                if (Mobile1Code != null)
                {
                    mobile = $"{Mobile1Code.Abbreviation}-{Mobile2}-{Mobile3}";
                }

                return mobile;
            }
        }

        //[NotMapped]
        public string BusinessRegisterationNumber
        {
            get
            {
                string businessRegisterationNumber = String.Empty;

                if (!String.IsNullOrWhiteSpace(BusinessRegisterationNumber1) &&
                    !String.IsNullOrWhiteSpace(BusinessRegisterationNumber2) &&
                    !String.IsNullOrWhiteSpace(BusinessRegisterationNumber3))
                {
                    businessRegisterationNumber = $"{BusinessRegisterationNumber1}-{BusinessRegisterationNumber2}-{BusinessRegisterationNumber3}";
                }

                return businessRegisterationNumber;
            }
        }

        //[NotMapped]
        public string CoperationRegisterationNumber
        {
            get
            {
                string coperationRegisterationNumber = String.Empty;

                if (!String.IsNullOrWhiteSpace(CoperationRegisterationNumber1) &&
                    !String.IsNullOrWhiteSpace(CoperationRegisterationNumber2))
                {
                    coperationRegisterationNumber = $"{CoperationRegisterationNumber1}-{CoperationRegisterationNumber2}";
                }

                return coperationRegisterationNumber;
            }
        }

        public string NoteOnList
        {
            get
            {
                var noteOnList = Note;
                try
                {
                    if (!String.IsNullOrWhiteSpace(noteOnList))
                    {
                        if (noteOnList.Contains(Environment.NewLine))
                        {
                            noteOnList = noteOnList?.Replace(Environment.NewLine, " ");
                        }

                        if (noteOnList.Length > 30)
                        {
                            noteOnList = $"{noteOnList.Substring(0, 30)} ...";
                        }
                    }
                }
                catch (Exception)
                {
                    noteOnList = Note;
                }
                return noteOnList;
            }
        }
    }
}
