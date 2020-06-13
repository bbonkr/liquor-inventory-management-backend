using System;

namespace Liquro.Inventory.Management.Entities
{
    public class User : BaseIdentifierModel
    {
        public string UserName { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string DisplayName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public int FailCount { get; set; }

        public DateTimeOffset LatestSignIn { get; set; }
    }
}
