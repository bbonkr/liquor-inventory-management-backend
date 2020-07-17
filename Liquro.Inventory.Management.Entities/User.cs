using System;
using System.Collections;
using System.Collections.Generic;

namespace Liquro.Inventory.Management.Entities
{
    public class User : BaseIdentifierModel
    {
        /// <summary>
        /// 사용자 계정 이름
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 성
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// 이름
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// 출력이름
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// 비밀번호
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 전자우편주소
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 로그인 실패 횟수
        /// </summary>
        public int FailCount { get; set; }
        /// <summary>
        /// 사용여부
        /// </summary>
        public bool IsEnabled { get; set; }

        /// <summary>
        /// 최근 로그인 시각
        /// </summary>
        public DateTimeOffset RecentlySignIn { get; set; }

        /// <summary>
        /// 사용자 매장
        /// </summary>
        public virtual IList<UserBusiness> Businesses { get; set; }
    }
}
