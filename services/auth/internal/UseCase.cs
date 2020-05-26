using AuthApp.Internal.Entity;
using System.Collections.Generic;
using System.Security.Claims;

namespace AuthApp.Internal.UseCase {
    public interface ITokenUC {
        string GenerateFromUserObject(User user);
        IEnumerable<Claim> GetClaims(string token);
    }
    public interface IUserUC {
        User Get(User user);
        User Create(User user);
        User Update(User user);
        User Delete(User user);
    }
}