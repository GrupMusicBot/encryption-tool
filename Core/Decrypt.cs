using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileEncryption.Core
{
    public class Decrypt
    {
        public static void DecryptFileMenu()
        {
            Console.Clear();
            Console.WriteLine("Single File Decryption");
            Console.WriteLine("------------------------\nJust go through this quick instruction on what to do: \n" +
                "1. Find the file you want decrypted, and place it in the Input Directory\n" +
                "2. Paste the name into the console when it prompts you to\n" +
                "3. The File you Decrypted will appear in the Output Directory");
            Console.WriteLine("------------------------");
            Console.WriteLine("Input the name of the file :\n");
            string FileName = Console.ReadLine();
            DecryptFile(FileName);
        }
        /// <summary>
        /// Decrypt a file and moves it to the Output File
        /// </summary>
        /// <param name="FileName"></param>
        public static void DecryptFile(string FileName)
        {
            string Output = Path.Combine(Directory.GetCurrentDirectory(), "Output");
            string Input = Path.Combine(Directory.GetCurrentDirectory(), "Input");

            string GetFile = Path.Combine(Input, FileName);
            try
            {
                File.Decrypt(GetFile);

                File.Move(GetFile, Output);
                Console.WriteLine("Done, File has been decryped and moved to the Output Folder!");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"File not found!\nError Message : [{e}]");
            }
            catch (Exception e)
            {
                Console.WriteLine($"An unexpected error has occured : [{e}]");
            }
        }
    }
}
