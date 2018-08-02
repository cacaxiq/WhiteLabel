using System;
using System.Collections.Generic;
using System.Text;

namespace OrganizationTwo.Services.Model
{
    public class User
    {
        public string UserName { get; set; }
        public Guid Id { get; set; }
        public bool Authenticated { get; set; }
    }
}
