using AppBase.Services.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using OrganizationTwo.Services.Interface;
using OrganizationTwo.Services.Model;
using OrganizationTwo.Services.Refit;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrganizationTwo.Services
{
    public class LoginService : ILoginService
    {
        private ILoginApi Client()
        {
            return RestService.For<ILoginApi>("https://api.github.com",
                new RefitSettings
                {
                    JsonSerializerSettings = new JsonSerializerSettings
                    {
                        ContractResolver = new CamelCasePropertyNamesContractResolver()
                    }
                });
        }

        public async Task<CommandResult<IModelBase>> ExecuteLogin(string username, string password)
        {
            var request = new UserInfoDTO { Name = username, AccessKey = password };

            var response = await Client().GetUser(request);

            #region Mock
            if (username == "Carlos")
                response = new User { Authenticated = true, Id = new System.Guid(), UserName = username };
            else
                response = new User { Authenticated = false, Id = new System.Guid(), UserName = username };
            #endregion

            if (response.Authenticated)
            {
                return new CommandResult<IModelBase>
                {
                    Data = response,
                    Success = response.Authenticated
                };
            }

            var erros = new List<string>
            {
                "Erro ao realizar login"
            };

            return new CommandResult<IModelBase>
            {
                Data = null,
                Success = response.Authenticated,
                Erros = erros
            };
        }
    }
}
