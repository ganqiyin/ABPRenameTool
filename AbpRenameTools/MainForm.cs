using System;
using System.IO;
using System.Windows.Forms;

namespace AbpRenameTools
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnFolderBrowser_Click(object sender, EventArgs e)
        {
            var openFolder = new FolderBrowserDialog();
            openFolder.Description = "选择文件目录";
            if (openFolder.ShowDialog() == DialogResult.OK)
            {
                tbFilePath.Text = openFolder.SelectedPath;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tbOrgName.Text = "MyCompanyName.AbpZeroTemplate";
            tbNewName.Text = "GR";
            tbChildDir.Text = "src,test";
            tbFilterPath.Text = "bin,obj,Properties";
            tbFilterFileExt.Text = "xml,json";
        }

        private void btnBuilder_Click(object sender, EventArgs e)
        {
            tsslStatus.Text = "开始执行";
            var orgName = tbOrgName.Text;
            var newName = tbNewName.Text;
            var rootDir = tbFilePath.Text;
            //
            var rootDirs = FolderHelper.GetInstance().GetDirectories(rootDir);
            //
            WirteFile(rootDir, orgName, newName, "sln");
            //处理目录
            foreach (var dir in rootDirs)
            {
                //
                var temp = dir.FullName.GetEndValueByLastIndexOf(@"\");
                var rootPath = dir.FullName.GetStartValueByLastIndexOf(@"\");
                if (tbChildDir.Text.Contains(temp))
                {
                    var newPath = Path.Combine(rootPath, temp);
                    var childDirs = FolderHelper.GetInstance().GetDirectories(newPath);
                    foreach (var item in childDirs)
                    { 
                        //
                        WirteFile(item.FullName, orgName, newName, "csproj");
                        //
                        temp = item.FullName.GetEndValueByLastIndexOf(@"\");
                        rootPath = item.FullName.GetStartValueByLastIndexOf(@"\");
                        if (temp.Contains(orgName))
                        {
                            var newTemp = temp.Replace(orgName, newName);
                            var newDir = Path.Combine(rootPath, newTemp);
                            if (!Directory.Exists(newDir))
                                item.MoveTo(newDir);
                        }
                    }
                }
                else
                { 
                    //
                    WirteFile(dir.FullName, orgName, newName, "csproj");
                    //
                    if (temp.Contains(orgName))
                    {
                        var newTemp = temp.Replace(orgName, newName);
                        var newDir = Path.Combine(rootPath, newTemp);
                        if (!Directory.Exists(newDir))
                            dir.MoveTo(newDir);
                    }
                }
            }
        }

        private void WirteFile(string dir, string orgName, string newName, string fileExt)
        {
            var rootFiles = FolderHelper.GetInstance().GetFiles(dir);
            //处理文件
            foreach (var fileitem in rootFiles)
            {
                var ext = fileitem.FullName.GetEndValueByLastIndexOf(".");
                if (ext == fileExt)
                {
                    tsslStatus.Text = $"修改文件{fileitem.Name}内容";
                    var content = FileHelper.GetInstance().ReadFileContent(fileitem.FullName);
                    content = content.Replace(orgName, newName);
                    FileHelper.GetInstance().WriteFileByContent(fileitem.FullName, content);
                    //
                    var fileName = fileitem.FullName.GetEndValueByLastIndexOf(@"\").GetStartValueByLastIndexOf(".");
                    if (fileName.Contains(orgName))
                    {
                        tsslStatus.Text = $"重命名文件：{fileitem.Name}";
                        var newFileName = Path.Combine(fileitem.FullName.GetStartValueByLastIndexOf(@"\"), string.Format("{0}.{1}", fileName.Replace(orgName, newName), ext));
                        FileHelper.GetInstance().Rename(fileitem.FullName, newFileName);
                    }
                }
            }
        }
    }
}
