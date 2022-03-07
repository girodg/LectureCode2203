using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Day04
{
    enum Superpowers
    {
        Speed = 1, LaserVision, Fly, Strength, Money, Invisibility, Telepathy, Swimming, Swinging
    }
    class Superhero
    {
        public string Name { get; set; }
        public string SecretIdentity { get; set; }
        public Superpowers Powers { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Writing CSV
            string fileName = @"C:\temp\2203\2203.csv";
            char delimiter = '-';
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.Write("Batman");
                sw.Write(delimiter);
                sw.Write(true);
                sw.Write(delimiter);
                sw.Write(5);
                sw.Write(delimiter);
                sw.Write(42.9);
            } 

            fileName = "bats.csv";
            WriteData(fileName);
            #endregion

            #region Reading CSV
            fileName = @"C:\temp\2203\2203.csv";
            //1. open the file
            using (StreamReader sr = new StreamReader(fileName))
            {
                //2. read the file
                string line = sr.ReadLine();
                string[] lines = line.Split(delimiter);
                foreach (var item in lines)
                {
                    Console.WriteLine(item);
                }
            }//3. close the file!

            //OR, do with 1 line
            string fileText = File.ReadAllText(fileName);//opens,read,closes the file

            fileName = "bats.csv";
            ReadData(fileName);
            #endregion

            #region Serializing
            List<Superhero> heroes = new List<Superhero>();
            heroes.Add(new Superhero() { Name = "Batman", SecretIdentity = "Bruce Wayne", Powers = Superpowers.Money });
            heroes.Add(new Superhero() { Name = "Superman", SecretIdentity = "Clark Kent", Powers = Superpowers.Fly });
            heroes.Add(new Superhero() { Name = "Wonder Woman", SecretIdentity = "Diana Prince", Powers = Superpowers.Strength });
            heroes.Add(new Superhero() { Name = "Aquaman", SecretIdentity = "Arthur Curry", Powers = Superpowers.Swimming });
            heroes.Add(new Superhero() { Name = "Spiderman", SecretIdentity = "Miles Morales", Powers = Superpowers.Swinging });

            fileName = Path.ChangeExtension(fileName, ".json");
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                using (JsonTextWriter jtw = new JsonTextWriter(sw))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Formatting = Formatting.Indented;
                    serializer.Serialize(jtw, heroes);
                }
            }
            #endregion

            #region Deserializing
            if (File.Exists(fileName))
            {
                string jsonText = File.ReadAllText(fileName);
                try
                {
                    List<Superhero> jL2 = JsonConvert.DeserializeObject<List<Superhero>>(jsonText);
                    foreach (Superhero hero in jL2)
                    {
                        Console.WriteLine($"I am {hero.Name} ({hero.SecretIdentity}) and I'm good at {hero.Powers}.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine($"{fileName} does not exists.");
            }
            #endregion
        }

        static void ReadData(string filePath)
        {
            char delimiter = '?';
            string fileData = File.ReadAllText(filePath);
            string[] data = fileData.Split(delimiter);
            List<int> nums = new List<int>();
            for (int i = 0; i < data.Length; i++)
            {
                if (int.TryParse(data[i], out int number))
                {
                    nums.Add(number);
                }
            }
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }

        }
        static void WriteData(string filePath)
        {
            List<int> data = new List<int>() { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            char delimiter = '?';
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                for (int i = 0; i < data.Count; i++)
                {
                    sw.Write(data[i]);
                    sw.Write(delimiter);
                }
            }

        }
    }
}
