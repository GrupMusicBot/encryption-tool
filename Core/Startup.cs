using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;

namespace FileEncryption.Core
{
    public class Startup
    {
        /// <summary>
        /// Ran when the user runs the program.
        /// </summary>
        /// <returns></returns>
        public static bool StartLogic()
        {
            string InputPath = Path.Combine(Directory.GetCurrentDirectory(), "Input");
            string OutputPath = Path.Combine(Directory.GetCurrentDirectory(), "Output");
            string README = Path.Combine(Directory.GetCurrentDirectory(), "README.txt");

            //If user boots the program for the first time, it will create all the required directories along with the README.txt. If for whatever reason the program fails it displays error and returns false
            try
            {
                if (!Directory.Exists(InputPath))
                    Directory.CreateDirectory(InputPath);
                if (!Directory.Exists(OutputPath))
                    Directory.CreateDirectory(OutputPath);
                if (!File.Exists(README)) { 
                    File.Create(README).Close();
                    Startup.README();
                }

                Console.WriteLine("Created & Verified all required Directories");
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine($"An Error has Occured : [{e}]");
                return false;
            }


        }

        public static void README()
        {
            string RM = Path.Combine(Directory.GetCurrentDirectory(), "README.txt");
            string Text = $"This program was written by KuebV \nOriginal Repo : https://github.com/GrupMusicBot/encryption-tool \nYou are free to adapt this code into your own codebase if needed";
            File.WriteAllText(RM, Text);

        }
    }
}
