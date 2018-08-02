using AppBase.Services.Model;

namespace OrganizationOne.Services.Model
{
    public class AccessToken : IModelBase
    {
        public string Token { get; set; }
        public bool Authenticated { get; set; }
    }
}
