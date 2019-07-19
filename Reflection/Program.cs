using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            string resourceName = "ReflectionTextFile.txt";
            string location = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                resourceName);

            if (File.Exists(location))
            {
                var type = new List<string>();
                var assembly = Assembly.GetExecutingAssembly();
                string resource = assembly.GetManifestResourceNames().Single(str => str.EndsWith("ReflectionTextFile.txt"));
                using (Stream stream = assembly.GetManifestResourceStream(resource))
                using (var reader = new StreamReader(stream))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        type.Add(line);
                    }
                }

                var firstCar = assembly.CreateInstance(type[0]) as ICar;
                var secondCar = assembly.CreateInstance(type[1]) as ICar;
                var thirdCar = assembly.CreateInstance(type[2]) as ICar;

                
            }
            else
                Console.WriteLine("The targeted text file does not exist!");

            Console.ReadKey();
        }
    }
}
