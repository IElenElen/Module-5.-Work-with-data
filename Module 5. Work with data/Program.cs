using Newtonsoft.Json;
using System;
using System.IO;
using System.Collections.Generic;

namespace Module_5._Work_with_data
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ćwiczenia z Json.");

            //odczytanie pliku 
            string filepath = @"C:\Users\Ilka\Desktop\Kraje Europy.txt";

            Console.WriteLine($"Ścieżka do pliku: {filepath}.");

            if(File.Exists(filepath))
            {
                try
                {
                    string[] lines = File.ReadAllLines(filepath);

                    if (lines.Length > 0)
                    {
                        List<string> data = new List<string>();

                        foreach (string line in lines)
                        {
                            data.Add(line);
                        }
                        data.Add("Grecja, Ateny");
                        File.AppendAllLines(filepath, data);
                        Console.WriteLine("Nowe dane zostały dopisane.");

                        string jsonData = JsonConvert.SerializeObject(data);
                        Console.WriteLine(jsonData);
                    }
                    else
                    {
                        Console.WriteLine("Pusta zawartość pliku JSON");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Wystąpił błąd podczas odczytu pliku {ex.Message}");
                }
            }
            else 
            {
                Console.WriteLine("Plik nie istnieje");
            }
            Console.WriteLine();

            Console.WriteLine("Ćwiczenia z Plik txt.");

            //odczytanie pliku
            string filepath1 = @"C:\Users\Ilka\Desktop\Kraje Europy.txt"; 

            if (File.Exists(filepath1))
            {
                try
                {
                    string[] lines1 = File.ReadAllLines(filepath1);

                    foreach (string line1 in lines1)
                    {
                        Console.WriteLine(line1);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Wystąpił błąd podczas odczytu pliku: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Plik nie istnieje");
            }
        }
    }
}
