using System;
using System.IO;

namespace ChuckNorris
{
    class Program
    {
        static void Main(string[] args)
        {
            //Valida juhuslik nali Chuck Norrise failist
            //Salvestab naljad massiivi
            //Kuvab suvalise nalja ekraanile
            
            string randomJoke;
            randomJoke = GetRandomFromFile("chuck.txt");

            Console.WriteLine($"{randomJoke}");
        }

        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            return randomIndex;
        }

        private static string GetRandomFromFile(string fileName)
        {
            string filePath = $@"C:\Users\kaardiguru\samples\{fileName}";
            string[] dataFromFile = File.ReadAllLines(filePath);
            string randomElement = dataFromFile[GenerateRandomIndex(dataFromFile)];

            return randomElement;
        }
    }
}
