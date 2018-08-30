using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreTest.AuthHelper
{
    /// <summary>
    /// 主要方法：获取JWT字符串并存入缓存中
    /// </summary>
    public class NetCoreToken
    {
        /// <summary>
        /// 构造方法
        /// </summary>
        public NetCoreToken()
        { }

        /// <summary>
        /// 获取JWT字符串并存入缓存
        /// </summary>
        /// <param name="tokenModel"></param>
        /// <param name="expiresSliding"></param>
        /// <param name="expiresAbsolute"></param>
        /// <returns></returns>
        public static string IssueJWT(TokenModel tokenModel, TimeSpan expiresSliding, TimeSpan expiresAbsolute)
        {
            DateTime dtUTC = DateTime.UtcNow;

            Claim[] claims = new Claim[]
            {
                new Claim(JwtRegisteredClaimNames.Sub,tokenModel.Sub),//subject
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),//JWT ID,JWT唯一标识
                new Claim(JwtRegisteredClaimNames.Iat,dtUTC.ToString(),ClaimValueTypes.Integer64),//Issued At，JWT颁发的时间，采用标准unix时间，用于验证过期
            };

            JwtSecurityToken jwt = new JwtSecurityToken(
                issuer: "NetCoreTest",     //jwt签发者,非必须，自定义
                audience: tokenModel.Uname,//jwt的接收方，非必须
                claims: claims,//声明集合
                expires: dtUTC.AddHours(12),//指定token的生命周期，unix时间戳格式,非必须
                signingCredentials: new Microsoft.IdentityModel.Tokens.
                SigningCredentials(new SymmetricSecurityKey(Encoding.ASCII.GetBytes("NetCoreTest's Secret Key")),
                SecurityAlgorithms.HmacSha256)
                );

            var encodedJWT = new JwtSecurityTokenHandler().WriteToken(jwt);

            NetCoreMemoryCache.AddMemoryCache(encodedJWT, tokenModel, expiresSliding, expiresAbsolute);//将JWT字符串，令牌实体，存入缓存

            return encodedJWT;
        }
    }
}
