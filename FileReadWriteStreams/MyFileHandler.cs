using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReadWriteStreams
{
    class MyFileHandler
    {
        public void ReadAllContent(string fileName)
        {
            using(StreamReader sr = new StreamReader(fileName))
            {
                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }
        }
        public void WriteContentToFile(string FileName, string contentToWrite)
        {
            using(StreamWriter sw = new StreamWriter(FileName))
            {

                sw.WriteLine(contentToWrite);
            }
        }
        public void UpperCaseContent(string filename1, string filename2)
        {
            using(StreamReader sr = new StreamReader(filename1))
            {
                using(StreamWriter sw = new StreamWriter(filename2))
                {
                    while (!sr.EndOfStream)
                    {
                        sw.WriteLine(sr.ReadLine().ToUpper());
                    }
                }
            }
        }
        public void ReadLatinEncodedContent(string fileName)
        {
            using(StreamReader sw = new StreamReader(fileName,Encoding.Latin1))
            {
                while (!sw.EndOfStream)
                {
                    var theChar = sw.Read();
                    var theString = $"{theChar,-25} {(char)theChar}";
                    Console.WriteLine(theString);
                }
            }
        }
    }
}
