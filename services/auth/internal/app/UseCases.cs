using AuthApp.Internal.UseCase;
using System;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;

namespace AuthApp.Internal.App {
    public class UseCases {
        public IUserUC userUC {get;}
        public ITokenUC tokenUC {get;}
        public UseCases(Repos repos, string secretKey) {
            SecurityKey securityKey = new SymmetricSecurityKey(Convert.FromBase64String(secretKey));
            SecurityTokenHandler securityTokenHandler = new JwtSecurityTokenHandler();
            TokenValidationParameters tokenValidationParameters = new TokenValidationParameters(){
                ValidateIssuer = false,
                ValidateAudience = false,
                IssuerSigningKey = securityKey
            };

            userUC = new UserUC(repos.userReader, repos.userWriter);
            tokenUC = new TokenUC(repos.userReader, securityKey, securityTokenHandler, tokenValidationParameters);
        }
    }
}