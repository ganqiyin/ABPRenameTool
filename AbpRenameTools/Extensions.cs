using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpRenameTools
{
    public static class Extensions
    {
        /// <summary>
        /// 获取标识符后面的字符串
        /// </summary>
        /// <param name="org"></param>
        /// <param name="flag"></param>
        /// <returns></returns>
        public static string GetEndValueByLastIndexOf(this string org, string flag)
        {
            return org.Substring(org.LastIndexOf(flag) + 1);
        }

        /// <summary>
        /// 获取标识符后面的字符串
        /// </summary>
        /// <param name="org"></param>
        /// <param name="flag"></param>
        /// <returns></returns>
        public static string GetStartValueByLastIndexOf(this string org, string flag)
        {
            return org.Substring(0, org.LastIndexOf(flag));
        }
    }
}
