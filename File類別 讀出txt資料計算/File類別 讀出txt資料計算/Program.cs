using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File類別_讀出txt資料計算
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo fi = new FileInfo("G:\\C#檔案\\data.txt");
            FileStream fs = new FileStream(fi.FullName, FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            string read = "";
            for(int i=0;i<sr.BaseStream.Length;i++)
            {
                read = read + (char)sr.Read();
            }
            Console.WriteLine(read);

            string[] data = read.Split(',');
            float average = 0;

            for(int i=0;i<data.Length;i++)
            {
                average = average + float.Parse(data[i]);
            }

            average = average / data.Length;

            Console.WriteLine("平均為"+average.ToString());

            Console.ReadLine();
        }
    }
}
