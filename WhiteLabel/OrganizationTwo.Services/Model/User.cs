using AppBase.Services.Model;
using System;

namespace OrganizationTwo.Services.Model
{
    public class User : IModelBase
    {
        public string UserName { get; set; }
        public Guid Id { get; set; }
        public bool Authenticated { get; set; }
    }
}
