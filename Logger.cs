using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerLib
{
    enum Mask
    {
        TIME = 1,
        USER,
        MASSAGE
    }
    public static class Logger
    {
        public static string LogPath { get; set; }
        public static string MaskPath { get; set; }
        //private static DateTime time;
        private static Mask[] mask;
        //private static string user;
        //private static string massage;
        public static void WriteLog(string user, string massage)
        {
            try
            {                
                using (StreamWriter sw = new StreamWriter(LogPath, true, Encoding.Unicode))
                {
                    for (int i = 0; i < mask.Length; i++)
                    {
                        switch(mask[i])
                        {
                            case Mask.TIME:
                                sw.Write(DateTime.Now + ";  ");
                                break;
                            case Mask.USER:
                                sw.Write(user + ";  ");
                                break;
                            case Mask.MASSAGE:
                                sw.Write(massage + ";  ");
                                break;
                        }
                    }
                    sw.WriteLine();
                    sw.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void ReadMask()
        {
            mask = new Mask[3];
            try
            {
                using (StreamReader sr = new StreamReader(MaskPath, Encoding.UTF8))
                {
                    int i = 1;
                    while (!sr.EndOfStream)
                    {
                        string str = sr.ReadLine();
                        int pos;
                        int.TryParse(string.Join("", str.Where(c => char.IsDigit(c))), out pos);
                        mask[pos] = (Mask)i;
                        i++;
                    }
                    sr.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Ошибка чтения файла настроек");
                Console.WriteLine("Применены настройки по умолчанию");
                for (int i = 0; i < 3; i++)
                {
                    mask[i] = (Mask)i+1;
                }
            }
        }
    }
}
