namespace Endpoints_API.Security
{
    using System;
    using System.IdentityModel.Tokens.Jwt;
    using System.Security.Claims;
    using Microsoft.IdentityModel.Tokens;

    public static class FakeTokenGenerator
    {
        public static string GenerateFakeToken()
        {
            var securityKey = "E1BB465D57BK;LHDLFJHSDFB4787C2D5BCF325A2E"; 
            var symmetricKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(securityKey));

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                new Claim(ClaimTypes.Name, "fake_user"),
                new Claim(ClaimTypes.Role, "admin") 
                }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(symmetricKey, SecurityAlgorithms.HmacSha256)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }

}
