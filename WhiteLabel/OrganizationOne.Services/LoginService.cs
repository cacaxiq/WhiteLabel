using AppBase.Services.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using OrganizationOne.Services.Interface;
using OrganizationOne.Services.Model;
using OrganizationOne.Services.Refit;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrganizationOne.Services
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
            //var response = await Client().GetUser(username, password);

            #region Mock
            AccessToken response;

            if (username == "Carlos")
                response = new AccessToken { Authenticated = true, Token = string.Empty };
            else
                response = new AccessToken { Authenticated = false, Token = string.Empty };
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
