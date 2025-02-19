using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;

public class TokenGenerator
    {
        public static string GenerateEncodedToken(IdentityUser user)
        {
            var claims = new[]
            {
                new Claim("UserId", user.Id.ToString()),
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("behnam be hazrat @34 abas peydat konam *"));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: "www.mft.com",
                audience: "www.mft.com",
                claims: claims,
                expires: DateTime.Now.AddMinutes(2000),
                signingCredentials: creds);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }



