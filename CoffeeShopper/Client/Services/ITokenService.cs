using IdentityModel.Client;
using System.Runtime.CompilerServices;

namespace Client.Services
{
    public interface ITokenService
    {
        Task<TokenResponse> GetToken(string scope);

    }
}
