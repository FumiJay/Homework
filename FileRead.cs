using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework
{
    class FileRead
    {
        public static void MoveFile(string path, string Content)
        {
            string Ans = "";
            Console.WriteLine("\n確定要執行此動作嗎? \n Yes.執行 / No.取消 \n");
            Ans = Console.ReadLine();
            if (Ans == "Yes" || Ans == "yes" || Ans == "y" || Ans == "Y")
            {
                if (File.Exists(Content)) //檢測有無[目標]同名檔案
                {
                    Console.WriteLine($"移動失敗. \n{Content}已有相同名稱的檔案. \n");
                    return;
                }
                else if (!File.Exists(path))  //檢測有無[來源]路徑和檔案
                {
                    Console.WriteLine($"移動失敗. \n請確認下面的路徑和檔案\n{path}.");
                    return;
                }
                else if (!Directory.Exists(Path.GetDirectoryName(Content))) //檢測有無[目標]路徑
                {
                    Console.WriteLine($"移動失敗. \n請確認下面的路徑和檔案\n{Content}.");
                    return;
                }
                File.Move(path, Content);  // 排除所有錯誤後正確執行
                Console.WriteLine($"\n --- Your file already when{path} move to {Content}---");
            }
            else  // 取消執行時的指令
            {
                Console.WriteLine($"取消指令,回到列表\n"); 
            }
        }

        public static void CopyFile(string path, string Content)
        {
            string Ans = "";
            Console.WriteLine("\n確定要執行此動作嗎? \n Yes.執行 / No.取消 \n");
            Ans = Console.ReadLine();
            if (Ans == "Yes" || Ans == "yes" || Ans == "y" || Ans == "Y")
            {

                if (File.Exists(Content)) //檢測有無[目標]同名檔案
                {
                    Console.WriteLine($"複製失敗. \n{Content}已有相同名稱的檔案. \n");
                    return;
                }
                else if (!File.Exists(path))  //檢測有無[來源]路徑和檔案
                {
                    Console.WriteLine($"複製失敗. \n請確認下面的路徑和檔案\n{path}.");
                    return;
                }
                else if (!Directory.Exists(Path.GetDirectoryName(Content))) //檢測有無[目標]路徑
                {
                    Console.WriteLine($"複製失敗. \n請確認下面的路徑和檔案\n{Content}.");
                    return;
                }
                else
                {
                    File.Copy(path, Content);
                    Console.WriteLine($"\n --- Already copy your {path} file to {Content}. ---\n");
                    return;
                }
            }
            else 
            {
                Console.WriteLine($"取消指令,回到列表\n");
            }
}
        public static void ReadFile(string path)
        {
            string Ans = "";
            Console.WriteLine("\n確定要執行此動作嗎? \n Yes.執行 / No.取消 \n");
            Ans = Console.ReadLine();
            if (Ans == "Yes" || Ans == "yes" || Ans == "y" || Ans == "Y")
            {
                if (!File.Exists(path))
                {
                    Console.WriteLine($"讀取失敗. \n請確認下面的路徑和檔案\n{path}.");
                    return;
                }
                else
                {
                    string content = File.ReadAllText(path);
                    Console.WriteLine($"\n --- Opened your {path} file. ---\n");
                    Console.WriteLine(content);
                    Console.WriteLine("");
                    return;
                }
            }
            else
            {
                Console.WriteLine($"取消指令,回到列表\n");
            }
        }

        public static void DeleteFile(string path)
        {
            string Ans = "";
            Console.WriteLine("\n確定要執行此動作嗎? \n Yes.執行 / No.取消 \n");
            Ans = Console.ReadLine();
            if (Ans == "Yes" || Ans == "yes" || Ans == "y" || Ans == "Y")
            {
                if (!File.Exists(path))
                {
                    Console.WriteLine($"刪除失敗. \n請確認下面的路徑和檔案\n{path}."); ;
                }
                else
                {
                    File.Delete(path);
                    Console.WriteLine($"\n --- Already delete your {path} file . ---\n");
                    return;
                }
            }
            else
            {
                Console.WriteLine($"取消指令,回到列表\n");
            }
        }


  
    }
}
