using System;
using System.ComponentModel;
using System.IO;
using System.Text;

namespace Examples.FileIO
{
    public class WritingReading
    {
        public void RunExample()
        {
            WriteFile();
            string result = ReadFile();
            Console.WriteLine(result);
        }

        private void WriteFile()
        {
            string[] lines = {"hello", "world", "how", "are", "you"};
            using StreamWriter sw = new StreamWriter("MyLines.txt");
            foreach (string line in lines)
            {
                sw.WriteLine(line);
            }
        }

        private string ReadFile()
        {
            StringBuilder sb = new StringBuilder();
            using StreamReader sr = new StreamReader("MyLines.txt");
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                sb.AppendLine(line);
            }

            return sb.ToString();
        }
    }
}