using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ass_Lib
{
    class Subtitles
    {
        /// <summary>
        /// 读取对应路径的ass文件，去除时间轴信息
        /// </summary>
        /// <param name="filepath">文件路径</param>
        /// <returns>返回处理后文本</returns>
        public static string ReadAssFile(string filepath)
        {
            using (FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read))
            {
                byte[] a = new byte[1024 * 1024 * 5];
                int readlen = fs.Read(a, 0, a.Length); //实际读取到的长度
                string readstr = Encoding.UTF8.GetString(a, 0, readlen);
                string firstkey = "Dialogue"; //筛选的第一个关键字
                string secondkey = ",,0,0,0,,"; //筛选的第二个关键字

                int firstlocation = readstr.IndexOf(firstkey);
                readstr = readstr.Remove(0, firstlocation); //去掉ass文件前面的信息
                while (true)//查找第一个和第二个关键字的索引，然后删除，当没有索引后就跳出循环
                {
                    int first_location = readstr.IndexOf(firstkey);
                    if (first_location == -1)
                    {
                        break;
                    }
                    int second_location = readstr.IndexOf(secondkey);
                    readstr = readstr.Remove(first_location, second_location - first_location + 9);
                }
                return readstr;
            }
        }


        /// <summary>
        /// 提取ass字幕文件时间轴数据
        /// </summary>
        /// <param name="readstr">读取到的字符串</param>
        /// <returns>返回一个包含时间轴数据的泛型集合</returns>
        public static List<string> AssGetDataTime(string readstr)
        {
            List<string> datatimelist = new List<string>();
            while (true)
            {

                string firstkey = "Dialogue"; //筛选的第一个关键字

                int first_location = readstr.IndexOf(firstkey);
                if (first_location == -1)
                {
                    break;
                }
                datatimelist.Add(readstr.Substring(first_location + 12, 21));
                readstr = readstr.Remove(first_location, firstkey.Length);
            }
            return datatimelist;

        }

        /// <summary>
        /// 获取srt字幕的时间轴数据（未转换）
        /// </summary>
        /// <param name="readstr">读取到的文本</param>
        /// <returns>返回一个string泛型集合</returns>
        public static List<string> SrtGetDataTime(string readstr)
        {
            List<string> datatimelist = new List<string>();
            while (true)
            {

                string firstkey = "-->"; //筛选的第一个关键字

                int first_location = readstr.IndexOf(firstkey);
                if (first_location == -1)
                {
                    break;
                }
                datatimelist.Add(readstr.Substring(first_location - 13, 12));
                datatimelist.Add(readstr.Substring(first_location + 4, 12));
                readstr = readstr.Remove(first_location, firstkey.Length);
            }
            return datatimelist;
        }




    }
}
