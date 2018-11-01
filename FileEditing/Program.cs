using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileEditing
{
    class Program
    {
        static void Main(string[] args)
        {
            string localFile = "../../files/test.txt";
            if (File.Exists(localFile))
            {
                FileStream fs = new FileStream(localFile, FileMode.Open, FileAccess.ReadWrite, FileShare.Read);
                Console.WriteLine(fs.Name);
                Console.WriteLine(fs.Length);
                Console.WriteLine(fs.Position); 
                while (fs.Position < fs.Length)
                {
                    int actualChar = fs.ReadByte();
                    Console.WriteLine("The actual bíte is: " + actualChar + " in char: " + (char)(actualChar));
                    Console.WriteLine((char)(155));
                }
            }
            else
            {
                Console.WriteLine("ERROR 404 - A fájl nem található! [" + localFile +"]");
            }
            Console.ReadKey();
        }
    }
}
