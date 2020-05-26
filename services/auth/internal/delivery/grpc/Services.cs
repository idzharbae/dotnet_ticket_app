using AuthApp.Internal.UseCase;
using AuthApp.Internal.Util;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Security.Claims;
using System.Linq;


namespace AuthApp.Internal.Delivery.Grpc {
    #region snippet
    public class AuthService : AuthGrpc.AuthGrpcBase {
        private readonly ILogger<AuthService> _logger;
        private readonly IUserUC _userUC;
        private readonly ITokenUC _tokenUC;
        public AuthService(ILogger<AuthService> logger, IUserUC userUC, ITokenUC tokenUC) {
            _logger = logger;
            _userUC = userUC;
            _tokenUC = tokenUC;
        }

        public override Task<LoginResp> Login(LoginReq req, ServerCallContext ctx) {
            Entity.User user = this._userUC.Get(new Entity.User {
                Email = req.Email,
                Password = req.Password
            });

            string jwt = this._tokenUC.GenerateFromUserObject(user);
            return Task.FromResult(new LoginResp {
                Jwt = jwt
            });
        }
        public override Task<User> Register(User req, ServerCallContext ctx) {
            Entity.User user = new Entity.User{
                Email = req.Email, 
                FullName = req.FullName, 
                Password = req.Password
            };
            user = this._userUC.Create(user);
            return Task.FromResult(new User {
                Id = user.Id.ToString(),
                FullName = user.FullName,
                Email = user.Email
            });
        }
        public override Task<User> GetUserFromToken(Token req, ServerCallContext ctx) {
            List<Claim> claims = this._tokenUC.GetClaims(req.Token_).ToList();

            return Task.FromResult(ClaimConverter.ConvertClaimsToUserProto(claims));
        }
        public override Task<User> GetUserById(GetUserByIdReq req, ServerCallContext ctx) {
            Entity.User user = this._userUC.Get(new Entity.User{
                Id = Parser.ParseGuid(req.Id)
            });

            return Task.FromResult(new User {
                Id = user.Id.ToString(),
                FullName = user.FullName,
                Email = user.Email
            });
        }
        public override Task<User> GetUserByEmail(GetUserByEmailReq req, ServerCallContext ctx) {
            Entity.User user = this._userUC.Get(new Entity.User{
                Email = req.Email
            });

            return Task.FromResult(new User {
                Id = user.Id.ToString(),
                FullName = user.FullName,
                Email = user.Email
            });
        }
    }
    #endregion
}
