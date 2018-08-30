using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace NetCoreTest.AuthHelper
{
    /// <summary>
    /// 中间件，每次网络请求的时候，都走这里，作为报文获取判断，并防篡改
    /// </summary>
    public class TokenAuth
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly RequestDelegate _next;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="next"></param>
        public TokenAuth(RequestDelegate next)
        {
            _next = next;
        }
        /// <summary>
        /// 验证授权
        /// </summary>
        /// <param name="httpContext"></param>
        /// <returns></returns>
        public Task Invoke(HttpContext httpContext)
        {
            var headers = httpContext.Request.Headers;

            //检测是否包含'Authorization'请求头，如果不包含返回context进行下一个中间件，用于访问不需要认证的API
            if (!headers.ContainsKey("Authorization"))
            {
                return _next(httpContext);
            }

            var tokenStr = headers["Authorization"];
            try
            {
                string jwtStr = tokenStr.ToString().Trim();

                //如果存在Authorization，但是和缓存的不一样，那就是被篡改了
                if (!NetCoreMemoryCache.Exists(jwtStr))
                {
                    return httpContext.Response.WriteAsync("非法请求");
                }

                TokenModel tm = (TokenModel)NetCoreMemoryCache.Get(jwtStr);

                //提取tokenModel中的Sub属性进行authorize认证
                List<Claim> lc = new List<Claim>();
                Claim c = new Claim(tm.Sub + "Type", tm.Sub);
                lc.Add(c);

                ClaimsIdentity identity = new ClaimsIdentity(lc);
                ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                httpContext.User = principal;

                return _next(httpContext);
            }
            catch (Exception)
            {

                return httpContext.Response.WriteAsync("token验证异常");
            }
        }
    }
}
