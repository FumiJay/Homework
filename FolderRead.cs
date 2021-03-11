using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework
{
    class FolderRead
    {
        public static void CreateFolder(string path)
        {
            string Ans = "";
            Console.WriteLine("\n確定要執行此動作嗎? \n Yes.執行 / No.取消 \n");
            Ans = Console.ReadLine();
            if (Ans == "Yes" || Ans == "yes" || Ans == "y" || Ans == "Y")
            {
                if (Directory.Exists(path))
                {
                    Console.WriteLine($"Already have this {path}");
                    return;
                }
                else if (Directory.Exists(path + "NewFolder"))
                {
                    Console.WriteLine($"建立失敗 \n{path}已經已有相同名稱的資料夾");
                    return;
                }
                else
                {
                    Directory.CreateDirectory(path);
                    Console.WriteLine($"\n --- Already created {path} folder. ---\n");
                }
            }
            else
            {
                Console.WriteLine($"取消指令,回到列表\n");
            }
        }

        public static void DeleteFolder(string path)
        {
            if (!Directory.Exists(path))
            {
                Console.WriteLine($"刪除失敗 \n{path}無該名稱的資料夾");
                return;
            }
            else
            {
                foreach (string deleteAll in Directory.GetFileSystemEntries(path))
                {
                    if (File.Exists(deleteAll))
                        File.Delete(deleteAll); //直接刪除其中的文件
                    else
                        DeleteFolder(deleteAll); //遞歸刪除子文件夾
                }
                Directory.Delete(path);
                Console.WriteLine($"\n --- Already delete your {path} folder . ---\n");
            }
        }
    }
}
