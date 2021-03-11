using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Temp\\";
            string Newpath = "D:\\Temp\\";
            string filename = "aaa.txt";
            string Ans = "";
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Welecome to File Edit program. \nWhat do you want to do today? \n");
            DateTime startTime = DateTime.Now;
            do
            {
                Console.WriteLine("請輸入要執行的動作編號");
                Console.WriteLine("1.搬移檔案 2.拷貝檔案 3.讀取檔案 4.刪除檔案 5.建立資料夾 6.刪除資料夾 ");
                
                string UserEnter = Console.ReadLine();
                switch (UserEnter)
                {
                    case "1": // 搬移檔案
                        DateTime move_st = DateTime.Now;   //計時開始
                        FileRead.MoveFile(path + filename , Newpath + filename);  //開始執行
                        DateTime move_et = DateTime.Now;   //計時結束
                        TimeSpan m_st_et = move_et - move_st; //結算時間
                        Console.WriteLine($"\n 執行此動作使用{m_st_et}毫秒."); //輸出程式的運行時間
                        break;

                    case "2": // 拷貝檔案
                        DateTime copy_st = DateTime.Now;   //計時開始
                        FileRead.CopyFile(path + filename, Newpath + filename);  //開始執行
                        DateTime copy_et = DateTime.Now;   //計時結束
                        TimeSpan c_st_et = copy_et - copy_st; //結算時間
                        Console.WriteLine($"\n 執行此動作使用{c_st_et}毫秒."); //輸出程式的運行時間
                        break;

                    case "3": // 讀取檔案
                        DateTime read_st = DateTime.Now;   //計時開始
                        FileRead.ReadFile(path + filename);  //開始執行
                        DateTime read_et = DateTime.Now;   //計時結束
                        TimeSpan r_st_et = read_et - read_st; //結算時間
                        Console.WriteLine($"\n 執行此動作使用{r_st_et}毫秒."); //輸出程式的運行時間
                        break;

                    case "4": // 刪除檔案
                        DateTime delete_st = DateTime.Now;   //計時開始
                        FileRead.DeleteFile(path + "aaa2.txt");  //開始執行
                        DateTime delete_et = DateTime.Now;   //計時結束
                        TimeSpan d_st_et = delete_et - delete_st; //結算時間
                        Console.WriteLine($"\n 執行此動作使用{d_st_et}毫秒."); //輸出程式的運行時間
                        break;

                    case "5": // 建立資料夾
                        DateTime cr_st = DateTime.Now;   //計時開始
                        FolderRead.CreateFolder(path + "NewFolder");  //開始執行
                        DateTime cr_et = DateTime.Now;   //計時結束
                        TimeSpan cr_st_et = cr_et - cr_st; //結算時間
                        Console.WriteLine($"\n 執行此動作使用{cr_st_et}毫秒."); //輸出程式的運行時間
                        break;

                    case "6": // 刪除資料夾
                        DateTime df_st = DateTime.Now;
                        Console.WriteLine("\n確定要執行此動作嗎? \n Yes.執行 / No.取消 \n");
                        Ans = Console.ReadLine();
                        if (Ans == "Yes" || Ans == "yes" || Ans == "y" || Ans == "Y")
                        {
                            FolderRead.DeleteFolder(path + "NewFolder");  //開始執行
                        }
                        else
                        {
                            Console.WriteLine($"取消指令,回到列表\n");
                        }
                            DateTime df_et = DateTime.Now;   //計時結束
                        TimeSpan df_st_et = df_et - df_st; //結算時間
                        Console.WriteLine($"\n 執行此動作使用{df_st_et}毫秒."); //輸出程式的運行時間
                        break;
                }
                Console.WriteLine("請問還有需要執行其他動作嗎? \n Yes.回到選單 / No.關閉程式 \n");
                Ans = Console.ReadLine();
            }
            while 
            (Ans == "Yes" || Ans == "yes" || Ans == "y" || Ans == "Y");
            Console.WriteLine("程式即將結束，感謝使用.");
            DateTime endTime = DateTime.Now;
            TimeSpan ts = endTime - startTime;
            Console.WriteLine($"\n已使用本程式共歷時 " + ts.TotalMilliseconds + " 毫秒.");
            Console.ReadLine();
        }

    }
}
