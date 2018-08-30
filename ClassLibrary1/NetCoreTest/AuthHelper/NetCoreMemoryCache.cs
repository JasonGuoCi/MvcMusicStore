using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreTest.AuthHelper
{
    /// <summary>
    /// 集成常用的对MemoryCache的操作
    /// </summary>
    public class NetCoreMemoryCache
    {
        /// <summary>
        /// 缓存字段
        /// </summary>
        public static MemoryCache _cache = new MemoryCache(new MemoryCacheOptions());

        /// <summary>
        /// 验证缓存项是否存在
        /// </summary>
        /// <param name="key">缓存key</param>
        /// <returns></returns>
        public static bool Exists(string key)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            object cached;
            return _cache.TryGetValue(key, out cached);
        }

        /// <summary>
        /// 获取缓存
        /// </summary>
        /// <param name="key">缓存key</param>
        /// <returns></returns>
        public static object Get(string key)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            return _cache.Get(key);
        }

        /// <summary>
        /// 添加缓存
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="expiresSliding">滑动过期时长（如果在过期时间内有操作，则以当前时间点延长过期时间）</param>
        /// <param name="expiresAbsolute">绝对过期时长</param>
        /// <returns></returns>
        public static bool AddMemoryCache(string key, object value, TimeSpan expiresSliding, TimeSpan expiresAbsolute)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            _cache.Set(key, value,
                new MemoryCacheEntryOptions()
                .SetSlidingExpiration(expiresSliding)
                .SetAbsoluteExpiration(expiresAbsolute));

            return Exists(key);
        }
    }
}
