using System;
using System.IO;

namespace AbpRenameTools
{
    public class FileHelper
    {
        private FileHelper()
        { }

        private static readonly object lockRoot = new object();

        private static FileHelper _instance;

        public static FileHelper GetInstance()
        {
            if (_instance == null)
            {
                lock (lockRoot)
                {
                    if (_instance == null)
                    {
                        _instance = new FileHelper();
                    }
                }
            }
            return _instance;
        }

        /// <summary>
        /// 读取文件内容
        /// </summary>
        /// <param name="filePath">文件路径</param>
        /// <returns></returns>
        public string ReadFileContent(string filePath)
        {
            var content = "";
            if (File.Exists(filePath))
                content = File.ReadAllText(filePath);
            return content;
        }

        /// <summary>
        /// 写文件内容
        /// </summary>
        /// <param name="filePath">文件路径</param>
        /// <param name="content">文件内容</param>
        /// <returns></returns>
        public void WriteFileByContent(string filePath,string content)
        {
            if (!string.IsNullOrWhiteSpace(content))
                File.WriteAllText(filePath, content);
        }

        /// <summary>
        /// 重命名
        /// </summary>
        /// <param name="oldFile"></param>
        /// <param name="newFile"></param>
        public void Rename(string oldFile, string newFile)
        {
            var file = new FileInfo(oldFile);
            file.MoveTo(newFile);
        }
    }
}
