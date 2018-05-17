using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplWin
{
    class CMDcommand
    {
        //该类是用于启动CMD命令行及执行其命令的
        
        public string cmd(string command) //启动CMD，CMD命令传参
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.CreateNoWindow = true;               //不创建新窗口    
            cmd.StartInfo.UseShellExecute = false;             //不启用shell启动进程  
            cmd.StartInfo.RedirectStandardInput = true;        //重定向输入    
            cmd.StartInfo.RedirectStandardOutput = true;       //重定向标准输出    
            cmd.StartInfo.RedirectStandardError = true;        //重定向错误输出 
            cmd.Start();                                       //开启Process
            cmd.StandardInput.WriteLine(command);              //通过传参执行cmd命令
            string cmdmessage=cmd.StandardOutput.ReadToEnd();  //读取所有cmd显示信息
            cmd.StandardInput.Close();                         //关闭StandardInput
            cmd.Close();                                       //关闭Process
            return cmdmessage;
        }

        public string cmdmessage_gain(string cmdmessage, string message_success) //判断cmdmessage中的执行状态
        {
            string state = "";
            if (cmdmessage.Contains(message_success))
            {
                state="安装成功";
            }
            else
            {
                state="安装失败";
            }
            return state;
        }

        public void ShowSecondsInSystemClock() //让时钟显示秒
        {
            cmd("reg add HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced /v ShowSecondsInSystemClock /t REG_DWORD /d 1 /f & taskkill /F /IM explorer.exe & start %windir%\\explorer.exe & exit /b");
        }

        public void Shell_Icons() //去除快捷方式箭头,去除盾牌图标
        {
            cmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Shell Icons\" /v 29 /t REG_SZ /d %windir%\\system32\\imageres.dll,197 /f & reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Shell Icons\" /v 77 /t REG_SZ /d %windir%\\system32\\imageres.dll,197 /f & taskkill /F /IM explorer.exe & attrib -s -r -h %userprofile%\\AppData\\Local\\iconcache.db & del %userprofile%\\AppData\\Local\\iconcache.db /f /q & start %windir%\\explorer.exe & exit /b");
        }

        public string Net_Framework35() //安装.Net Framework 3.5
        {
            string cmdmessage = cmd("dism.exe /online /enable-feature /featurename:NetFX3 /Source:\"C:\\.Net Framework 3.5\" /norestart & exit /b"); //cmd显示消息
            string state=cmdmessage_gain(cmdmessage, "操作成功完成。"); //组件安装状态判断
            return state;
        }
    }
}
