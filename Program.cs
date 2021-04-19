using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashingOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            int exitMenuChoice = 0;

            while (exitMenuChoice != 3)
            {
                Console.WriteLine("Write the text to hash");
                string textToHash = Console.ReadLine();
                string hashedText = "";
                byte[] key = Key.KeyGenerator(32);
                int switchChoice;
                int hashOrHMac;

                Console.WriteLine("1. Hash\n2. HMac");
                hashOrHMac = MenuChoose(1, 2);

                Console.WriteLine("1. MD5\n2. Sha1\n3. Sha256\n4. Sha512");
                switchChoice = MenuChoose(1, 4);

                hashedText = ChosenHashMethod(hashOrHMac, switchChoice, textToHash, key);

                Console.Clear();

                if (hashOrHMac == 2)
                {
                    Console.WriteLine(Convert.ToBase64String(key));
                }

                Console.WriteLine(textToHash);
                Console.WriteLine(hashedText);

                Console.WriteLine("\n1. Validate\n2. Try again\n3. Exit");
                exitMenuChoice = MenuChoose(1, 3);

                if (exitMenuChoice == 1)
                {
                    Console.WriteLine("Validated Hash: "+ChosenHashMethod(hashOrHMac, switchChoice, textToHash, key));
                }

                Console.WriteLine("Enter to continue");
                Console.ReadKey(true);
                Console.Clear();
            }
        }

        private static string ChosenHashMethod(int hashOrHMac, int switchChoice, string textToHash, byte[] key)
        {
            string hashedText = "";
            if (hashOrHMac == 1)
            {
                switch (switchChoice)
                {
                    case 1:
                        hashedText = Convert.ToBase64String(Hash.MD5Hash(textToHash));
                        break;

                    case 2:
                        hashedText = Convert.ToBase64String(Hash.Sha1Hash(textToHash));
                        break;

                    case 3:
                        hashedText = Convert.ToBase64String(Hash.Sha256Hash(textToHash));
                        break;

                    case 4:
                        hashedText = Convert.ToBase64String(Hash.Sha512Hash(textToHash));
                        break;
                }
            }
            else if (hashOrHMac == 2)
            {
                switch (switchChoice)
                {
                    case 1:
                        hashedText = Convert.ToBase64String(HMac.MD5Hash(textToHash, key));
                        break;

                    case 2:
                        hashedText = Convert.ToBase64String(HMac.Sha1Hash(textToHash, key));
                        break;

                    case 3:
                        hashedText = Convert.ToBase64String(HMac.Sha256Hash(textToHash, key));
                        break;

                    case 4:
                        hashedText = Convert.ToBase64String(HMac.Sha512Hash(textToHash, key));
                        break;
                }
            }

            return hashedText;
        }

        private static int MenuChoose(int numbOne, int numbTwo)
        {
            int input = 0;
            while (input < numbOne || input > numbTwo)
            {
                try
                {
                    Console.Write("\nChoose: ");
                    input = Convert.ToInt32(Console.ReadLine());
                }
                catch
                { }
            }

            return input;
        }
    }
}
