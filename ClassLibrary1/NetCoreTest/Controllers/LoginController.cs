using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreTest.AuthHelper;

namespace NetCoreTest.Controllers
{
    /// <summary>
    /// 登录
    /// </summary>
    /// 
    [Produces("application/json")]
    [Route("api/Login")]
    public class LoginController : Controller
    {

        #region Token
        /// <summary>
        /// 获取JWT，并存入缓存
        /// </summary>
        /// <param name="id">用户Id</param>
        /// <param name="sub">身份</param>
        /// <param name="expiresSliding">相对过期时间，单位为分</param>
        /// <param name="expiresAbsolute">绝对过期时间，单位为天</param>
        /// <returns></returns>
        [HttpGet]
        [Route("Token")]
        public JsonResult GetJWTStr(long id = 1, string sub = "Admin", int expiresSliding = 30, int expiresAbsolute = 30)
        {
            TokenModel tokenModel = new TokenModel();
            tokenModel.Uid = id;
            tokenModel.Sub = sub;

            DateTime dt1 = DateTime.Now;
            DateTime dt2 = dt1.AddMinutes(expiresSliding);
            DateTime dt3 = dt1.AddDays(expiresAbsolute);
            TimeSpan sliding = dt2 - dt1;
            TimeSpan absolute = dt3 - dt1;

            string jwtStr = NetCoreToken.IssueJWT(tokenModel, sliding, absolute);
            return Json(jwtStr);

        }
        #endregion
    }
}