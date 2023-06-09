﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIoDemo
{
    internal class FileDemo
    {
        public static void FileExists()
        {
            String path = "C:\\Users\\Basha\\Documents\\BridgeLabz\\FileIoDemo\\FileIoDemo\\Example.txt";
            if (File.Exists(path))
                Console.WriteLine("File exists");
            else
                Console.WriteLine("File doesn't exists");
        }

        public static void ReadAllLines()
        {
            String path = "C:\\Users\\USER\\ProfessionalWork\\FellowShip\\Fellowship05-Day20_FileIO\\Day20_FileIO\\Example.txt";
            String[] lines;
            //C: \Users/inyadav\source\repos\Day20_FileIO\Day20_FileIO
            lines = File.ReadAllLines(path);
            foreach (var item in lines)
            {
                Console.WriteLine(item);
            }

        }

        public static void ReadAllText()
        {
            String path = "C:\\Users\\Basha\\Documents\\BridgeLabz\\FileIoDemo\\FileIoDemo\\Example.txt";
            String lines;
            lines = File.ReadAllText(path);
            Console.WriteLine(lines);

        }

        public static void FileCopy()
        {
            String path = "C:\\Users\\Basha\\Documents\\BridgeLabz\\FileIoDemo\\FileIoDemo\\Example.txt";
            String copypath = "C:\\Users\\Basha\\Documents\\BridgeLabz\\FileIoDemo\\FileIoDemo\\Example.txt";

            File.Copy(path, copypath);

        }

        public static void DeleteFile()
        {
            String path = "C:\\Users\\Basha\\Documents\\BridgeLabz\\FileIoDemo\\FileIoDemo\\Example.txt";

            File.Delete(path);

        }

        public static void ReadFromStreamReader()
        {
            String path = "C:\\Users\\Basha\\Documents\\BridgeLabz\\FileIoDemo\\FileIoDemo\\Example.txt";

            using (StreamReader sr = File.OpenText(path))
            {
                String s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }

        public static void WriteUsingStreamWriter()
        {
            String path = "C:\\Users\\Basha\\Documents\\BridgeLabz\\FileIoDemo\\FileIoDemo\\Example.txt";

            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("Hellow World - .Net is awesome");
                sr.Close();
                Console.WriteLine(File.ReadAllText(path));
            }

        }
    }
}
