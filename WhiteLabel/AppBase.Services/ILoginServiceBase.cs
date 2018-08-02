using AppBase.Services.Model;
using System.Threading.Tasks;

namespace AppBase.Services
{
    public interface ILoginServiceBase
    {
        Task<CommandResult<IModelBase>> ExecuteLogin(string username, string password);
    }
}
