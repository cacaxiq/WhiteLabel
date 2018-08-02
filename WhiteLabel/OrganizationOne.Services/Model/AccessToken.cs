using System;
using System.Collections.Generic;
using System.Text;

namespace OrganizationOne.Services.Model
{
    public class AccessToken
    {
        public string Token { get; set; }
        public bool Authenticated { get; set; }
    }
}
