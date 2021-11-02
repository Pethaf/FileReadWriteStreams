using System;
using System.Collections.Generic;

namespace FileReadWriteStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            MyFileHandler mf = new MyFileHandler();
            mf.ReadAllContent("testfil1.txt");
            mf.WriteContentToFile("testfil2", "Jag är en fisk");
            mf.UpperCaseContent("rock.txt", "rockuppercase.txt");
            mf.ReadLatinEncodedContent("latin1.txt");
                }

    }
}
