using System;

namespace FileEncryption
{
    public class Program
    {
        static void Main(string[] args)
        {

            bool x = true;
            Console.WriteLine("Launching Program");
            if (Core.Startup.StartLogic())
            {
                Console.WriteLine("Startup Logic is completed with no errors!\n\n\n\n\n");
            }
            else if (!Core.Startup.StartLogic())
            {
                Console.WriteLine("There was an issue with the startup logic!");
            }
            else
            {
                Console.WriteLine("There was an unknown issue with the startup logic!");
                return;
            }

            while (x)
            {
                StartupMenu();
                int selection = Int32.Parse(Console.ReadLine());
                switch (selection)
                {
                    case 1:
                        Console.WriteLine("File Encryption Selected");
                        Core.Encrypt.EncryptFileMenu();
                        break;
                    case 2:
                        Console.WriteLine("File Decryption Selected");
                        Core.Decrypt.DecryptFileMenu();
                        break;
                    case 3:
                        x = false;
                        break;

                }
            }
            return;
        }

        private static void StartupMenu()
        {
            Console.WriteLine("Encryption Tool\n------------------------\n1. File Encryption\n2. File Decryption\n3. Logout");
            Console.WriteLine("------------------------\n[Use the corresponding numbers to make a selection]\n-----------------------");
        }
    }
}
