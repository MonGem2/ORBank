using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ORBank
{
    class WorkWithFiles
    {
        public static void FillingOrCreateFilling_Main_File(string NewLogin,string NewPassword,string NewName,string NewPhone,
            string NewSurname, string CardNum,string NewPIN)
        {
            string Main_File = @"files\main_file.ob";
            if (!File.Exists(Main_File))
            {
                FileStream fs = File.Create(Main_File);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(NewLogin);
                bw.Write(NewPassword);
                bw.Write(NewName);
                bw.Write(NewSurname);
                bw.Write(NewPhone);
                bw.Write(CardNum);
                bw.Write(NewPIN);
                bw.Write("\n");
                bw.Close();
                fs.Close();
                bw.Close();
                fs.Close();
            }
            else
            {
                FileStream fs = File.Open(Main_File, FileMode.Append);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(NewLogin);
                bw.Write(NewPassword);
                bw.Write(NewName);
                bw.Write(NewSurname);
                bw.Write(NewPhone);
                bw.Write(CardNum);
                bw.Write(NewPIN);
                bw.Close();
                fs.Close();
            }
        }

        List<string> File_Crypter(string NewLogin, string NewPassword, string NewName, string NewPhone,
            string NewSurname, string CardNum, string NewPIN)
        {
            
            
            return new List<string>{NewLogin,NewPassword,NewName,NewPhone,NewSurname,CardNum,NewPIN};
        }
        List<string> File_Decrypter(string NewLogin, string NewPassword, string NewName, string NewPhone,
            string NewSurname, string CardNum, string NewPIN)
        {
            

            return new List<string> { NewLogin, NewPassword, NewName, NewPhone, NewSurname, CardNum, NewPIN };
        }

    }
}
