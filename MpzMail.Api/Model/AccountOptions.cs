using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MpzMail.Api.Model
{
    public class AccountOptions
    {
        public AgencyAccount? AgencyAccount { get; set; }
        public string AgencyId { get; set; }
        public AccountType? Type { get; set; }
        public UserLanguage? InitialUserLanguage { get; set; }
    }
}
