using OrganizationTwo.Services.Model;
using Refit;
using System.Threading.Tasks;

namespace OrganizationTwo.Services.Refit
{
    interface ILoginApi
    {
        [Post("/api/accessApi?username={username}&password={password}")]
        Task<User> GetUser([Body]UserInfoDTO userInfo);
    }
}
