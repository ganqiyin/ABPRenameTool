using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpRenameTools
{
    public class FolderHelper
    {
        private FolderHelper()
        { }

        private static readonly object lockRoot = new object();

        private static FolderHelper _instance;

        public static FolderHelper GetInstance()
        {
            if (_instance == null)
            {
                lock (lockRoot)
                {
                    if (_instance == null)
                    {
                        _instance = new FolderHelper();
                    }
                }
            }
            return _instance;
        }

        /// <summary>
        /// 获取当前目录的子目录
        /// </summary>
        /// <param name="path">当前目录</param>
        /// <returns></returns>
        public DirectoryInfo[] GetDirectories(string path)
        {
            return new DirectoryInfo(path).GetDirectories();
        }


        /// <summary>
        /// 获取当前目录的文件
        /// </summary>
        /// <param name="path">当前目录</param>
        /// <returns></returns>
        public FileInfo[] GetFiles(string path)
        {
            return new DirectoryInfo(path).GetFiles();
        }

        /// <summary>
        /// 重命名
        /// </summary>
        /// <param name="directory"></param>
        /// <param name="newDirectoryName">新名称</param>
        public void Rename(DirectoryInfo directory,string newDirectoryName)
        {
            directory.MoveTo(newDirectoryName);
        } 
    }
}
