using CloudIABackend.Models;
using System.Threading.Tasks;

namespace CloudIABackend.Interface
{
    public interface ITokenService
    {
        Task<string> CreateToken(AppUser user);
    }
}
