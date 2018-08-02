using OrganizationOne.Services.Model;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationOne.Services.Refit
{
    interface ILoginApi
    {
        [Get("/token?username={username}&password={password}")]
        Task<AccessToken> GetUser(string username, string password);
    }
}
