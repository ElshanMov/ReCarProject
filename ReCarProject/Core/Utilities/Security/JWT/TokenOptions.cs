using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public class TokenOptions //Appsetting.json - to bind the data in the appsetting.json
    {
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public int AccessTokenExpiration { get; set; } //l used int because it is minutes.
        public string SecurityKey { get; set; }
    }
}
