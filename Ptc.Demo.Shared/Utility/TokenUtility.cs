using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Ptc.Demo.Shared.Utility
{
    public static class TokenUtility<T> where T : class , new()
    {
        private static JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
        private static byte[] securityKey = GetBytes("ptc12876266");
        private static TokenValidationParameters validationParameters = new TokenValidationParameters()
        {
            ValidAudience = "https://www.mywebsite.com",
            IssuerSigningKeys = new List<SecurityKey>()
        {
        (SecurityKey) new SymmetricSecurityKey(securityKey)
        },
            ValidAudiences = new List<string>()
        {
        "https://www.mywebsite.com"
        },
            ValidIssuer = "self"
        };

        public static byte[] GetBytes(string input)
        {
            byte[] numArray = new byte[input.Length * 2];
            Buffer.BlockCopy((Array)input.ToCharArray(), 0, (Array)numArray, 0, numArray.Length);
            return numArray;
        }

        public static bool HasAny(string token)
        {
            if (string.IsNullOrEmpty(token))
                return false;
            try
            {
                SecurityToken validatedToken;
                return tokenHandler.ValidateToken(token, validationParameters, out validatedToken).Claims.FirstOrDefault() != null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static T Parse(string token)
        {
            if (string.IsNullOrEmpty(token))
                throw new NullReferenceException("no input token");
            try
            {
                SecurityToken validatedToken;
                Claim claim = tokenHandler.ValidateToken(token, validationParameters, out validatedToken).Claims.FirstOrDefault<Claim>();
                if (claim == null)
                    throw new NullReferenceException("parse error");
                return JsonConvert.DeserializeObject<T>(claim.Value);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string Create(T user)
        {
            try
            {
                SecurityTokenDescriptor securityTokenDescriptor = new SecurityTokenDescriptor();
                securityTokenDescriptor.Subject = new ClaimsIdentity((IEnumerable<Claim>)new Claim[1]
                {
          new Claim("http://schemas.microsoft.com/ws/2008/06/identity/claims/userdata", JsonConvert.SerializeObject((object) user, Formatting.Indented, new JsonSerializerSettings()
          {
            PreserveReferencesHandling = PreserveReferencesHandling.Objects
          }), "http://www.w3.org/2001/XMLSchema#string", "(local)")
                });
                securityTokenDescriptor.Issuer = "self";
                securityTokenDescriptor.Audience = "https://www.mywebsite.com";
                securityTokenDescriptor.Expires = new DateTime?(DateTime.UtcNow.AddYears(1));
                securityTokenDescriptor.SigningCredentials = new SigningCredentials((SecurityKey)new SymmetricSecurityKey(securityKey), "HS256");
                SecurityTokenDescriptor tokenDescriptor = securityTokenDescriptor;
                SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);
                return tokenHandler.WriteToken(token);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
