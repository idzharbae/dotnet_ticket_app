using AuthApp.Internal.Repository;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;

namespace AuthApp.Internal.UseCase {
    public class TokenUC : ITokenUC {
        IUserReader userReader;
        SecurityKey securityKey;
        SecurityTokenHandler securityTokenHandler;
        TokenValidationParameters tokenValidationParameters;
        public TokenUC(IUserReader userReader, SecurityKey securityKey, SecurityTokenHandler securityTokenHandler, 
        TokenValidationParameters tokenValidationParameters) {
            this.userReader = userReader;
            this.securityKey = securityKey;
            this.securityTokenHandler = securityTokenHandler;
            this.tokenValidationParameters = tokenValidationParameters;
        }
        public string GenerateFromUserObject(Entity.User user) {
            Claim[] claims = GenerateClaimsFromUserEntity(user);

            string token = GenerateTokenFromClaims(claims);
            return token;
        }
        public IEnumerable<Claim> GetClaims(string token) {
            if(string.IsNullOrEmpty(token))
                throw new RpcException(new Status(StatusCode.InvalidArgument, "token shouldn't be empty"), "");
                
            try {
                ClaimsPrincipal tokenValid = this.securityTokenHandler
                    .ValidateToken(token, tokenValidationParameters, out SecurityToken validatedToken);
                    return tokenValid.Claims;
            } catch(SecurityTokenInvalidSignatureException e) {
                throw new RpcException(new Status(StatusCode.InvalidArgument, "invalid token"), e.Message);
            } catch(ArgumentException e) {
                throw new RpcException(new Status(StatusCode.InvalidArgument, "invalid token"), e.Message);
            } catch (NullReferenceException e) {
                throw new RpcException(new Status(StatusCode.InvalidArgument, "invalid token"), e.Message);
            }
        }
        Claim[] GenerateClaimsFromUserEntity(Entity.User user) {
            return new Claim[]{
                    new Claim("id", user.Id.ToString()),
                    new Claim("full_name", user.FullName),
                    new Claim(ClaimTypes.Email, user.Email)
            };
        }
        string GenerateTokenFromClaims(Claim[] claims) {
            SecurityTokenDescriptor securityTokenDescriptor = new SecurityTokenDescriptor{
                    Subject = new ClaimsIdentity(claims),
                    Expires = DateTime.UtcNow.AddDays(1),
                    SigningCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256)
                };
            SecurityToken securityToken = securityTokenHandler.CreateToken(securityTokenDescriptor);
            return securityTokenHandler.WriteToken(securityToken);
        }
    }
}