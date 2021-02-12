using System;
using System.Collections.Generic;
using System.IO;
using System.Security.AccessControl;
using System.Security.Cryptography;

namespace FileEncryption.Core
{
    public class Encrypt
    {
        /// <summary>
        /// Show the Encrypt File Menu (Single Files only)
        /// </summary>
        public static void EncryptFileMenu()
        {
            Console.Clear();
            Console.WriteLine("Single File Encryption");
            Console.WriteLine("------------------------\nA few steps before you continue" +
                " \n1. Be sure your file you want to encrypt is in the Input folder" +
                " \n2. Make sure you type the name of the file correctly." +
                " \n3. Make a backup, sometimes encryption isnt guanteed, so make a backup");
            Console.WriteLine("------------------------");
            Console.WriteLine("Input the name of the file :\n");
            string FileName = Console.ReadLine();
            EncryptFile(FileName.ToString());
        }
        /// <summary>
        /// Encrypt a single file (Single file only)
        /// </summary>
        /// <param name="path_to_file"></param>
        public static void EncryptFile(string path_to_file)
        {
            string InputFolder = Path.Combine(Directory.GetCurrentDirectory(), "Input");
            string File_To_Encrypt = Path.Combine(InputFolder, path_to_file);

            try
            {
                File.Encrypt(File_To_Encrypt);
                Console.WriteLine($"Done, Encrypted file - {File_To_Encrypt.ToString()}");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Could not find file!\nCreating File Now...");
                File.Create(File_To_Encrypt).Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("An error has occured while attempting to encrypt the file");
                Console.WriteLine(e);
            }
        }


    }
}
