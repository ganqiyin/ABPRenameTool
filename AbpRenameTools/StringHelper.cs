using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpRenameTools
{
    public class StringHelper
    {
        private StringHelper()
        { }

        private static readonly object lockRoot = new object();

        private static StringHelper _instance;

        public static StringHelper GetInstance()
        {
            if (_instance == null)
            {
                lock (lockRoot)
                {
                    if (_instance == null)
                    {
                        _instance = new StringHelper();
                    }
                }
            }
            return _instance;
        }
         
    }
}
